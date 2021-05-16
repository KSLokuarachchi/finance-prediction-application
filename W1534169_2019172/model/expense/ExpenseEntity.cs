using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.controller;
using W1534169_2019172.controller.payee;
using W1534169_2019172.model.payee;

namespace W1534169_2019172.model.expense
{
    class ExpenseEntity
    {

        PayeeDetailsController payeeController;

        public int createExpense(Expense exp, int userId)
        {
            int savedExpenseId;
            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                        string createUserQuery = "INSERT INTO ExpenseDetails (date,name,amount,payeeId,userId,isDeleted) output INSERTED.ID VALUES (@date,@name,@amount,@payeeId,@userId,@isDeleted)";
                        SqlCommand cmd = new SqlCommand(createUserQuery, con);
                        cmd.Parameters.AddWithValue("@date", exp.Date);
                        cmd.Parameters.AddWithValue("@name", exp.Name);
                        cmd.Parameters.AddWithValue("@amount", exp.Amount);
                        cmd.Parameters.AddWithValue("@payeeId", exp.Payee.Id);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@isDeleted", false);
                        savedExpenseId = (int)cmd.ExecuteScalar();
                        Console.WriteLine(" modified " + savedExpenseId);
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while saving User", e);
                }
                con.Close();
            }
            return savedExpenseId;
        }

        public List<Expense> getAllExpenses(int userId)
        {
            List<Expense> expensesList = new List<Expense>();
            payeeController = new PayeeDetailsController();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM ExpenseDetails WHERE userId = @userId AND isDeleted = @isDeleted";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@isDeleted", false);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Expense exp = new Expense();
                        exp.Id = Convert.ToInt32(rdr["id"]);
                        exp.Date = Convert.ToDateTime(rdr["date"]);
                        exp.Name = Convert.ToString(rdr["name"]);
                        exp.Amount = Convert.ToDouble(rdr["amount"]);
                        Payee payee = new Payee();
                        payee = payeeController.getPayeeById(Convert.ToInt32(rdr["payeeId"]));
                        exp.Payee = payee;
                        Console.WriteLine("----    " + rdr[0] + rdr[1] + rdr[2] + rdr[3]);
                        expensesList.Add(exp);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while getting Expenses", e);
                }
                con.Close();


            }
            return expensesList;
        }

        public void updateExpense(Expense expense, int userId)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                        string createUserQuery = "UPDATE ExpenseDetails SET date = @date,name = @name,amount = @amount,userId = @userId,isDeleted = @isDeleted WHERE id=@id AND payeeId=@payeeId";
                        SqlCommand cmd = new SqlCommand(createUserQuery, con);
                        cmd.Parameters.AddWithValue("@id", expense.Id);
                        cmd.Parameters.AddWithValue("@date", expense.Date);
                        cmd.Parameters.AddWithValue("@name", expense.Name);
                        cmd.Parameters.AddWithValue("@amount", expense.Amount);
                        cmd.Parameters.AddWithValue("@payeeId", expense.Payee.Id);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@isDeleted", false);
                        cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while updating expense", e);
                }
                con.Close();


            }
        }

        public void deleteExpense(int expenseId)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "UPDATE ExpenseDetails SET isDeleted = @isDeleted WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@id", expenseId);
                    cmd.Parameters.AddWithValue("@isDeleted", true);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while deleting expense", e);
                }
                con.Close();
            }
        }
    }
}
