namespace Sarfiat.Gui.GuiUsers
{
    partial class AddUserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonSave = new Button();
            buttonSaveAndClose = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            textBoxPhone = new TextBox();
            label10 = new Label();
            textBoxEmail = new TextBox();
            label8 = new Label();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label6 = new Label();
            label2 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            checkBoxHome = new CheckBox();
            checkBoxCategory = new CheckBox();
            checkBoxSupplier = new CheckBox();
            checkBoxCustomer = new CheckBox();
            checkBoxProject = new CheckBox();
            checkBoxUser = new CheckBox();
            checkBoxSettings = new CheckBox();
            checkBoxRecord = new CheckBox();
            groupBox3 = new GroupBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            checkBoxAccessCategory = new CheckBox();
            checkBoxAccessSupplier = new CheckBox();
            checkBoxAccessCustomer = new CheckBox();
            checkBoxAccessProject = new CheckBox();
            checkBoxAccessUser = new CheckBox();
            checkBoxAccessOutcome = new CheckBox();
            checkBoxAccessIncome = new CheckBox();
            groupBox4 = new GroupBox();
            flowLayoutPanel3 = new FlowLayoutPanel();
            checkBoxAdd = new CheckBox();
            checkBoxDelete = new CheckBox();
            checkBoxEdit = new CheckBox();
            checkBoxExport = new CheckBox();
            checkBoxSearch = new CheckBox();
            checkBoxExplore = new CheckBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            groupBox3.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonSaveAndClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 579);
            panel1.Name = "panel1";
            panel1.Size = new Size(1173, 76);
            panel1.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Image = Properties.Resources.icons8_save_32px_9;
            buttonSave.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSave.Location = new Point(14, 7);
            buttonSave.Margin = new Padding(5);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(249, 55);
            buttonSave.TabIndex = 5;
            buttonSave.Text = "حفظ";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonSaveAndClose
            // 
            buttonSaveAndClose.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveAndClose.Image = Properties.Resources.icons8_save_32px_7;
            buttonSaveAndClose.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSaveAndClose.Location = new Point(910, 7);
            buttonSaveAndClose.Margin = new Padding(5);
            buttonSaveAndClose.Name = "buttonSaveAndClose";
            buttonSaveAndClose.Size = new Size(249, 55);
            buttonSaveAndClose.TabIndex = 4;
            buttonSaveAndClose.Text = "حفظ وغلق";
            buttonSaveAndClose.UseVisualStyleBackColor = true;
            buttonSaveAndClose.Click += buttonSaveAndClose_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(556, 531);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "معلومات المستخدم";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(84, 79);
            label7.Name = "label7";
            label7.Size = new Size(279, 56);
            label7.TabIndex = 17;
            label7.Text = "إضافة مستخدم جديد";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_ava;
            pictureBox1.Location = new Point(387, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(15, 475);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(348, 45);
            textBoxPhone.TabIndex = 15;
            textBoxPhone.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(432, 478);
            label10.Name = "label10";
            label10.Size = new Size(107, 37);
            label10.TabIndex = 14;
            label10.Text = "رقم الهاتف";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(15, 408);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(348, 45);
            textBoxEmail.TabIndex = 12;
            textBoxEmail.TextAlign = HorizontalAlignment.Right;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(399, 411);
            label8.Name = "label8";
            label8.Size = new Size(145, 37);
            label8.TabIndex = 11;
            label8.Text = "البريد الإلكتروني";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.ForeColor = Color.Red;
            label4.Location = new Point(414, 343);
            label4.Name = "label4";
            label4.Size = new Size(25, 37);
            label4.TabIndex = 10;
            label4.Text = "*";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(15, 340);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(348, 45);
            textBoxPassword.TabIndex = 9;
            textBoxPassword.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(432, 343);
            label6.Name = "label6";
            label6.Size = new Size(100, 37);
            label6.TabIndex = 8;
            label6.Text = "كلمة السر";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(387, 265);
            label2.Name = "label2";
            label2.Size = new Size(25, 37);
            label2.TabIndex = 7;
            label2.Text = "*";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(15, 265);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(348, 45);
            textBoxUserName.TabIndex = 6;
            textBoxUserName.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 268);
            label3.Name = "label3";
            label3.Size = new Size(140, 37);
            label3.TabIndex = 5;
            label3.Text = "اسم المستخدم";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(401, 195);
            label5.Name = "label5";
            label5.Size = new Size(25, 37);
            label5.TabIndex = 4;
            label5.Text = "*";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(15, 192);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(348, 45);
            textBoxName.TabIndex = 1;
            textBoxName.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(418, 195);
            label1.Name = "label1";
            label1.Size = new Size(126, 37);
            label1.TabIndex = 0;
            label1.Text = "الاسم الكامل";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(603, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(556, 163);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "الصلاحيات / التبويبات";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(checkBoxHome);
            flowLayoutPanel1.Controls.Add(checkBoxCategory);
            flowLayoutPanel1.Controls.Add(checkBoxSupplier);
            flowLayoutPanel1.Controls.Add(checkBoxCustomer);
            flowLayoutPanel1.Controls.Add(checkBoxProject);
            flowLayoutPanel1.Controls.Add(checkBoxUser);
            flowLayoutPanel1.Controls.Add(checkBoxSettings);
            flowLayoutPanel1.Controls.Add(checkBoxRecord);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 41);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(550, 119);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // checkBoxHome
            // 
            checkBoxHome.AutoSize = true;
            checkBoxHome.Location = new Point(445, 3);
            checkBoxHome.Name = "checkBoxHome";
            checkBoxHome.Size = new Size(102, 41);
            checkBoxHome.TabIndex = 0;
            checkBoxHome.Text = "الرئيسية";
            checkBoxHome.UseVisualStyleBackColor = true;
            // 
            // checkBoxCategory
            // 
            checkBoxCategory.AutoSize = true;
            checkBoxCategory.Location = new Point(333, 3);
            checkBoxCategory.Name = "checkBoxCategory";
            checkBoxCategory.Size = new Size(106, 41);
            checkBoxCategory.TabIndex = 1;
            checkBoxCategory.Text = "الأصناف";
            checkBoxCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxSupplier
            // 
            checkBoxSupplier.AutoSize = true;
            checkBoxSupplier.Location = new Point(217, 3);
            checkBoxSupplier.Name = "checkBoxSupplier";
            checkBoxSupplier.Size = new Size(110, 41);
            checkBoxSupplier.TabIndex = 2;
            checkBoxSupplier.Text = "الموردين";
            checkBoxSupplier.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomer
            // 
            checkBoxCustomer.AutoSize = true;
            checkBoxCustomer.Location = new Point(110, 3);
            checkBoxCustomer.Name = "checkBoxCustomer";
            checkBoxCustomer.Size = new Size(101, 41);
            checkBoxCustomer.TabIndex = 3;
            checkBoxCustomer.Text = "العملاء";
            checkBoxCustomer.UseVisualStyleBackColor = true;
            // 
            // checkBoxProject
            // 
            checkBoxProject.AutoSize = true;
            checkBoxProject.Location = new Point(435, 50);
            checkBoxProject.Name = "checkBoxProject";
            checkBoxProject.Size = new Size(112, 41);
            checkBoxProject.TabIndex = 4;
            checkBoxProject.Text = "المشاريع";
            checkBoxProject.UseVisualStyleBackColor = true;
            // 
            // checkBoxUser
            // 
            checkBoxUser.AutoSize = true;
            checkBoxUser.Location = new Point(286, 50);
            checkBoxUser.Name = "checkBoxUser";
            checkBoxUser.Size = new Size(143, 41);
            checkBoxUser.TabIndex = 5;
            checkBoxUser.Text = "المستخدمين";
            checkBoxUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxSettings
            // 
            checkBoxSettings.AutoSize = true;
            checkBoxSettings.Location = new Point(164, 50);
            checkBoxSettings.Name = "checkBoxSettings";
            checkBoxSettings.Size = new Size(116, 41);
            checkBoxSettings.TabIndex = 6;
            checkBoxSettings.Text = "الإعدادات";
            checkBoxSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxRecord
            // 
            checkBoxRecord.AutoSize = true;
            checkBoxRecord.Location = new Point(21, 50);
            checkBoxRecord.Name = "checkBoxRecord";
            checkBoxRecord.Size = new Size(137, 41);
            checkBoxRecord.TabIndex = 7;
            checkBoxRecord.Text = "سجل النظام";
            checkBoxRecord.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(flowLayoutPanel2);
            groupBox3.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(600, 221);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(556, 163);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "الصلاحيات / الوصول السريع";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(checkBoxAccessCategory);
            flowLayoutPanel2.Controls.Add(checkBoxAccessSupplier);
            flowLayoutPanel2.Controls.Add(checkBoxAccessCustomer);
            flowLayoutPanel2.Controls.Add(checkBoxAccessProject);
            flowLayoutPanel2.Controls.Add(checkBoxAccessUser);
            flowLayoutPanel2.Controls.Add(checkBoxAccessOutcome);
            flowLayoutPanel2.Controls.Add(checkBoxAccessIncome);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(3, 41);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(550, 119);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // checkBoxAccessCategory
            // 
            checkBoxAccessCategory.AutoSize = true;
            checkBoxAccessCategory.Location = new Point(465, 3);
            checkBoxAccessCategory.Name = "checkBoxAccessCategory";
            checkBoxAccessCategory.Size = new Size(82, 41);
            checkBoxAccessCategory.TabIndex = 0;
            checkBoxAccessCategory.Text = "صنف";
            checkBoxAccessCategory.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessSupplier
            // 
            checkBoxAccessSupplier.AutoSize = true;
            checkBoxAccessSupplier.Location = new Point(380, 3);
            checkBoxAccessSupplier.Name = "checkBoxAccessSupplier";
            checkBoxAccessSupplier.Size = new Size(79, 41);
            checkBoxAccessSupplier.TabIndex = 1;
            checkBoxAccessSupplier.Text = "مورد";
            checkBoxAccessSupplier.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessCustomer
            // 
            checkBoxAccessCustomer.AutoSize = true;
            checkBoxAccessCustomer.Location = new Point(289, 3);
            checkBoxAccessCustomer.Name = "checkBoxAccessCustomer";
            checkBoxAccessCustomer.Size = new Size(85, 41);
            checkBoxAccessCustomer.TabIndex = 2;
            checkBoxAccessCustomer.Text = "عميل";
            checkBoxAccessCustomer.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessProject
            // 
            checkBoxAccessProject.AutoSize = true;
            checkBoxAccessProject.Location = new Point(186, 3);
            checkBoxAccessProject.Name = "checkBoxAccessProject";
            checkBoxAccessProject.Size = new Size(97, 41);
            checkBoxAccessProject.TabIndex = 3;
            checkBoxAccessProject.Text = "مشروع";
            checkBoxAccessProject.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessUser
            // 
            checkBoxAccessUser.AutoSize = true;
            checkBoxAccessUser.Location = new Point(69, 3);
            checkBoxAccessUser.Name = "checkBoxAccessUser";
            checkBoxAccessUser.Size = new Size(111, 41);
            checkBoxAccessUser.TabIndex = 4;
            checkBoxAccessUser.Text = "مستخدم";
            checkBoxAccessUser.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessOutcome
            // 
            checkBoxAccessOutcome.AutoSize = true;
            checkBoxAccessOutcome.Location = new Point(465, 50);
            checkBoxAccessOutcome.Name = "checkBoxAccessOutcome";
            checkBoxAccessOutcome.Size = new Size(82, 41);
            checkBoxAccessOutcome.TabIndex = 5;
            checkBoxAccessOutcome.Text = "صرف";
            checkBoxAccessOutcome.UseVisualStyleBackColor = true;
            // 
            // checkBoxAccessIncome
            // 
            checkBoxAccessIncome.AutoSize = true;
            checkBoxAccessIncome.Location = new Point(378, 50);
            checkBoxAccessIncome.Name = "checkBoxAccessIncome";
            checkBoxAccessIncome.Size = new Size(81, 41);
            checkBoxAccessIncome.TabIndex = 6;
            checkBoxAccessIncome.Text = "قبض";
            checkBoxAccessIncome.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(flowLayoutPanel3);
            groupBox4.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.Location = new Point(600, 403);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(556, 163);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "الصلاحيات / العمليات القياسية";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(checkBoxAdd);
            flowLayoutPanel3.Controls.Add(checkBoxDelete);
            flowLayoutPanel3.Controls.Add(checkBoxEdit);
            flowLayoutPanel3.Controls.Add(checkBoxExport);
            flowLayoutPanel3.Controls.Add(checkBoxSearch);
            flowLayoutPanel3.Controls.Add(checkBoxExplore);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(3, 41);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(550, 119);
            flowLayoutPanel3.TabIndex = 0;
            // 
            // checkBoxAdd
            // 
            checkBoxAdd.AutoSize = true;
            checkBoxAdd.Location = new Point(457, 3);
            checkBoxAdd.Name = "checkBoxAdd";
            checkBoxAdd.Size = new Size(90, 41);
            checkBoxAdd.TabIndex = 0;
            checkBoxAdd.Text = "إضافة";
            checkBoxAdd.UseVisualStyleBackColor = true;
            // 
            // checkBoxDelete
            // 
            checkBoxDelete.AutoSize = true;
            checkBoxDelete.Location = new Point(369, 3);
            checkBoxDelete.Name = "checkBoxDelete";
            checkBoxDelete.Size = new Size(82, 41);
            checkBoxDelete.TabIndex = 1;
            checkBoxDelete.Text = "حذف";
            checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxEdit
            // 
            checkBoxEdit.AutoSize = true;
            checkBoxEdit.Location = new Point(276, 3);
            checkBoxEdit.Name = "checkBoxEdit";
            checkBoxEdit.Size = new Size(87, 41);
            checkBoxEdit.TabIndex = 2;
            checkBoxEdit.Text = "تعديل";
            checkBoxEdit.UseVisualStyleBackColor = true;
            // 
            // checkBoxExport
            // 
            checkBoxExport.AutoSize = true;
            checkBoxExport.Location = new Point(187, 3);
            checkBoxExport.Name = "checkBoxExport";
            checkBoxExport.Size = new Size(83, 41);
            checkBoxExport.TabIndex = 3;
            checkBoxExport.Text = "تصدير";
            checkBoxExport.UseVisualStyleBackColor = true;
            // 
            // checkBoxSearch
            // 
            checkBoxSearch.AutoSize = true;
            checkBoxSearch.Location = new Point(109, 3);
            checkBoxSearch.Name = "checkBoxSearch";
            checkBoxSearch.Size = new Size(72, 41);
            checkBoxSearch.TabIndex = 4;
            checkBoxSearch.Text = "بحث";
            checkBoxSearch.UseVisualStyleBackColor = true;
            // 
            // checkBoxExplore
            // 
            checkBoxExplore.AutoSize = true;
            checkBoxExplore.Location = new Point(16, 3);
            checkBoxExplore.Name = "checkBoxExplore";
            checkBoxExplore.Size = new Size(87, 41);
            checkBoxExplore.TabIndex = 5;
            checkBoxExplore.Text = "تصفح";
            checkBoxExplore.UseVisualStyleBackColor = true;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 655);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddUserForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة / تعديل مستخدم";
            TopMost = true;
            FormClosed += AddUserForm_FormClosed;
            Load += AddUserForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            groupBox4.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private TextBox textBoxName;
        private Label label1;
        private Button buttonSave;
        private Button buttonSaveAndClose;
        private Label label5;
        private TextBox textBoxPhone;
        private Label label10;
        private TextBox textBoxEmail;
        private Label label8;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label6;
        private Label label2;
        private TextBox textBoxUserName;
        private Label label3;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox checkBoxHome;
        private CheckBox checkBoxCategory;
        private CheckBox checkBoxSupplier;
        private CheckBox checkBoxCustomer;
        private CheckBox checkBoxProject;
        private CheckBox checkBoxUser;
        private CheckBox checkBoxSettings;
        private CheckBox checkBoxRecord;
        private GroupBox groupBox3;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox checkBoxAccessCategory;
        private CheckBox checkBoxAccessSupplier;
        private CheckBox checkBoxAccessCustomer;
        private CheckBox checkBoxAccessProject;
        private CheckBox checkBoxAccessUser;
        private CheckBox checkBoxAccessOutcome;
        private CheckBox checkBoxAccessIncome;
        private GroupBox groupBox4;
        private FlowLayoutPanel flowLayoutPanel3;
        private CheckBox checkBoxAdd;
        private CheckBox checkBoxDelete;
        private CheckBox checkBoxEdit;
        private CheckBox checkBoxExport;
        private CheckBox checkBoxSearch;
        private CheckBox checkBoxExplore;
        private Label label7;
    }
}