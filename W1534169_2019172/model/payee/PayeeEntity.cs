using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.controller;

namespace W1534169_2019172.model.payee
{
    class PayeeEntity
    {

        public void createPayee(Payee payeeDetails)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "INSERT INTO PayeeDetails (name,note) VALUES (@name,@note)";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@name", payeeDetails.Name);
                    cmd.Parameters.AddWithValue("@note", payeeDetails.Note);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while saving Payee", e);
                }
                con.Close();


            }
        }

        public Payee getPayee(Payee payeeDetails)
        {
            Payee payee = new Payee();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM PayeeDetails WHERE name = @name AND note = @note";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@name", payeeDetails.Name);
                    cmd.Parameters.AddWithValue("@note", payeeDetails.Note);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        payee.Id = Convert.ToInt32(rdr["id"]);
                        payee.Name = Convert.ToString(rdr["name"]);
                        payee.Note = Convert.ToString(rdr["note"]);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while selecting Payee", e);
                }
                con.Close();


            }
            return payee;
        }

        public Payee getPayeeById(int payeeId)
        {
            Payee payee = new Payee();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM PayeeDetails WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@id", payeeId);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        payee.Id = Convert.ToInt32(rdr[0]);
                        payee.Name = Convert.ToString(rdr[1]);
                        payee.Note = Convert.ToString(rdr[2]);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while getting Payee", e);
                }
                con.Close();


            }
            return payee;
        }

        public void updatePayee(Payee payee)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "UPDATE PayeeDetails SET name = @name,note = @note WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@id", payee.Id);
                    cmd.Parameters.AddWithValue("@name", payee.Name);
                    cmd.Parameters.AddWithValue("@note", payee.Note);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while updating Payee", e);
                }
                con.Close();


            }
        }
    }
}
