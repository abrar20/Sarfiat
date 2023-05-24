using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using Sarfiat.Code;
using Sarfiat.Core;
using Sarfiat.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Sarfiat.Gui.GuiProjects
{
    public partial class AddProjectsForm : Form
    {
        private readonly int ID;
        private readonly ProjectsUserControl projectsUserControl;
        private Projects projects;
        private readonly IDataHelper<Projects> dataHelper;
        private readonly IDataHelper<Customers> dataHelperCustomers;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm loadingForm;

        public AddProjectsForm(int Id, ProjectsUserControl projectsUserControl)
        {
            InitializeComponent();
            ID = Id;
            this.projectsUserControl = projectsUserControl;
            dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
            dataHelperCustomers = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
            //dataHelper = (IDataHelper<Projects>?)ConfigrationObjectManager.GetObject("Projects");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
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
                return await AddData();

            }
            //Edit
            else
            {
                return await EditData();
            }
        }
        private bool isFieldEmpty()
        {
            if (textBoxName.Text == string.Empty)
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
            projects = new Projects
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                Company = textBoxCompany.Text,
                Customer = comboBoxCustomer.Text,
                StartDate = dateTimePickerStartDate.Value,
                EndDate = dateTimePickerEndDate.Value,
                Income = Convert.ToDouble(textBoxIncome.Text),
                Outcome = Convert.ToDouble(textBoxOutcome.Text),
                Revenue = Convert.ToDouble(textBoxRevenue.Text),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.AddAsync(projects);
            if (result == 1)
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية إضافة مشروع",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم إضافة مشروع " + projects.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                projectsUserControl.LoadData();//we put it here so it will work after add new item and will not cause issue
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
            projects = new Projects
            {
                Id = ID,
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                Company = textBoxCompany.Text,
                Customer = comboBoxCustomer.Text,
                StartDate = dateTimePickerStartDate.Value,
                EndDate = dateTimePickerEndDate.Value,
                Income = Convert.ToDouble(textBoxIncome.Text),
                Outcome = Convert.ToDouble(textBoxOutcome.Text),
                Revenue = Convert.ToDouble(textBoxRevenue.Text),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.EditAsync(projects);
            if (result == 0)
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
            else
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية تعديل مشروع",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل مشروع " + projects.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                projectsUserControl.LoadData();
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
            if (ID > 0)
            {
                projects = await dataHelper.FindAsync(ID);
                // set Fields
                if (projects != null)
                {
                    textBoxName.Text = projects.Name;
                    textBoxAddress.Text = projects.Address;
                    textBoxCompany.Text = projects.Company;
                    comboBoxCustomer.Text = projects.Customer;
                    //dateTimePickerStartDate.Value = projects.StartDate;
                    //dateTimePickerEndDate.Value = projects.EndDate;
                    textBoxIncome.Text = projects.Income.ToString();
                    textBoxOutcome.Text = projects.Outcome.ToString();
                    textBoxRevenue.Text = projects.Revenue.ToString();
                    richTextBoxDetails.Text = projects.Details;
                }
                else
                {
                    MessageCollection.ShowErrorServer();
                }

            }
        }
        #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
