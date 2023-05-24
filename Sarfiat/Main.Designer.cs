namespace Sarfiat
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonHome = new Button();
            buttonCategories = new Button();
            buttonCustomers = new Button();
            buttonSuppliers = new Button();
            buttonProjects = new Button();
            buttonUsers = new Button();
            buttonSettings = new Button();
            buttonLogOut = new Button();
            buttonSystemRecords = new Button();
            buttonHelp = new Button();
            buttonAbout = new Button();
            panelContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(buttonHome);
            flowLayoutPanel1.Controls.Add(buttonCategories);
            flowLayoutPanel1.Controls.Add(buttonCustomers);
            flowLayoutPanel1.Controls.Add(buttonSuppliers);
            flowLayoutPanel1.Controls.Add(buttonProjects);
            flowLayoutPanel1.Controls.Add(buttonUsers);
            flowLayoutPanel1.Controls.Add(buttonSettings);
            flowLayoutPanel1.Controls.Add(buttonLogOut);
            flowLayoutPanel1.Controls.Add(buttonSystemRecords);
            flowLayoutPanel1.Controls.Add(buttonHelp);
            flowLayoutPanel1.Controls.Add(buttonAbout);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel1.Location = new Point(0, 590);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1262, 83);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonHome
            // 
            buttonHome.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHome.Image = Properties.Resources.icons8_home_32px;
            buttonHome.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHome.Location = new Point(1061, 10);
            buttonHome.Margin = new Padding(5);
            buttonHome.Name = "buttonHome";
            buttonHome.Size = new Size(165, 55);
            buttonHome.TabIndex = 0;
            buttonHome.Text = "الرئيسية";
            buttonHome.UseVisualStyleBackColor = true;
            buttonHome.Click += buttonHome_Click;
            // 
            // buttonCategories
            // 
            buttonCategories.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCategories.Image = Properties.Resources.icons8_categorize_32px;
            buttonCategories.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCategories.Location = new Point(886, 10);
            buttonCategories.Margin = new Padding(5);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Size = new Size(165, 55);
            buttonCategories.TabIndex = 1;
            buttonCategories.Text = "الأصناف";
            buttonCategories.UseVisualStyleBackColor = true;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCustomers.Image = Properties.Resources.icons8_people_32px;
            buttonCustomers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCustomers.Location = new Point(711, 10);
            buttonCustomers.Margin = new Padding(5);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(165, 55);
            buttonCustomers.TabIndex = 2;
            buttonCustomers.Text = "العملاء";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click;
            // 
            // buttonSuppliers
            // 
            buttonSuppliers.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSuppliers.Image = Properties.Resources.icons8_conference_32px;
            buttonSuppliers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSuppliers.Location = new Point(536, 10);
            buttonSuppliers.Margin = new Padding(5);
            buttonSuppliers.Name = "buttonSuppliers";
            buttonSuppliers.Size = new Size(165, 55);
            buttonSuppliers.TabIndex = 3;
            buttonSuppliers.Text = "الموردين";
            buttonSuppliers.UseVisualStyleBackColor = true;
            buttonSuppliers.Click += buttonSuppliers_Click;
            // 
            // buttonProjects
            // 
            buttonProjects.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonProjects.Image = Properties.Resources.icons8_microsoft_project_32px;
            buttonProjects.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProjects.Location = new Point(361, 10);
            buttonProjects.Margin = new Padding(5);
            buttonProjects.Name = "buttonProjects";
            buttonProjects.Size = new Size(165, 55);
            buttonProjects.TabIndex = 4;
            buttonProjects.Text = "المشاريع";
            buttonProjects.UseVisualStyleBackColor = true;
            buttonProjects.Click += buttonProjects_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonUsers.Image = Properties.Resources.icons8_users_32px;
            buttonUsers.ImageAlign = ContentAlignment.MiddleLeft;
            buttonUsers.Location = new Point(186, 10);
            buttonUsers.Margin = new Padding(5);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Size = new Size(165, 55);
            buttonUsers.TabIndex = 5;
            buttonUsers.Text = "المستخدمين";
            buttonUsers.UseVisualStyleBackColor = true;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonSettings
            // 
            buttonSettings.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSettings.Image = Properties.Resources.icons8_settings_32px;
            buttonSettings.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSettings.Location = new Point(11, 10);
            buttonSettings.Margin = new Padding(5);
            buttonSettings.Name = "buttonSettings";
            buttonSettings.Size = new Size(165, 55);
            buttonSettings.TabIndex = 6;
            buttonSettings.Text = "الإعدادات";
            buttonSettings.UseVisualStyleBackColor = true;
            buttonSettings.Click += buttonSettings_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogOut.Image = Properties.Resources.icons8_logout_32px;
            buttonLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogOut.Location = new Point(1061, 75);
            buttonLogOut.Margin = new Padding(5);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(165, 55);
            buttonLogOut.TabIndex = 7;
            buttonLogOut.Text = "خروج";
            buttonLogOut.UseVisualStyleBackColor = true;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // buttonSystemRecords
            // 
            buttonSystemRecords.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSystemRecords.Image = Properties.Resources.icons8_help_32px;
            buttonSystemRecords.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSystemRecords.Location = new Point(886, 75);
            buttonSystemRecords.Margin = new Padding(5);
            buttonSystemRecords.Name = "buttonSystemRecords";
            buttonSystemRecords.Size = new Size(165, 55);
            buttonSystemRecords.TabIndex = 10;
            buttonSystemRecords.Text = "سجل النظام";
            buttonSystemRecords.UseVisualStyleBackColor = true;
            buttonSystemRecords.Click += buttonSystemRecords_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonHelp.Image = Properties.Resources.icons8_help_32px;
            buttonHelp.ImageAlign = ContentAlignment.MiddleLeft;
            buttonHelp.Location = new Point(711, 75);
            buttonHelp.Margin = new Padding(5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(165, 55);
            buttonHelp.TabIndex = 8;
            buttonHelp.Text = "المساعدة";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAbout.Image = Properties.Resources.icons8_about_32px;
            buttonAbout.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAbout.Location = new Point(536, 75);
            buttonAbout.Margin = new Padding(5);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(165, 55);
            buttonAbout.TabIndex = 9;
            buttonAbout.Text = "حول";
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.Window;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1262, 590);
            panelContainer.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Main";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sarfiat";
            WindowState = FormWindowState.Maximized;
            FormClosed += Main_FormClosed;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonHome;
        private Button buttonCategories;
        private Button buttonCustomers;
        private Button buttonSuppliers;
        private Button buttonProjects;
        private Button buttonUsers;
        private Button buttonSettings;
        private Button buttonLogOut;
        private Button buttonHelp;
        private Button buttonAbout;
        public Panel panelContainer;
        private Button buttonSystemRecords;
    }
}