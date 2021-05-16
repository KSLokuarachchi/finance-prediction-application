using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using W1534169_2019172.controller;

namespace W1534169_2019172.model.user
{
    public class UserEntity
    {

        public void createUser(User userDetails) {

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "INSERT INTO UserDetails (name,email,phoneNo,username,password) VALUES (@name,@email,@phoneNo,@username,@password)";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@name", userDetails.FullName);
                    cmd.Parameters.AddWithValue("@email", userDetails.Email);
                    cmd.Parameters.AddWithValue("@phoneNo", userDetails.PhoneNumber);
                    cmd.Parameters.AddWithValue("@username", userDetails.Username);
                    cmd.Parameters.AddWithValue("@password", userDetails.Password);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while saving User", e);
                }
                con.Close();


            }
        }


        public User getUser(User userDetails)
        {
            User user = new User();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM UserDetails WHERE username = @username";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@username", userDetails.Username);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        user.Id = Convert.ToInt32(rdr["id"]);
                        user.FullName = Convert.ToString(rdr["name"]);
                        user.Email = Convert.ToString(rdr["email"]);
                        user.PhoneNumber = Convert.ToString(rdr["phoneNo"]);
                        user.Username = Convert.ToString(rdr["username"]);
                        user.Password  = Convert.ToString(rdr["password"]);
                        Console.WriteLine("----    "+rdr[0]+rdr[1]+rdr[2]+rdr[3]+ rdr[4] + rdr[5]);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while selecting User", e);
                }
                con.Close();


            }
            return user;
        }

    }
}
