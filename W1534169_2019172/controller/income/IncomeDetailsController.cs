using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.controller.user;
using W1534169_2019172.model.income;

namespace W1534169_2019172.controller.income
{
    class IncomeDetailsController
    {
        Income income;
        UserDetailsController userController;

        public void createIncome(List<Income> incomesList)
        {
            income = new Income();
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");


            /* Saving results in the database */
            income.createIncome(incomesList, userId);
        }
        public List<Income> getAllIncomes()
        {
            income = new Income();
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");

            /* Saving results in the database */
            return income.getAllIncomes(userId);

        }

        public void updateIncome(Income income)
        {
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");


            /* Updating results in the database */
            income.updateIncome(income, userId);
        }

        public void deleteIncome(int incomeId)
        {
            income = new Income();
            /* Deleting  results in the database */
            income.deleteIncome(incomeId);
        }
    }
}
