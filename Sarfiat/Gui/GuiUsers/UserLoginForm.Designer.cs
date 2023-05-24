namespace Sarfiat.Gui.GuiUsers
{
    partial class UserLoginForm
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
            buttonLogin = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label6 = new Label();
            label2 = new Label();
            textBoxUserName = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonLogin);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 579);
            panel1.Name = "panel1";
            panel1.Size = new Size(608, 76);
            panel1.TabIndex = 0;
            // 
            // buttonLogin
            // 
            buttonLogin.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Image = Properties.Resources.icons8_save_32px_9;
            buttonLogin.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLogin.Location = new Point(14, 7);
            buttonLogin.Margin = new Padding(5);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(580, 55);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "تسجيل الدخول";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxUserName);
            groupBox1.Controls.Add(label3);
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
            label7.Location = new Point(168, 187);
            label7.Name = "label7";
            label7.Size = new Size(209, 56);
            label7.TabIndex = 17;
            label7.Text = "مرحبا بك مجدداً";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_ava;
            pictureBox1.Location = new Point(198, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 140);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 655);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserLoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل دخول";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Button buttonLogin;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label6;
        private Label label2;
        private TextBox textBoxUserName;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label7;
    }
}