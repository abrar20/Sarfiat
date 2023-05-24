using Sarfiat.Code;
using Sarfiat.Core;
using Sarfiat.Data;
using Sarfiat.Gui.GuiCategories;
using Sarfiat.Gui.GuiCustomers;
using Sarfiat.Gui.GuiIncome;
using Sarfiat.Gui.GuiOutcome;
using Sarfiat.Gui.GuiProjects;
using Sarfiat.Gui.GuiSuppliers;
using Sarfiat.Gui.GuiUsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarfiat.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;
        private int ProjectId;
        private readonly IDataHelper<Projects> dataHelper;

        public HomeUserControl()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<Projects>)ConfigrationObjectManager.GetObject("Projects");
            SetRoles();
            SetGeneralSettings();
            SetHello();
        }
        // Singelton solve many instance that created each time we click on buttons,
        // so we will intiated one time and returend it every time clcick on button
        public static HomeUserControl Instance()
        {
            // return and if it is not created yet create it
            return _HomeUserControl ?? (new HomeUserControl());
        }
        private void SetRoles()
        {
            /*if (!UsersRolesManager.GetRole("checkBoxAccessCategory"))
            {
                buttonAddCategory.Visible = false;
            }*/
            if (!UsersRolesManager.GetRole("checkBoxAccessCategory"))
            {
                buttonAddCategory.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessSupplier"))
            {
                buttonAddSupplier.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessCustomer"))
            {
                buttonAddCustomer.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessProject"))
            {
                buttonAddProject.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessUser"))
            {
                buttonAddUser.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessOutcome"))
            {
                buttonAddOutput.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxAccessIncome"))
            {
                buttonAddInput.Visible = false;
            }
        }
        private void SetGeneralSettings()
        {
            labelCompanyName.Text = Properties.Settings.Default.CompanyName;
            //get picture

            if (Properties.Settings.Default.CompanyLogo != string.Empty)
            {
                var ImageAsByte = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                using (MemoryStream ma = new MemoryStream(ImageAsByte))
                {
                    pictureLogo.Image = Image.FromStream(ma);
                }

            }
        }
        private void SetHello()
        {
            labelWelcome.Text = "مرحبا بك" + Properties.Settings.Default.UserName;
        }

        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm = new AddCategoryForm(0, new CategoryUserControl());
            addCategoryForm.Show();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm(0, new CustomersUserControl());
            addCustomersForm.Show();
        }

        private void buttonAddSupplier_Click(object sender, EventArgs e)
        {
            AddSuppliersForm addSuppliersForm = new AddSuppliersForm(0, new SuppliersUserControl());
            addSuppliersForm.Show();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(0, new UsersControl(), false);
            addUserForm.Show();
        }

        private void buttonAddProject_Click(object sender, EventArgs e)
        {
            AddProjectsForm addProjectsForm = new AddProjectsForm(0, new ProjectsUserControl());
            addProjectsForm.Show();
        }

        private async void HomeUserControl_Load(object sender, EventArgs e)
        {
            // Get List of Suppliers
            var ListOfProjects = await dataHelper.GetAllDataAsync();
            comboBoxProject.DataSource = ListOfProjects.Select(x => x.Name).ToList(); // Fill 
                                                                                      // Auto Complete
            AutoCompleteStringCollection autoCompleteString = new AutoCompleteStringCollection();
            autoCompleteString.AddRange(ListOfProjects.Select(x => x.Name).ToArray());
            comboBoxProject.AutoCompleteCustomSource = autoCompleteString;

            ListOfProjects.Clear(); // clear 
        }

        private void comboBoxProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            var projectName = comboBoxProject.SelectedItem.ToString();
            ProjectId = dataHelper.GetAllData().Where(X => X.Name == projectName).Select(x => x.Id).FirstOrDefault();
        }

        private void buttonAddOutput_Click(object sender, EventArgs e)
        {
            if (ProjectId > 0)
            {
                AddOutcomeForm addOutcomeForm = new AddOutcomeForm(0, ProjectId, new OutcomeUserControl(ProjectId));
                addOutcomeForm.Show();
            }
            else
            {
                MessageBox.Show("اختر المشروع لطفا");
            }
        }

        private void buttonAddInput_Click(object sender, EventArgs e)
        {
            if (ProjectId > 0)
            {
                AddIncomeForm addIncomeForm = new AddIncomeForm(0, ProjectId, new IncomeUserControl(ProjectId));
                addIncomeForm.Show();
            }
            else
            {
                MessageBox.Show("اختر المشروع لطفا");
            }
        }
    }
}
