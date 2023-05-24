using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using Sarfiat.Code;
using Sarfiat.Core;
using Sarfiat.Data;
using Sarfiat.Gui.GuiCategories;
using Sarfiat.Gui.GuiCustomers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sarfiat.Gui.GuiIncome
{
    public partial class AddIncomeForm : Form
    {
        private readonly int ID;
        private readonly IncomeUserControl incomeUserControl;
        private Income income;
        private int CategoryId;
        private int CustomerId;
        private int ProjectId;
        private readonly IDataHelper<Income> dataHelper;
        private readonly IDataHelper<Customers> dataHelperCustomers;
        private readonly IDataHelper<Categories> dataHelperCategories;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm loadingForm;

        public AddIncomeForm(int Id, int ProjectId, IncomeUserControl incomeUserControl)
        {
            InitializeComponent();
            ID = Id;
            this.incomeUserControl = incomeUserControl;
            dataHelper = (IDataHelper<Income>)ConfigrationObjectManager.GetObject("Income");
            dataHelperCustomers = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
            dataHelperCategories = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
            //dataHelper = (IDataHelper<Income>?)ConfigrationObjectManager.GetObject("Income");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.ProjectId = ProjectId;
        }
        #region Events
        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            //if (await SaveData())
            //{
            //this below line cause issue another thread use same context befor first finish 
            //categoryUserControl.LoadData();
            //Close();
            // }
            //Check fields if empty
            if (isFieldEmpty())
            {
                MessageCollection.ShowFieldsRequird();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        MessageCollection.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollection.ShowUpdateNotification();
                    }
                    Close();
                }
                else
                {
                    MessageCollection.ShowErrorServer();
                }
                loadingForm.Hide();
            }

        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            //Check fields if empty
            if (isFieldEmpty())
            {
                MessageCollection.ShowFieldsRequird();
            }
            else
            {
                loadingForm.Show();
                if (await SaveData())
                {
                    if (ID == 0)
                    {
                        MessageCollection.ShowAddNotification();
                    }
                    else
                    {
                        MessageCollection.ShowUpdateNotification();
                    }
                }
                else
                {
                    MessageCollection.ShowErrorServer();
                }
                loadingForm.Hide();
            }

        }
        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            loadingForm.Show();
            GetDataForEdit();
            loadingForm.Hide();

        }
        #endregion
        #region Methods
        private async Task<bool> SaveData()
        {
            //Add
            if (ID == 0)
            {
                var CustomerName = comboBoxCustomer.SelectedItem as string;
                var CategoryName = comboBoxCategory.SelectedItem as string;
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetCustomerId(CustomerName));
                return await AddData();

            }
            //Edit
            else
            {
                var CustomerName = comboBoxCustomer.SelectedItem as string;
                var CategoryName = comboBoxCategory.SelectedItem as string;
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetCustomerId(CustomerName));
                return await EditData();
            }
        }
        private bool isFieldEmpty()
        {
            if (comboBoxCategory.SelectedItem == null
                || comboBoxCustomer.SelectedItem == null
                || textBoxAmount.Text == string.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private async Task<bool> AddData()
        {
            //Set Data
            income = new Income
            {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                CustomerName = comboBoxCustomer.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                IncomeDate = dateTimePickerDate.Value,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                CategoryId = CategoryId,
                CustomerId = CustomerId,
                ProjectId = ProjectId
            };
            //Submit
            var result = await dataHelper.AddAsync(income);
            if (result == 1)
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية إضافة قبض",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم إضافة قبض " + income.CategoryName,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                incomeUserControl.LoadData();//we put it here so it will work after add new item and will not cause issue
                //MessageBox.Show("تمت الإضافة بنجاح");
                return true;
            }
            else
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
        }

        private async Task<bool> EditData()
        {
            //Set Data
            income = new Income
            {
                Id = ID,
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                CustomerName = comboBoxCustomer.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                IncomeDate = dateTimePickerDate.Value,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                CategoryId = CategoryId,
                CustomerId = CustomerId,
                ProjectId = ProjectId
            };
            //Submit
            var result = await dataHelper.EditAsync(income);
            if (result == 0)
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
            else
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية تعديل قبض",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل قبض " + income.CategoryName,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                incomeUserControl.LoadData();
                //MessageBox.Show("تمت التعديل بنجاح");
                return true;
            }
        }
        private async void GetDataForEdit()
        {
            //Get list of customers
            var ListCustomers = await dataHelperCustomers.GetAllDataAsync();
            comboBoxCustomer.DataSource = ListCustomers.Select(x => x.Name).ToList();
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
            comboBoxCustomer.AutoCompleteCustomSource = autoCompleteString;
            ListCustomers.Clear();

            //Get list of Categories
            var ListCategories = await dataHelperCategories.GetAllDataAsync();
            comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList();
            AutoCompleteStringCollection autoCompleteStringCategories = new AutoCompleteStringCollection();
            autoCompleteStringCategories.AddRange(ListCategories.Select(x => x.Name).ToArray());
            comboBoxCategory.AutoCompleteCustomSource = autoCompleteStringCategories;
            ListCategories.Clear();
            if (ID > 0)
            {
                income = await dataHelper.FindAsync(ID);
                // set Fields
                if (income != null)
                {
                    comboBoxCategory.SelectedItem = income.CategoryName;
                    comboBoxCategory.SelectedItem = income.CustomerName;
                    textBoxRecNo.Text = income.RecNo;
                    richTextBoxDetails.Text = income.Details;
                    dateTimePickerDate.Value = income.IncomeDate;
                    textBoxAmount.Text = income.Amount.ToString();
                    CategoryId = income.CategoryId;
                    CustomerId = income.CustomerId;
                    ProjectId = income.ProjectId;
                }
                else
                {
                    MessageCollection.ShowErrorServer();
                }

            }
        }
        #endregion


        private void SetCategoryId(string CategoryName)
        {
            //if (comboBoxCategory.Text != string.Empty)
            CategoryId = dataHelperCategories.GetAllData()
                .Where(x => x.Name == CategoryName).Select(x => x.Id).First();
            //no need for this If statment
            //if (comboBoxCategory.SelectedItem != null){}
        }
        private void SetCustomerId(string CustomerName)
        {
            //if (comboBoxCustomer.SelectedItem != null)
            //if (comboBoxCustomer.Text != string.Empty)

            CustomerId = dataHelperCustomers.GetAllData()
                .Where(x => x.Name == CustomerName).Select(x => x.Id).First();

        }

        private async void linkLabelNewCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
            var result = addCategoryForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                //Get list of Categories
                var ListCategories = await dataHelperCategories.GetAllDataAsync();
                comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList();
                AutoCompleteStringCollection autoCompleteStringCategories = new AutoCompleteStringCollection();
                autoCompleteStringCategories.AddRange(ListCategories.Select(x => x.Name).ToArray());
                comboBoxCategory.AutoCompleteCustomSource = autoCompleteStringCategories;
                ListCategories.Clear();
            }
        }

        private async void linkLabelNewCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm(0, new CustomersUserControl());
            var result = addCustomersForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                //Get list of customers
                var ListCustomers = await dataHelperCustomers.GetAllDataAsync();
                comboBoxCustomer.DataSource = ListCustomers.Select(x => x.Name).ToList();
                AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
                autoCompleteString.AddRange(ListCustomers.Select(x => x.Name).ToArray());
                comboBoxCustomer.AutoCompleteCustomSource = autoCompleteString;
                ListCustomers.Clear();
            }
        }
        //this event causes second opeation exception
        //private void AddIncomeForm_Activated(object sender, EventArgs e){GetDataForEdit();}
    }
}
