
namespace Sarfiat.Gui.GuiIncome
{
    partial class IncomeUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonExport = new Button();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            dataGridView1 = new DataGridView();
            comboBoxPageNo = new ComboBox();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Controls.Add(buttonAdd);
            flowLayoutPanel1.Controls.Add(buttonEdit);
            flowLayoutPanel1.Controls.Add(buttonDelete);
            flowLayoutPanel1.Controls.Add(buttonUpdate);
            flowLayoutPanel1.Controls.Add(buttonExport);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(1262, 77);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Image = Properties.Resources.icons8_add_32px;
            buttonAdd.ImageAlign = ContentAlignment.TopCenter;
            buttonAdd.Location = new Point(1150, 7);
            buttonAdd.Margin = new Padding(2);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(100, 68);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "اضافة";
            buttonAdd.TextAlign = ContentAlignment.BottomCenter;
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Image = Properties.Resources.icons8_edit_32px;
            buttonEdit.ImageAlign = ContentAlignment.TopCenter;
            buttonEdit.Location = new Point(1046, 7);
            buttonEdit.Margin = new Padding(2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(100, 68);
            buttonEdit.TabIndex = 2;
            buttonEdit.Text = "تعديل";
            buttonEdit.TextAlign = ContentAlignment.BottomCenter;
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Image = Properties.Resources.icons8_delete_file_32px_2;
            buttonDelete.ImageAlign = ContentAlignment.TopCenter;
            buttonDelete.Location = new Point(942, 7);
            buttonDelete.Margin = new Padding(2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(100, 68);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "حذف";
            buttonDelete.TextAlign = ContentAlignment.BottomCenter;
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Image = Properties.Resources.icons8_refresh_32px;
            buttonUpdate.ImageAlign = ContentAlignment.TopCenter;
            buttonUpdate.Location = new Point(838, 7);
            buttonUpdate.Margin = new Padding(2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(100, 68);
            buttonUpdate.TabIndex = 6;
            buttonUpdate.Text = "تحديث";
            buttonUpdate.TextAlign = ContentAlignment.BottomCenter;
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonExport
            // 
            buttonExport.Image = Properties.Resources.icons8_export_csv_32px_7;
            buttonExport.ImageAlign = ContentAlignment.TopCenter;
            buttonExport.Location = new Point(734, 7);
            buttonExport.Margin = new Padding(2);
            buttonExport.Name = "buttonExport";
            buttonExport.Size = new Size(100, 68);
            buttonExport.TabIndex = 4;
            buttonExport.Text = "تصدير";
            buttonExport.TextAlign = ContentAlignment.BottomCenter;
            buttonExport.UseVisualStyleBackColor = true;
            buttonExport.Click += buttonExport_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(textBoxSearch);
            panel1.Controls.Add(buttonSearch);
            panel1.Location = new Point(235, 8);
            panel1.Margin = new Padding(3, 3, 5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 57);
            panel1.TabIndex = 5;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Font = new Font("Cairo", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxSearch.Location = new Point(48, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(444, 57);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = HorizontalAlignment.Center;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = Color.FromArgb(56, 96, 128);
            buttonSearch.Dock = DockStyle.Left;
            buttonSearch.FlatAppearance.BorderSize = 0;
            buttonSearch.FlatStyle = FlatStyle.Flat;
            buttonSearch.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSearch.ForeColor = Color.White;
            buttonSearch.Image = Properties.Resources.icons8_search_32px_2;
            buttonSearch.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch.Location = new Point(0, 0);
            buttonSearch.Margin = new Padding(5);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(48, 55);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "   بحث";
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1262, 523);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBoxPageNo
            // 
            comboBoxPageNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            comboBoxPageNo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPageNo.FormattingEnabled = true;
            comboBoxPageNo.Location = new Point(6, 548);
            comboBoxPageNo.Name = "comboBoxPageNo";
            comboBoxPageNo.Size = new Size(121, 45);
            comboBoxPageNo.TabIndex = 3;
            comboBoxPageNo.SelectedIndexChanged += comboBoxPageNo_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1107, 548);
            label1.Name = "label1";
            label1.Size = new Size(155, 52);
            label1.TabIndex = 4;
            label1.Text = "المقبوضات";
            // 
            // IncomeUserControl
            // 
            AutoScaleDimensions = new SizeF(11F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(comboBoxPageNo);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 6, 4, 6);
            Name = "IncomeUserControl";
            RightToLeft = RightToLeft.Yes;
            Size = new Size(1262, 600);
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.ComboBox comboBoxPageNo;
        private Label label1;
    }
}