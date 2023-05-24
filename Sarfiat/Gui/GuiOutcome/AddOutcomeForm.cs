using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using Sarfiat.Code;
using Sarfiat.Core;
using Sarfiat.Data;
using Sarfiat.Gui.GuiCategories;
using Sarfiat.Gui.GuiSuppliers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sarfiat.Gui.GuiOutcome
{
    public partial class AddOutcomeForm : Form
    {
        private readonly int ID;
        private readonly OutcomeUserControl outcomeUserControl;
        private Outcome outcome;
        private int CategoryId;
        private int SupplierId;
        private int ProjectId;
        private readonly IDataHelper<Outcome> dataHelper;
        private readonly IDataHelper<Suppliers> dataHelperSuppliers;
        private readonly IDataHelper<Categories> dataHelperCategories;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm loadingForm;

        public AddOutcomeForm(int Id, int ProjectId, OutcomeUserControl outcomeUserControl)
        {
            InitializeComponent();
            ID = Id;
            this.outcomeUserControl = outcomeUserControl;
            dataHelper = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            dataHelperSuppliers = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
            dataHelperCategories = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
            //dataHelper = (IDataHelper<Outcome>?)ConfigrationObjectManager.GetObject("Outcome");
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
                var SupplierName = comboBoxSupplier.SelectedItem as string;
                var CategoryName = comboBoxCategory.SelectedItem as string;
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetSupplierId(SupplierName));
                return await AddData();

            }
            //Edit
            else
            {
                var SupplierName = comboBoxSupplier.SelectedItem as string;
                var CategoryName = comboBoxCategory.SelectedItem as string;
                await Task.Run(() => SetCategoryId(CategoryName));
                await Task.Run(() => SetSupplierId(SupplierName));
                return await EditData();
            }
        }
        private bool isFieldEmpty()
        {
            if (comboBoxCategory.SelectedItem == null
                || comboBoxSupplier.SelectedItem == null
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
            outcome = new Outcome
            {
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxSupplier.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                OutcomeDate = dateTimePickerDate.Value,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            //Submit
            var result = await dataHelper.AddAsync(outcome);
            if (result == 1)
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية إضافة صرف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم إضافة صرف " + outcome.CategoryName,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                outcomeUserControl.LoadData();//we put it here so it will work after add new item and will not cause issue
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
            outcome = new Outcome
            {
                Id = ID,
                CategoryName = comboBoxCategory.SelectedItem.ToString(),
                SupplierName = comboBoxSupplier.SelectedItem.ToString(),
                RecNo = textBoxRecNo.Text,
                Details = richTextBoxDetails.Text,
                OutcomeDate = dateTimePickerDate.Value,
                Amount = Convert.ToDouble(textBoxAmount.Text),
                CategoryId = CategoryId,
                SupplierId = SupplierId,
                ProjectId = ProjectId
            };
            //Submit
            var result = await dataHelper.EditAsync(outcome);
            if (result == 0)
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
            else
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية تعديل صرف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل صرف " + outcome.CategoryName,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                outcomeUserControl.LoadData();
                //MessageBox.Show("تمت التعديل بنجاح");
                return true;
            }
        }
        private async void GetDataForEdit()
        {
            //Get list of suppliers
            var ListSuppliers = await dataHelperSuppliers.GetAllDataAsync();
            comboBoxSupplier.DataSource = ListSuppliers.Select(x => x.Name).ToList();
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListSuppliers.Select(x => x.Name).ToArray());
            comboBoxSupplier.AutoCompleteCustomSource = autoCompleteString;
            ListSuppliers.Clear();

            //Get list of Categories
            var ListCategories = await dataHelperCategories.GetAllDataAsync();
            comboBoxCategory.DataSource = ListCategories.Select(x => x.Name).ToList();
            AutoCompleteStringCollection autoCompleteStringCategories = new AutoCompleteStringCollection();
            autoCompleteStringCategories.AddRange(ListCategories.Select(x => x.Name).ToArray());
            comboBoxCategory.AutoCompleteCustomSource = autoCompleteStringCategories;
            ListCategories.Clear();
            if (ID > 0)
            {
                outcome = await dataHelper.FindAsync(ID);
                // set Fields
                if (outcome != null)
                {
                    comboBoxCategory.SelectedItem = outcome.CategoryName;
                    comboBoxCategory.SelectedItem = outcome.SupplierName;
                    textBoxRecNo.Text = outcome.RecNo;
                    richTextBoxDetails.Text = outcome.Details;
                    dateTimePickerDate.Value = outcome.OutcomeDate;
                    textBoxAmount.Text = outcome.Amount.ToString();
                    CategoryId = outcome.CategoryId;
                    SupplierId = outcome.SupplierId;
                    ProjectId = outcome.ProjectId;
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
        private void SetSupplierId(string SupplierName)
        {
            //if (comboBoxSupplier.SelectedItem != null)
            //if (comboBoxSupplier.Text != string.Empty)

            SupplierId = dataHelperSuppliers.GetAllData()
                .Where(x => x.Name == SupplierName).Select(x => x.Id).First();

        }

        private async void linkLabelNewCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
            var result = addCategoryForm.ShowDialog();
            if (result == DialogResult.OK)
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

        private async void linkLabelNewSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddSuppliersForm addSuppliersForm = new AddSuppliersForm(0, new SuppliersUserControl());
            var result = addSuppliersForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                //Get list of customers
                var ListSuppliers = await dataHelperSuppliers.GetAllDataAsync();
                comboBoxSupplier.DataSource = ListSuppliers.Select(x => x.Name).ToList();
                AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
                autoCompleteString.AddRange(ListSuppliers.Select(x => x.Name).ToArray());
                comboBoxSupplier.AutoCompleteCustomSource = autoCompleteString;
                ListSuppliers.Clear();
            }
        }
    }
}
