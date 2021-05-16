using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.model.payer;

namespace W1534169_2019172.model.income
{
    public class Income
    {
        private int id;
        private DateTime date;
        private string name;
        private Double amount;
        private int userId;
        private Payer payer;
        private Boolean isDeleted;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }
        public int UserId { get => userId; set => userId = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        internal Payer Payer { get => payer; set => payer = value; }

        public void createIncome(List<Income> incomesList, int userId)
        {
            IncomeEntity entity = new IncomeEntity();
            entity.createIncome(incomesList, userId);
        }

        public void updateIncome(Income income, int userId)
        {
            IncomeEntity entity = new IncomeEntity();
            entity.updateIncome(income, userId);
        }

        public List<Income> getAllIncomes(int userId)
        {
            IncomeEntity entity = new IncomeEntity();
            return entity.getAllIncomes(userId);
        }
        public void deleteIncome(int incomeId)
        {
            IncomeEntity entity = new IncomeEntity();
            entity.deleteIncome(incomeId);
        }
    }
}
