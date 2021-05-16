using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.controller;

namespace W1534169_2019172.model.userEvents
{
    class UserEventsEntity
    {
        public void createEvent(UserEvents evt, int userId)
        {
            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string createUserQuery = "INSERT INTO EventDetails (date,name,type,amount,isRecurring,recurringPeriod,transactionType,userId) output INSERTED.ID VALUES (@date,@name,@type,@amount,@isRecurring,@recurringPeriod,@transactionType,@userId)";
                    SqlCommand cmd = new SqlCommand(createUserQuery, con);
                    cmd.Parameters.AddWithValue("@date", evt.Date);
                    cmd.Parameters.AddWithValue("@name", evt.Name);
                    cmd.Parameters.AddWithValue("@type", evt.Type);
                    cmd.Parameters.AddWithValue("@amount", evt.Amount);
                    cmd.Parameters.AddWithValue("@isRecurring", evt.IsRecurring);
                    cmd.Parameters.AddWithValue("@recurringPeriod", evt.RecurringPeriod);
                    cmd.Parameters.AddWithValue("@transactionType", evt.TransactionType);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while saving event", e);
                }
                con.Close();
            }
        }

        public List<UserEvents> getAllEvents(int userId)
        {
            List<UserEvents> eventsList = new List<UserEvents>();

            string cs = ConfigurationManager.ConnectionStrings["W1534169_2019172.Properties.Settings.FinancialManagementToolConnectionString"].ConnectionString;

            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                try
                {
                    string selectUserQuery = "SELECT * FROM EventDetails WHERE userId = @userId";
                    SqlCommand cmd = new SqlCommand(selectUserQuery, con);
                    cmd.Parameters.AddWithValue("@userId", userId);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        UserEvents evt = new UserEvents();
                        evt.Id = Convert.ToInt32(rdr["id"]);
                        evt.Date = Convert.ToDateTime(rdr["date"]);
                        evt.Name = Convert.ToString(rdr["name"]);
                        evt.Type = Convert.ToString(rdr["type"]);
                        evt.Amount = Convert.ToDouble(rdr["amount"]);
                        if (Convert.ToInt32(rdr["isRecurring"]) == 1)
                        {
                            evt.IsRecurring = true;
                        }
                        else
                        {
                            evt.IsRecurring = false;
                        }
                        evt.RecurringPeriod = Convert.ToString(rdr["recurringPeriod"]);
                        evt.TransactionType = Convert.ToString(rdr["transactionType"]);
                        eventsList.Add(evt);
                    }
                }
                catch (Exception e)
                {
                    throw new FinancialManagementToolException("Error occured while getting Events", e);
                }
                con.Close();


            }
            return eventsList;
        }
    }
}
