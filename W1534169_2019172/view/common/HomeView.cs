using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.view.expense;
using W1534169_2019172.view.income;
using W1534169_2019172.view.report;
using W1534169_2019172.view.user;
using W1534169_2019172.view.userEvent;

namespace W1534169_2019172.view.common
{
    public partial class HomeView : Form
    {
        ExpenseCreateView expView;
        CreateIncomeView incView;
        AllExpensesView allExpenses;
        AllIncomesView allIncomes;
        FinancialPredictionReportView predictionReportView;
        EventCreateView eventView;
        AllEventsView allEventsView;
        AllExpensesXMLView expensesXMLview;

        public HomeView()
        {
            InitializeComponent();
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            this.Hide();
            expView = new ExpenseCreateView();
            expView.Activate();
            expView.ShowDialog();

        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            this.Hide();
            incView = new CreateIncomeView();
            incView.Activate();
            incView.ShowDialog();
        }

        private void btnListExpenses_Click(object sender, EventArgs e)
        {
            this.Hide();
            allExpenses = new AllExpensesView();
            allExpenses.Activate();
            allExpenses.ShowDialog();
        }

        private void btnListIncomes_Click(object sender, EventArgs e)
        {
            this.Hide();
            allIncomes = new AllIncomesView();
            allIncomes.Activate();
            allIncomes.ShowDialog();
        }

        private void btnPredictionReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            predictionReportView = new FinancialPredictionReportView();
            predictionReportView.Activate();
            predictionReportView.ShowDialog();
        }

        private void btnExpensesXMLList_Click(object sender, EventArgs e)
        {
            this.Hide();
            expensesXMLview = new AllExpensesXMLView();
            expensesXMLview.Activate();
            expensesXMLview.ShowDialog();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            this.Hide();
            eventView = new EventCreateView();
            eventView.Activate();
            eventView.ShowDialog();
        }

        private void btnListEvents_Click(object sender, EventArgs e)
        {
            this.Hide();
            allEventsView = new AllEventsView();
            allEventsView.Activate();
            allEventsView.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignInView().Show();
        }
    }
}
