using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using W1534169_2019172.controller.expense;
using W1534169_2019172.controller.user;
using W1534169_2019172.controller.userEvents;
using W1534169_2019172.model.expense;
using W1534169_2019172.model.userEvents;

namespace W1534169_2019172.controller.report
{
    class ReportDetailsController
    {
        UserDetailsController userController;
        ExpenseDetailsController expenseController;
        EventDetailsController eventsController;
        List<UserEvents> reportEventsList = new List<UserEvents>();
        List<Expense> reportExpensesList = new List<Expense>();

        public Double createFinancialPredictionReport(DateTime dateForPrediction)
        {
            List<Double> expensesAmount = new List<Double>();
            Double averageAmount = 0.0;
            if (dateForPrediction != null && dateForPrediction > DateTime.Today)
            {
                /* Getting currently logged-in user */
                userController = new UserDetailsController();
                int userId = userController.readFile("currentUser.xml");

                /* Getting all the expenses of the current user */
                expenseController = new ExpenseDetailsController();
                List<Expense>  expenses = expenseController.getAllExpenses();

                foreach (var expense in expenses)
                {
                    /* checking for the date type (Ex.Sunday/Monday/Tuesday.. ) of the user given date
                     * checking the date type of the expenses added
                     * if there are any matches (Ex. Given day also a Monday, Expenses added for Monday
                     * then that specific expense amount is being added to the expensesAmount list
                     * along with the expense name
                     */
                    if(expense.Date.DayOfWeek == dateForPrediction.DayOfWeek)
                    {
                        expensesAmount.Add(expense.Amount);
                        this.reportExpensesList.Add(expense);
                    }
                }

                /* Getting all the events of the current user */
                eventsController = new EventDetailsController();
                List<UserEvents> events = eventsController.getAllEvents();

                foreach (var evt in events)
                {
                    if (evt.Date.DayOfWeek == dateForPrediction.DayOfWeek && evt.IsRecurring)
                    {
                        expensesAmount.Add(evt.Amount);
                        this.reportEventsList.Add(evt);
                    }
                }

                averageAmount = this.getExpensesAverage(expensesAmount);
            }
            return averageAmount;
        }

        public double getExpensesAverage(List<Double> expensesAmount) {

            int totalAmountsCount = expensesAmount.Count();
            int totalAmounts = 0;
            double averageAmount = 0.0;
            foreach (var amount in expensesAmount)
            {
                 totalAmounts += Convert.ToInt32(amount);

            }
            if (totalAmountsCount != 0)
            {
                averageAmount = totalAmounts / totalAmountsCount;
            }
            return averageAmount;
        }

        public List<UserEvents> getEventDataForPredictionReport()
        {
            return this.reportEventsList;
        }

        public List<Expense> getExpenseDataForPredictionReport()
        {
            return this.reportExpensesList;
        }
    }
}
