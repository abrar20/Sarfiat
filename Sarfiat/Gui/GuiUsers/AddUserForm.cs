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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Sarfiat.Gui.GuiUsers
{
    public partial class AddUserForm : Form
    {
        private readonly int ID;
        private readonly UsersControl usersControl;
        private readonly bool firstStart;
        private Users users;
        private readonly IDataHelper<Users> dataHelper;
        private readonly IDataHelper<UsersRoles> dataHelperUsersRoles;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly GuiLoading.LoadingForm loadingForm;
        private Dictionary<string, bool> ListOfRoles = new Dictionary<string, bool>();

        public AddUserForm(int Id, UsersControl usersControl, bool firstStart)
        {
            InitializeComponent();
            ID = Id;
            this.usersControl = usersControl;
            dataHelper = (IDataHelper<Users>)ConfigrationObjectManager.GetObject("Users");
            dataHelperUsersRoles = (IDataHelper<UsersRoles>)ConfigrationObjectManager.GetObject("UsersRoles");
            //dataHelper = (IDataHelper<Users>?)ConfigrationObjectManager.GetObject("Users");
            dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            loadingForm = new GuiLoading.LoadingForm();
            this.firstStart = firstStart;
        }
        #region Events
        private async void buttonSaveAndClose_Click(object sender, EventArgs e)
        {
            //if (await SaveData())
            //{
            //this below line cause issue another thread use same context befor first finish 
            //usersControl.LoadData();
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
                    if (firstStart == true)
                    {
                        MessageBox.Show("أعد تشغيل البرنامج من فضلك");
                        Application.Exit();
                    }
                    else { Close(); }
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
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            loadingForm.Show();
            GetDataForEdit();
            loadingForm.Hide();
            if (firstStart == true)
            {
                buttonSave.Visible = false;
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
            if (textBoxName.Text == string.Empty
                || textBoxUserName.Text == string.Empty
                || textBoxPassword.Text == string.Empty)
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
            users = new Users
            {
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.AddAsync(users);
            if (result == 1)
            {
                //Add Roles
                var data = await dataHelper.GetAllDataAsync();
                // fetch last one added
                var userId = data.Select(x => x.Id).LastOrDefault();
                SetRoles();
                for (int i = 0; i < ListOfRoles.Count; i++)
                {
                    UsersRoles usersRoles = new UsersRoles
                    {
                        UserId = userId,
                        Key = ListOfRoles.Keys.ToList()[i],
                        Value = ListOfRoles.Values.ToList()[i]
                    };
                    await dataHelperUsersRoles.AddAsync(usersRoles);
                }
                //Save system records
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية إضافة مستخدم",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم إضافة مستخدم " + users.UserName,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                usersControl.LoadData();//we put it here so it will work after add new item and will not cause issue
                //MessageBox.Show("تمت الإضافة بنجاح");
                return true;
            }
            else
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
        }
        private void SetRoles()
        {
            ListOfRoles.Clear();
            ListOfRoles.Add(checkBoxHome.Name, checkBoxHome.Checked);
            ListOfRoles.Add(checkBoxCategory.Name, checkBoxCategory.Checked);
            ListOfRoles.Add(checkBoxSupplier.Name, checkBoxSupplier.Checked);
            ListOfRoles.Add(checkBoxCustomer.Name, checkBoxCustomer.Checked);
            ListOfRoles.Add(checkBoxProject.Name, checkBoxProject.Checked);
            ListOfRoles.Add(checkBoxUser.Name, checkBoxUser.Checked);
            ListOfRoles.Add(checkBoxSettings.Name, checkBoxSettings.Checked);
            ListOfRoles.Add(checkBoxRecord.Name, checkBoxRecord.Checked);

            //
            ListOfRoles.Add(checkBoxAccessCategory.Name, checkBoxAccessCategory.Checked);
            ListOfRoles.Add(checkBoxAccessSupplier.Name, checkBoxAccessSupplier.Checked);
            ListOfRoles.Add(checkBoxAccessCustomer.Name, checkBoxAccessCustomer.Checked);
            ListOfRoles.Add(checkBoxAccessProject.Name, checkBoxAccessProject.Checked);
            ListOfRoles.Add(checkBoxAccessUser.Name, checkBoxAccessUser.Checked);
            ListOfRoles.Add(checkBoxAccessOutcome.Name, checkBoxAccessOutcome.Checked);
            ListOfRoles.Add(checkBoxAccessIncome.Name, checkBoxAccessIncome.Checked);

            //
            ListOfRoles.Add(checkBoxAdd.Name, checkBoxAdd.Checked);
            ListOfRoles.Add(checkBoxDelete.Name, checkBoxDelete.Checked);
            ListOfRoles.Add(checkBoxEdit.Name, checkBoxEdit.Checked);
            ListOfRoles.Add(checkBoxExport.Name, checkBoxExport.Checked);
            ListOfRoles.Add(checkBoxSearch.Name, checkBoxSearch.Checked);
            ListOfRoles.Add(checkBoxExplore.Name, checkBoxExplore.Checked);
        }
        private async Task<bool> EditData()
        {
            //Set Data
            users = new Users
            {
                Id = ID,
                FullName = textBoxName.Text,
                UserName = textBoxUserName.Text,
                Password = textBoxPassword.Text,
                Phone = textBoxPhone.Text,
                Email = textBoxEmail.Text,
                AddedDate = DateTime.Now,
            };
            //Submit
            var result = await dataHelper.EditAsync(users);
            if (result == 0)
            {
                //MessageCollection.ShowErrorServer();
                return false;
            }
            else
            {
                //Add Roles
                var rolesData = await dataHelperUsersRoles.GetAllDataAsync();
                var ListOfRolesId = rolesData.Where(x => x.UserId == ID).Select(x => x.Id).ToList();
                for (int j = 0; j < ListOfRolesId.Count; j++)
                {
                    var userid = ListOfRolesId[j];
                    await dataHelperUsersRoles.DeleteAsync(userid);
                }
                SetRoles();
                for (int i = 0; i < ListOfRoles.Count; i++)
                {
                    UsersRoles usersRoles = new UsersRoles
                    {
                        UserId = ID,
                        Key = ListOfRoles.Keys.ToList()[i],
                        Value = ListOfRoles.Values.ToList()[i]
                    };
                    await dataHelperUsersRoles.AddAsync(usersRoles);
                }
                SystemRecords systemRecords = new SystemRecords
                {
                    Title = "عملية تعديل مستخدم",
                    UserName = Properties.Settings.Default.UserName,
                    Details = "تم تعديل مستخدم " + users.UserName,
                    AddedDate = DateTime.Now

                };
                await dataHelperSystemRecords.AddAsync(systemRecords);
                //Toast
                usersControl.LoadData();
                //MessageBox.Show("تمت التعديل بنجاح");
                return true;
            }
        }
        private async void GetDataForEdit()
        {
            // set Fields
            if (ID > 0)
            {
                users = await dataHelper.FindAsync(ID);
                var rolesData = await dataHelperUsersRoles.GetAllDataAsync();
                //List<bool> ListOfRoles = new List<bool>();
                var ListOfRoles = rolesData.Where(x => x.UserId == ID).Select(x => x.Value).ToList();
                if (users != null)
                {
                    textBoxName.Text = users.FullName;
                    textBoxUserName.Text = users.UserName;
                    textBoxPassword.Text = users.Password;
                    textBoxPhone.Text = users.Phone;
                    textBoxEmail.Text = users.Email;
                    //set current roles
                    checkBoxHome.Checked = ListOfRoles[0];
                    checkBoxCategory.Checked = ListOfRoles[1];
                    checkBoxSupplier.Checked = ListOfRoles[2];
                    checkBoxCustomer.Checked = ListOfRoles[3];
                    checkBoxProject.Checked = ListOfRoles[4];
                    checkBoxUser.Checked = ListOfRoles[5];
                    checkBoxSettings.Checked = ListOfRoles[6];
                    checkBoxRecord.Checked = ListOfRoles[7];

                    checkBoxAccessCategory.Checked = ListOfRoles[8];
                    checkBoxAccessSupplier.Checked = ListOfRoles[9];
                    checkBoxAccessCustomer.Checked = ListOfRoles[10];
                    checkBoxAccessProject.Checked = ListOfRoles[11];
                    checkBoxAccessUser.Checked = ListOfRoles[12];
                    checkBoxAccessOutcome.Checked = ListOfRoles[13];
                    checkBoxAccessIncome.Checked = ListOfRoles[14];

                    checkBoxAdd.Checked = ListOfRoles[15];
                    checkBoxDelete.Checked = ListOfRoles[16];
                    checkBoxEdit.Checked = ListOfRoles[17];
                    checkBoxExport.Checked = ListOfRoles[18];
                    checkBoxSearch.Checked = ListOfRoles[19];
                    checkBoxExplore.Checked = ListOfRoles[20];
                }
                else
                {
                    MessageCollection.ShowErrorServer();
                }

            }
        }
        #endregion


        private void AddUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (firstStart == true)
            {
                MessageBox.Show("أعد تشغيل البرنامج من فضلك");
                Application.Exit();
            }
        }
    }
}
