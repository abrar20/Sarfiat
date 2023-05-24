using Sarfiat.Code;
using Sarfiat.Core;
using Sarfiat.Data;
using Sarfiat.Gui.GuiIncome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarfiat.Gui.GuiProjects
{
    public partial class ProjectManagementForm : Form
    {
        private readonly int projectId;
        private readonly IDataHelper<Outcome> dataHelperOutcome;
        private readonly IDataHelper<Income> dataHelperIncome;
        private double TotalIncome;
        private double TotalOutcome;

        public ProjectManagementForm(int ProjectId)
        {
            InitializeComponent();
            projectId = ProjectId;
            dataHelperOutcome = (IDataHelper<Outcome>)ConfigrationObjectManager.GetObject("Outcome");
            dataHelperIncome = (IDataHelper<Income>)ConfigrationObjectManager.GetObject("Income");
            LoadOutcomeUI();
            LoadIncomeUI();
        }
        private void LoadOutcomeUI()
        {
            //Load outcome ui
            GuiOutcome.OutcomeUserControl outcomeUserControl = new GuiOutcome.OutcomeUserControl(projectId);
            outcomeUserControl.Dock = DockStyle.Fill;
            panelOutcome.Controls.Add(outcomeUserControl);
        }
        private void LoadIncomeUI()
        {
            //Load Income ui
            GuiIncome.IncomeUserControl incomeUserControl = new GuiIncome.IncomeUserControl(projectId);
            incomeUserControl.Dock = DockStyle.Fill;
            panelIncome.Controls.Add(incomeUserControl);
        }

        private void ProjectManagementForm_Activated(object sender, EventArgs e)
        {
            GetTotalData();
        }
        private void GetTotalData()
        {
            //Get data
            try
            {
                TotalIncome = dataHelperIncome.GetAllData()
                    .Where(x => x.ProjectId == projectId).Select(x=> x.Amount).ToArray().Sum();
                TotalOutcome = dataHelperOutcome.GetAllData()
                    .Where(x => x.ProjectId == projectId).Select(x => x.Amount).ToArray().Sum();
            }
            catch 
            {

            }
            var Rev = TotalIncome - TotalOutcome;
            //Set data
            labelIncome.Text = "المقبوضات : " + TotalIncome.ToString("#0.00");
            labelOutcome.Text = "المصروفات : " + TotalOutcome.ToString("#0.00");
            labelRevenue.Text = "الأرباح : " + Rev.ToString("#0.00");
        }
    }
}
