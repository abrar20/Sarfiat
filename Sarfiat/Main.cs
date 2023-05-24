using Sarfiat.Code;
using Sarfiat.Gui;
using System.Diagnostics;

namespace Sarfiat
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;
        public Main()
        {
            InitializeComponent();
            pageManager = new PageManager(this);
            //UsersRolesManager.Register("checkBoxHome", false);
            //load home page
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
            SetRoles();
        }

        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiCategories.CategoryUserControl.Instance());
        }
        private void buttonCustomers_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiCustomers.CustomersUserControl.Instance());
        }
        private void buttonSuppliers_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiSuppliers.SuppliersUserControl.Instance());
        }
        #endregion

        private void buttonProjects_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiProjects.ProjectsUserControl.Instance());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiUsers.UsersControl.Instance());
        }
        private void SetRoles()
        {
            if (!UsersRolesManager.GetRole("checkBoxHome"))
            {
                buttonHome.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxCategory"))
            {
                buttonCategories.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSupplier"))
            {
                buttonSuppliers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxCustomer"))
            {
                buttonCustomers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxProject"))
            {
                buttonProjects.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxUser"))
            {
                buttonUsers.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxSettings"))
            {
                buttonSettings.Visible = false;
            }
            if (!UsersRolesManager.GetRole("checkBoxRecord"))
            {
                buttonSystemRecords.Visible = false;
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Gui.GuiSettings.SettingsForm settingsForm = new Gui.GuiSettings.SettingsForm(false);
            settingsForm.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Gui.GuiUsers.UserLoginForm userLoginform = new Gui.GuiUsers.UserLoginForm();
            userLoginform.Show();
            Hide();
        }

        private void buttonSystemRecords_Click(object sender, EventArgs e)
        {
            pageManager.LoadPage(Gui.GuiSystemRecords.RecordUserControl.Instance());
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            Gui.GuiAbout.About aboutForm = new Gui.GuiAbout.About();
            aboutForm.Show();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            var url = "https://www.google.com";
            Process.Start(new ProcessStartInfo { FileName=url, UseShellExecute=true });
        }
    }
}