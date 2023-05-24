namespace Sarfiat.Gui.GuiHome
{
    partial class HomeUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            buttonAddInput = new Button();
            buttonAddOutput = new Button();
            buttonAddUser = new Button();
            buttonAddProject = new Button();
            buttonAddSupplier = new Button();
            buttonAddCustomer = new Button();
            buttonAddCategory = new Button();
            label1 = new Label();
            panel2 = new Panel();
            labelCompanyName = new Label();
            pictureLogo = new PictureBox();
            labelWelcome = new Label();
            panel3 = new Panel();
            comboBoxProject = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 239);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.icons8_smart_32px;
            pictureBox1.Location = new Point(444, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.Controls.Add(buttonAddInput);
            groupBox1.Controls.Add(buttonAddOutput);
            groupBox1.Controls.Add(buttonAddUser);
            groupBox1.Controls.Add(buttonAddProject);
            groupBox1.Controls.Add(buttonAddSupplier);
            groupBox1.Controls.Add(buttonAddCustomer);
            groupBox1.Controls.Add(buttonAddCategory);
            groupBox1.Location = new Point(56, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.Yes;
            groupBox1.Size = new Size(1176, 158);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "إضافة";
            // 
            // buttonAddInput
            // 
            buttonAddInput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddInput.Image = Properties.Resources.icons8_categorize_32px;
            buttonAddInput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddInput.Location = new Point(152, 49);
            buttonAddInput.Margin = new Padding(5);
            buttonAddInput.Name = "buttonAddInput";
            buttonAddInput.Size = new Size(117, 78);
            buttonAddInput.TabIndex = 7;
            buttonAddInput.Text = "قبض";
            buttonAddInput.UseVisualStyleBackColor = true;
            buttonAddInput.Click += buttonAddInput_Click;
            // 
            // buttonAddOutput
            // 
            buttonAddOutput.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddOutput.Image = Properties.Resources.icons8_categorize_32px;
            buttonAddOutput.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddOutput.Location = new Point(279, 49);
            buttonAddOutput.Margin = new Padding(5);
            buttonAddOutput.Name = "buttonAddOutput";
            buttonAddOutput.Size = new Size(117, 78);
            buttonAddOutput.TabIndex = 6;
            buttonAddOutput.Text = "صرف";
            buttonAddOutput.UseVisualStyleBackColor = true;
            buttonAddOutput.Click += buttonAddOutput_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddUser.Image = Properties.Resources.icons8_users_32px;
            buttonAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddUser.Location = new Point(406, 49);
            buttonAddUser.Margin = new Padding(5);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(117, 78);
            buttonAddUser.TabIndex = 5;
            buttonAddUser.Text = "مستخدم";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonAddProject
            // 
            buttonAddProject.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddProject.Image = Properties.Resources.icons8_microsoft_project_32px;
            buttonAddProject.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddProject.Location = new Point(533, 49);
            buttonAddProject.Margin = new Padding(5);
            buttonAddProject.Name = "buttonAddProject";
            buttonAddProject.Size = new Size(117, 78);
            buttonAddProject.TabIndex = 4;
            buttonAddProject.Text = "مشروع";
            buttonAddProject.UseVisualStyleBackColor = true;
            buttonAddProject.Click += buttonAddProject_Click;
            // 
            // buttonAddSupplier
            // 
            buttonAddSupplier.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddSupplier.Image = Properties.Resources.icons8_conference_32px;
            buttonAddSupplier.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddSupplier.Location = new Point(660, 49);
            buttonAddSupplier.Margin = new Padding(5);
            buttonAddSupplier.Name = "buttonAddSupplier";
            buttonAddSupplier.Size = new Size(117, 78);
            buttonAddSupplier.TabIndex = 3;
            buttonAddSupplier.Text = "مورد";
            buttonAddSupplier.UseVisualStyleBackColor = true;
            buttonAddSupplier.Click += buttonAddSupplier_Click;
            // 
            // buttonAddCustomer
            // 
            buttonAddCustomer.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCustomer.Image = Properties.Resources.icons8_people_32px;
            buttonAddCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCustomer.Location = new Point(787, 49);
            buttonAddCustomer.Margin = new Padding(5);
            buttonAddCustomer.Name = "buttonAddCustomer";
            buttonAddCustomer.Size = new Size(117, 78);
            buttonAddCustomer.TabIndex = 2;
            buttonAddCustomer.Text = "عميل";
            buttonAddCustomer.UseVisualStyleBackColor = true;
            buttonAddCustomer.Click += buttonAddCustomer_Click;
            // 
            // buttonAddCategory
            // 
            buttonAddCategory.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddCategory.Image = Properties.Resources.icons8_categorize_32px;
            buttonAddCategory.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAddCategory.Location = new Point(914, 49);
            buttonAddCategory.Margin = new Padding(5);
            buttonAddCategory.Name = "buttonAddCategory";
            buttonAddCategory.Size = new Size(117, 78);
            buttonAddCategory.TabIndex = 1;
            buttonAddCategory.Text = "صنف";
            buttonAddCategory.UseVisualStyleBackColor = true;
            buttonAddCategory.Click += buttonAddCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(580, 15);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 0;
            label1.Text = "الوصول السريع";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelCompanyName);
            panel2.Controls.Add(pictureLogo);
            panel2.Location = new Point(914, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(321, 85);
            panel2.TabIndex = 1;
            // 
            // labelCompanyName
            // 
            labelCompanyName.AutoSize = true;
            labelCompanyName.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelCompanyName.Location = new Point(17, 25);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(192, 38);
            labelCompanyName.TabIndex = 4;
            labelCompanyName.Text = "شركة الصرفيات";
            labelCompanyName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureLogo
            // 
            pictureLogo.Image = Properties.Resources.icons8_smart_32px;
            pictureLogo.Location = new Point(227, 3);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(91, 82);
            pictureLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLogo.TabIndex = 4;
            pictureLogo.TabStop = false;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.Location = new Point(123, 99);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(245, 38);
            labelWelcome.TabIndex = 5;
            labelWelcome.Text = "مرحبا بك مجددا أبرار";
            labelWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.Controls.Add(comboBoxProject);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(398, 373);
            panel3.Name = "panel3";
            panel3.Size = new Size(485, 109);
            panel3.TabIndex = 6;
            // 
            // comboBoxProject
            // 
            comboBoxProject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxProject.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBoxProject.FormattingEnabled = true;
            comboBoxProject.Location = new Point(10, 53);
            comboBoxProject.Name = "comboBoxProject";
            comboBoxProject.Size = new Size(464, 36);
            comboBoxProject.TabIndex = 8;
            comboBoxProject.SelectedIndexChanged += comboBoxProject_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(191, 0);
            label2.Name = "label2";
            label2.Size = new Size(118, 38);
            label2.TabIndex = 7;
            label2.Text = "المشاريع";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(panel3);
            Controls.Add(labelWelcome);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "HomeUserControl";
            Size = new Size(1280, 720);
            Load += HomeUserControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private Button buttonAddCategory;
        private Button buttonAddInput;
        private Button buttonAddOutput;
        private Button buttonAddUser;
        private Button buttonAddProject;
        private Button buttonAddSupplier;
        private Button buttonAddCustomer;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label labelCompanyName;
        private PictureBox pictureLogo;
        private Label labelWelcome;
        private Panel panel3;
        private ComboBox comboBoxProject;
        private Label label2;
    }
}
