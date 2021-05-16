using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.model.payee;

namespace W1534169_2019172.model.expense
{
    public class Expense
    {
        private int id;
        private DateTime date;
        private string name;
        private Double amount;
        private int userId;
        private Payee payee;
        private Boolean isDeleted;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public double Amount { get => amount; set => amount = value; }
        public int UserId { get => userId; set => userId = value; }
        public bool IsDeleted { get => isDeleted; set => isDeleted = value; }
        internal Payee Payee { get => payee; set => payee = value; }

        public int createExpense(Expense expense, int userId)
        {
            int id;
            ExpenseEntity entity = new ExpenseEntity();
            id = entity.createExpense(expense, userId);
            return id;
        }

        public void updateExpense(Expense expense, int userId)
        {
            ExpenseEntity entity = new ExpenseEntity();
            entity.updateExpense(expense, userId);
        }

        public List<Expense> getAllExpenses(int userId)
        {
            ExpenseEntity entity = new ExpenseEntity();
            return entity.getAllExpenses(userId);
        }
        public void deleteExpense(int expenseId)
        {
            ExpenseEntity entity = new ExpenseEntity();
            entity.deleteExpense(expenseId);
        }
    }
}
