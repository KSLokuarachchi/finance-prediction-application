using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.controller;

namespace W1534169_2019172.model.payer
{
    class PayerEntity
    {
        public void createPayer(Payer payerDetails)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createPayerQuery = "INSERT INTO PayerDetails (name,note) VALUES (@name,@note)";
                    SqlCommand cmd = new SqlCommand(createPayerQuery, con);
                    cmd.Parameters.AddWithValue("@name", payerDetails.Name);
                    cmd.Parameters.AddWithValue("@note", payerDetails.Note);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while saving Payer", e);
                }
                con.Close();


            }
        }

        public Payer getPayer(Payer payerDetails)
        {
            Payer payer = new Payer();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM PayerDetails WHERE name = @name AND note = @note";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@name", payerDetails.Name);
                    cmd.Parameters.AddWithValue("@note", payerDetails.Note);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        payer.Id = Convert.ToInt32(rdr[0]);
                        payer.Name = Convert.ToString(rdr[1]);
                        payer.Note = Convert.ToString(rdr[2]);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while selecting Payer", e);
                }
                con.Close();


            }
            return payer;
        }
        public Payer getPayerById(int payerId)
        {
            Payer payer = new Payer();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM PayerDetails WHERE id = @id";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@id", payerId);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        payer.Id = Convert.ToInt32(rdr["id"]);
                        payer.Name = Convert.ToString(rdr["name"]);
                        payer.Note = Convert.ToString(rdr["note"]);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while getting Payer", e);
                }
                con.Close();


            }
            return payer;
        }

        public void updatePayer(Payer payer)
        {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "UPDATE PayerDetails SET name = @name,note = @note WHERE id=@id";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@id", payer.Id);
                    cmd.Parameters.AddWithValue("@name", payer.Name);
                    cmd.Parameters.AddWithValue("@note", payer.Note);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while updating Payer", e);
                }
                con.Close();


            }
        }
    }
}
