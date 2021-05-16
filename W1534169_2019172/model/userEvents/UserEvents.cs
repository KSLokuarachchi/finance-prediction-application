using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1534169_2019172.model.userEvents
{
    public class UserEvents
    {
        private int id;
        private DateTime date;
        private string name;
        private string type;
        private Double amount;
        private Boolean isRecurring;
        private string recurringPeriod;
        private string transactionType;

        public int Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public double Amount { get => amount; set => amount = value; }
        public bool IsRecurring { get => isRecurring; set => isRecurring = value; }
        public string RecurringPeriod { get => recurringPeriod; set => recurringPeriod = value; }
        public string TransactionType { get => transactionType; set => transactionType = value; }

        public void createEvent(UserEvents events, int userId)
        {
            UserEventsEntity entity = new UserEventsEntity();
            entity.createEvent(events, userId);
        }

        public List<UserEvents> getAllEvents(int userId)
        {
            UserEventsEntity entity = new UserEventsEntity();
            return entity.getAllEvents(userId);
        }
    }
}
