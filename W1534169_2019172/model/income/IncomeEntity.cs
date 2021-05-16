using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.controller;
using W1534169_2019172.controller.payer;
using W1534169_2019172.model.payer;

namespace W1534169_2019172.model.income
{
    class IncomeEntity
    {
        PayerDetailsController payerController;

        public void createIncome(List<Income> incomesList, int userId)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    foreach (Income inc in incomesList)
                    {
                        string createUserQuery = "INSERT INTO IncomeDetails (date,name,amount,payerId,userId,isDeleted) VALUES (@date,@name,@amount,@payerId,@userId,@isDeleted)";
                        SqlCommand cmd = new SqlCommand(createUserQuery, con);
                        cmd.Parameters.AddWithValue("@date", inc.Date);
                        cmd.Parameters.AddWithValue("@name", inc.Name);
                        cmd.Parameters.AddWithValue("@amount", inc.Amount);
                        cmd.Parameters.AddWithValue("@payerId", inc.Payer.Id);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@isDeleted", false);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while saving income", e);
                }
                con.Close();


            }
        }

        public List<Income> getAllIncomes(int userId)
        {
            List<Income> incomesList = new List<Income>();
            payerController = new PayerDetailsController();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM IncomeDetails WHERE userId = @userId AND isDeleted = @isDeleted";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@isDeleted", false);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        Income inc = new Income();
                        inc.Id = Convert.ToInt32(rdr["id"]);
                        inc.Date = Convert.ToDateTime(rdr["date"]);
                        inc.Name = Convert.ToString(rdr["name"]);
                        inc.Amount = Convert.ToDouble(rdr["amount"]);
                        Payer payer = new Payer();
                        payer = payerController.getPayerById(Convert.ToInt32(rdr["payerId"]));
                        inc.Payer = payer;
                        Console.WriteLine("----    " + rdr[0] + rdr[1] + rdr[2] + rdr[3]);
                        incomesList.Add(inc);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while getting Incomes", e);
                }
                con.Close();


            }
            return incomesList;
        }

        public void updateIncome(Income income, int userId)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "UPDATE IncomeDetails SET date = @date,name = @name,amount = @amount,userId = @userId,isDeleted = @isDeleted WHERE id=@id AND payerId=@payerId";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@id", income.Id);
                    cmd.Parameters.AddWithValue("@date", income.Date);
                    cmd.Parameters.AddWithValue("@name", income.Name);
                    cmd.Parameters.AddWithValue("@amount", income.Amount);
                    cmd.Parameters.AddWithValue("@payerId", income.Payer.Id);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@isDeleted", false);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while updating income", e);
                }
                con.Close();


            }
        }

        public void deleteIncome(int incomeId)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "UPDATE IncomeDetails SET isDeleted = @isDeleted WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@id", incomeId);
                    cmd.Parameters.AddWithValue("@isDeleted", true);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while deleting income", e);
                }
                con.Close();
            }
        }
    }
}
