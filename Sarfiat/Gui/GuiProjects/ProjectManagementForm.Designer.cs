namespace Sarfiat.Gui.GuiProjects
{
    partial class ProjectManagementForm
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
            labelRevenue = new Label();
            labelIncome = new Label();
            labelOutcome = new Label();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panelIncome = new Panel();
            panelOutcome = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(labelRevenue);
            panel1.Controls.Add(labelIncome);
            panel1.Controls.Add(labelOutcome);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(1062, 103);
            panel1.TabIndex = 0;
            // 
            // labelRevenue
            // 
            labelRevenue.Dock = DockStyle.Left;
            labelRevenue.Location = new Point(440, 0);
            labelRevenue.Name = "labelRevenue";
            labelRevenue.Size = new Size(220, 103);
            labelRevenue.TabIndex = 3;
            labelRevenue.Text = "الأرباح 000000";
            labelRevenue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelIncome
            // 
            labelIncome.Dock = DockStyle.Left;
            labelIncome.Location = new Point(220, 0);
            labelIncome.Name = "labelIncome";
            labelIncome.Size = new Size(220, 103);
            labelIncome.TabIndex = 2;
            labelIncome.Text = "المقبوضات  000000";
            labelIncome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelOutcome
            // 
            labelOutcome.Dock = DockStyle.Left;
            labelOutcome.Location = new Point(0, 0);
            labelOutcome.Name = "labelOutcome";
            labelOutcome.Size = new Size(220, 103);
            labelOutcome.TabIndex = 1;
            labelOutcome.Text = "المصروفات 000000";
            labelOutcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Cairo", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(676, 0);
            label1.Name = "label1";
            label1.Size = new Size(386, 103);
            label1.TabIndex = 0;
            label1.Text = "إدارة صرفيات المشاريع";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.Window;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panelIncome, 1, 0);
            tableLayoutPanel1.Controls.Add(panelOutcome, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1062, 570);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelIncome
            // 
            panelIncome.Dock = DockStyle.Fill;
            panelIncome.Location = new Point(3, 3);
            panelIncome.Name = "panelIncome";
            panelIncome.Size = new Size(525, 564);
            panelIncome.TabIndex = 0;
            // 
            // panelOutcome
            // 
            panelOutcome.Dock = DockStyle.Fill;
            panelOutcome.Location = new Point(534, 3);
            panelOutcome.Name = "panelOutcome";
            panelOutcome.Size = new Size(525, 564);
            panelOutcome.TabIndex = 1;
            // 
            // ProjectManagementForm
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 673);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "ProjectManagementForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إدارة المشروع";
            WindowState = FormWindowState.Maximized;
            Activated += ProjectManagementForm_Activated;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelIncome;
        private Panel panelOutcome;
        private Label labelRevenue;
        private Label labelIncome;
        private Label labelOutcome;
        private Label label1;
    }
}