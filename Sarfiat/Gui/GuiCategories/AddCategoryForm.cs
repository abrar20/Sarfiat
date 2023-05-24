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

namespace Sarfiat.Gui.GuiCategories
{
    public partial class AddCategoryForm : Form
    {
        private readonly int ID;
        private readonly CategoryUserControl categoryUserControl;
        private Categories categories;
        private readonly IDataHelper<Categories> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm loadingForm;

        public AddCategoryForm(int Id, CategoryUserControl categoryUserControl)
        {
            InitializeComponent();
            ID = Id;
            this.categoryUserControl = categoryUserControl;
            dataHelper = (IDataHelper<Categories>)ConfigrationObjectManager.GetObject("Categories");
            //dataHelper = (IDataHelper<Categories>?)ConfigrationObjectManager.GetObject("Categories");
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
                        MessageCollection.ShowAddNotification();
                        this.DialogResult = DialogResult.OK;
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
            if (textBoxName.Text == string.Empty || comboBoxType.Text == string.Empty)
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
            categories = new Categories
            {
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.AddAsync(categories);
            if (result == 1)
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية إضافة صنف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم إضافة صنف " + categories.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                categoryUserControl.LoadData();//we put it here so it will work after add new item and will not cause issue
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
            categories = new Categories
            {
                Id = ID,
                Name = textBoxName.Text,
                Type = comboBoxType.SelectedItem.ToString(),
                Details = richTextBoxDetails.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.EditAsync(categories);
            if (result == 0)
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
            else
            {
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية تعديل صنف",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل صنف " + categories.Name,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                categoryUserControl.LoadData();
                //MessageBox.Show("تمت التعديل بنجاح");
                return true;
            }
        }
        private async void GetDataForEdit()
        {
            // set Fields
            if (ID > 0)
            {
                categories = await dataHelper.FindAsync(ID);
                if (categories != null)
                {
                    textBoxName.Text = categories.Name;
                    textBoxBalance.Text = categories.Balance.ToString();
                    comboBoxType.SelectedItem = categories.Type;
                    richTextBoxDetails.Text = categories.Details;
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
