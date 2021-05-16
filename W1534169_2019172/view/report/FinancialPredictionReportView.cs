using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.controller.report;
using W1534169_2019172.controller.userEvents;
using W1534169_2019172.model.expense;
using W1534169_2019172.model.userEvents;
using W1534169_2019172.view.common;
using W1534169_2019172.view.expense;
using W1534169_2019172.view.userEvent;

namespace W1534169_2019172.view.report
{
    public partial class FinancialPredictionReportView : Form
    {
        ReportDetailsController reportController;
        Double predictedAmount;
        AllExpensesListCtrl expenseCtrl;
        AllEventsCtrl eventsCtrl;
        const int SPACE = 20;

        public FinancialPredictionReportView()
        {
            InitializeComponent();
        }

        private void btnPredictReport_Click(object sender, EventArgs e)
        {
            if (this.txtPredictionDate.Value <= DateTime.Today)
            {
                MessageBox.Show("Please select a future date for the prediction");
            }
            else
            {

                lblCurrency.Show();
                lblPredictedAmount.Show();
                lblSelectedDate.Show();
                lblDayType.Text = this.txtPredictionDate.Value.DayOfWeek.ToString();
                lblDayType.Show();


                reportController = new ReportDetailsController();
                this.predictedAmount = reportController.createFinancialPredictionReport(this.txtPredictionDate.Value);
                lblPredictedAmount.Text = Convert.ToString(this.predictedAmount);

                List<Expense> expensesHistory = reportController.getExpenseDataForPredictionReport();
                List<UserEvents> eventsHistory = reportController.getEventDataForPredictionReport();

                int i = 0;
                /*Rendering expenses*/
                foreach (var expense in expensesHistory)
                {
                    expenseCtrl = new AllExpensesListCtrl();
                    expenseCtrl.expense = expense;

                    expenseCtrl.Date = expense.Date;
                    expenseCtrl.ExpenseName = expense.Name;
                    expenseCtrl.Amount = expense.Amount;
                    expenseCtrl.Payee = expense.Payee;

                    expenseCtrl.Location = new Point(40, (SPACE * 10) + ((expenseCtrl.Height + SPACE) * i));
                    expensesHistoryPanel.Controls.Add(expenseCtrl);
                    i++;
                }

                int j = 0;
                /*Rendering events*/
                foreach (var evt in eventsHistory)
                {
                    eventsCtrl = new AllEventsCtrl();
                    eventsCtrl.userEvent = evt;

                    eventsCtrl.Date = evt.Date;
                    eventsCtrl.EventName = evt.Name;
                    eventsCtrl.Type = evt.Type;
                    eventsCtrl.Amount = evt.Amount;
                    eventsCtrl.IsRecurring = evt.IsRecurring;
                    eventsCtrl.RecurringPeriod = evt.RecurringPeriod;
                    eventsCtrl.TransactionType = evt.TransactionType;

                    eventsCtrl.Location = new Point(40, (SPACE * 10) + ((eventsCtrl.Height + SPACE) * i));
                    eventsHistoryPanel.Controls.Add(eventsCtrl);
                    j++;
                }
            }
        }

        private void FinancialPredictionReportView_Load(object sender, EventArgs e)
        {
            lblCurrency.Hide();
            lblPredictedAmount.Hide();
            lblSelectedDate.Hide();
            lblDayType.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeView().Show();
        }
    }
}
