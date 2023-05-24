using DocumentFormat.OpenXml.Drawing.Spreadsheet;
using Sarfiat.Code;
using Sarfiat.Core;
using Sarfiat.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarfiat.Gui.GuiCustomers
{
    public partial class AddCustomersForm : Form
    {
        private readonly int ID;
        private readonly CustomersUserControl customersUserControl;
        private Customers customers;
        private readonly IDataHelper<Customers> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm loadingForm;

        public AddCustomersForm(int Id, CustomersUserControl customersUserControl)
        {
            InitializeComponent();
            ID = Id;
            this.customersUserControl = customersUserControl;
            dataHelper = (IDataHelper<Customers>)ConfigrationObjectManager.GetObject("Customers");
            //dataHelper = (IDataHelper<Customers>?)ConfigrationObjectManager.GetObject("Customers");
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
                        this.DialogResult = DialogResult.OK;
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
                        this.DialogResult = DialogResult.OK;
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
            customers = new Customers
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhoneNo.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.AddAsync(customers);
            if (result == 1)
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية إضافة مورد",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم إضافة مورد " + customers.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                customersUserControl.LoadData();//we put it here so it will work after add new item and will not cause issue
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
            customers = new Customers
            {
                Id = ID,
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhoneNo.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.EditAsync(customers);
            if (result == 0)
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
            else
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية تعديل مورد",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل مورد " + customers.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                customersUserControl.LoadData();
                //MessageBox.Show("تمت التعديل بنجاح");
                return true;
            }
        }
        private async void GetDataForEdit()
        {
            // set Fields
            if (ID > 0)
            {
                customers = await dataHelper.FindAsync(ID);
                if (customers != null)
                {
                    textBoxName.Text = customers.Name;
                    textBoxPhoneNo.Text = customers.PhoneNumber;
                    textBoxEmail.Text = customers.Email;
                    textBoxAddress.Text = customers.Address;
                    textBoxBalance.Text = customers.Balance.ToString();
                    richTextBoxDetails.Text = customers.Details;
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
