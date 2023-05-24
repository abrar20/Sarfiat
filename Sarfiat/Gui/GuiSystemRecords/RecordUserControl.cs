using ClosedXML.Excel;
using Sarfiat.Code;
using Sarfiat.Core;
using Sarfiat.Data;
using Sarfiat.Gui.GuiHome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarfiat.Gui.GuiSystemRecords
{
    public partial class RecordUserControl : UserControl
    {
        private readonly IDataHelper<SystemRecords> dataHelper;
        private readonly IDataHelper<SystemRecords> dataHelperSystemRecords;
        private readonly IDataHelper<Income> dataHelperIncome;
        private readonly IDataHelper<Outcome> dataHelperOutcome;
        private static RecordUserControl _RecordUserControl;
        private int RowId;
        private readonly GuiLoading.LoadingForm loadingform;
        private List<int> IdList = new List<int>();
        private string SearchItem;
        private double Amount;

        public RecordUserControl()
        {
            InitializeComponent();
            dataHelper = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            //dataHelperSystemRecords = (IDataHelper<SystemRecords>)ConfigrationObjectManager.GetObject("SystemRecords");
            dataHelperIncome = (IDataHelper<Income>)ConfigrationObjectManager.GetObject("Income");
            dataHelperOutcome = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            loadingform = new GuiLoading.LoadingForm();
            LoadData();
        }
        #region Events

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                var DeleteResult = MessageCollection.ShowDeleteDialog();
                if (DeleteResult)
                {
                    IdList.Clear();
                    SetIdRowForDelete();
                    loadingform.Show();
                    if (IdList.Count > 0)
                    {
                        for (int i = 0; i < IdList.Count; i++)
                        {
                            RowId = IdList[i];
                            var result = await dataHelper.DeleteAsync(RowId);
                            if (result == 1)
                            {
                                SystemRecords systemRecords = new SystemRecords
                                {
                                    Title = "عملية حذف",
                                    UserName = Properties.Settings.Default.UserName,
                                    Details = "تم حذف السجل ذي الرقم التعريفي " + RowId.ToString(),
                                    AddedDate = DateTime.Now

                                };
                                await dataHelper.AddAsync(systemRecords);
                                MessageCollection.ShowDeleteNotification();
                            }
                            else
                            {
                                MessageCollection.ShowErrorServer();
                            }
                        }
                        LoadData();
                    }
                    else { MessageCollection.ShowRequirdDeleteRow(); }

                    loadingform.Hide();
                }

            }
            else
            {
                MessageCollection.ShowEmptyDataMessage();
            }

        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            // convert data list to DataTable
            loadingform.Show();
            var data = await dataHelper.GetAllDataAsync();
            using (var reader = FastMember.ObjectReader.Create(data))
            {
                dataTable.Load(reader);
            }
            loadingform.Hide();
            // Re-Set Columns
            DataTable dataTableArranged = SetDataTableColumns(dataTable);
            //Export data as sheet excel
            ExportAsXlsxFile(dataTableArranged);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion
        // Singelton solve many instance that created each time we click on buttons,
        // so we will intiated one time and returend it every time clcick on button
        #region Methods
        public static RecordUserControl Instance()
        // return and if it is not created yet create it
        {
            return _RecordUserControl ?? (new RecordUserControl());
        }
        //public static RecordUserControl Instance(){
        // return and if it is not created yet create it
        //return _RecordUserControl ?? (new RecordUserControl());
        //}
        public async void LoadData()
        {
            loadingform.Show();
            var data = await dataHelper.GetAllDataAsync();
            dataGridView1.DataSource = data.Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
            comboBoxPageNo.Items.Clear();
            double value = (Convert.ToDouble(data.Count) / Convert.ToDouble(Properties.Settings.Default.DataGridViewRowNo));
            int NoOfPage = (int)Math.Ceiling(value);
            //int NoOfPage = (int)Math.Round(value,MidpointRounding.AwayFromZero);
            for (int i = 0; i < NoOfPage; i++)
            {
                comboBoxPageNo.Items.Add(i);
            }
            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            // if we did loadingform.Close(); and wnat to use it again we have to insiate it again beacuse it closed
            loadingform.Hide();
            data.Clear();
        }
        public async void Search()
        {
            loadingform.Show();
            SearchItem = textBoxSearch.Text;
            dataGridView1.DataSource = await dataHelper.SearchAsync(SearchItem);
            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            // if we did loadingform.Close(); and wnat to use it again we have to insiate it again beacuse it closed
            loadingform.Hide();
        }
        private void SetColumnsTitle()
        {
            dataGridView1.Columns[0].HeaderText = "المعرف";
            dataGridView1.Columns[1].HeaderText = "الاسم";
            dataGridView1.Columns[2].HeaderText = "العنوان";
            dataGridView1.Columns[3].HeaderText = "التفاصيل";
            dataGridView1.Columns[4].HeaderText = "تاريخ الإضافة";

        }
        private void SetIdRowForDelete()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    IdList.Add(Convert.ToInt32(row.Cells[0].Value));
                }
            }
        }
        private DataTable SetDataTableColumns(DataTable dataTable)
        {
            dataTable.Columns["Id"].SetOrdinal(0);
            dataTable.Columns["Id"].ColumnName = "المعرف";
            dataTable.Columns["UserName"].SetOrdinal(1);
            dataTable.Columns["UserName"].ColumnName = "الاسم";
            dataTable.Columns["Title"].SetOrdinal(2);
            dataTable.Columns["Title"].ColumnName = "العنوان";
            dataTable.Columns["Details"].SetOrdinal(3);
            dataTable.Columns["Details"].ColumnName = "الوصف";
            dataTable.Columns["AddedDate"].SetOrdinal(4);
            dataTable.Columns["AddedDate"].ColumnName = "تاريخ الإضافة";
            return dataTable;
        }
        private void ExportAsXlsxFile(DataTable dataTableArranged)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Sarfiat excel";
            saveFileDialog.DefaultExt = "xlsx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "Excel File (.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    using (XLWorkbook xlWorkbook = new XLWorkbook())// create excel file
                    {
                        xlWorkbook.AddWorksheet(dataTableArranged, "Data");// cretae sheet
                        using (MemoryStream ma = new MemoryStream())
                        {
                            xlWorkbook.SaveAs(ma);
                            File.WriteAllBytes(saveFileDialog.FileName, ma.ToArray());
                        }
                    }
                    //open the file but access denied
                    //System.Diagnostics.Process.Start(saveFileDialog.FileName);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }
        #endregion


        private async void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingform.Show();
            var data = await dataHelper.GetAllDataAsync();
            var dataId = data.Select(x => x.Id).ToArray();
            int index = comboBoxPageNo.SelectedIndex;
            int indexnoOfRow = index * Properties.Settings.Default.DataGridViewRowNo;
            dataGridView1.DataSource = data.Where(x => x.Id >= dataId[indexnoOfRow]).Take(Properties.Settings.Default.DataGridViewRowNo).ToList();
            if (dataGridView1.DataSource == null)
            {
                MessageCollection.ShowErrorServer();
            }
            else
            {
                SetColumnsTitle();
            }
            // if we did loadingform.Close(); and wnat to use it again we have to insiate it again beacuse it closed
            loadingform.Hide();
            data.Clear();
        }

        private async void RecordUserControl_Leave(object sender, EventArgs e)
        {

        }
    }
}
