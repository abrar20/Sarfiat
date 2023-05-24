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

namespace Sarfiat.Gui.GuiSuppliers
{
    public partial class AddSuppliersForm : Form
    {
        private readonly int ID;
        private readonly SuppliersUserControl suppliersUserControl;
        private Suppliers suppliers;
        private readonly IDataHelper<Suppliers> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm loadingForm;

        public AddSuppliersForm(int Id, SuppliersUserControl suppliersUserControl)
        {
            InitializeComponent();
            ID = Id;
            this.suppliersUserControl = suppliersUserControl;
            dataHelper = (IDataHelper<Suppliers>)ConfigrationObjectManager.GetObject("Suppliers");
            //dataHelper = (IDataHelper<Suppliers>?)ConfigrationObjectManager.GetObject("Suppliers");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
        }
        #region Events


        private void AddCategoryForm_Load(object sender, EventArgs e)
        {
            loadingForm.Show();
            GetDataForEdit();
            loadingForm.Hide();

        }
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
            suppliers = new Suppliers
            {
                Name = textBoxName.Text,
                Address = textBoxAddress.Text,
                Email = textBoxEmail.Text,
                PhoneNumber = textBoxPhoneNo.Text,
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.AddAsync(suppliers);
            if (result == 1)
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية إضافة مورد",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم إضافة مورد " + suppliers.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                suppliersUserControl.LoadData();//we put it here so it will work after add new item and will not cause issue
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
            suppliers = new Suppliers
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
            var result = await dataHelper.EditAsync(suppliers);
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
                    Details = "تم تعديل مورد " + suppliers.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                suppliersUserControl.LoadData();
                //MessageBox.Show("تمت التعديل بنجاح");
                return true;
            }
        }
        private async void GetDataForEdit()
        {
            // set Fields
            if (ID > 0)
            {
                suppliers = await dataHelper.FindAsync(ID);
                if (suppliers != null)
                {
                    textBoxName.Text = suppliers.Name;
                    textBoxPhoneNo.Text = suppliers.PhoneNumber;
                    textBoxEmail.Text = suppliers.Email;
                    textBoxAddress.Text = suppliers.Address;
                    textBoxBalance.Text = suppliers.Balance.ToString();
                    richTextBoxDetails.Text = suppliers.Details;
                }
                else
                {
                    MessageCollection.ShowErrorServer();
                }

            }
        }
        #endregion




    }
}
