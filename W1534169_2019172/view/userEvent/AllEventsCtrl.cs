using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.model.userEvents;

namespace W1534169_2019172.view.userEvent
{
    public partial class AllEventsCtrl : UserControl
    {
        public AllEventsCtrl()
        {
            InitializeComponent();
        }

        public UserEvents userEvent;

        DateTime date;
         string eventName;
         string type;
         Double amount;
         Boolean isRecurring;
         string recurringPeriod;
         string transactionType;

        

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string EventName
        {
            get { return eventName; }
            set { eventName = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public Boolean IsRecurring
        {
            get { return isRecurring; }
            set { isRecurring = value; }
        }
        public string RecurringPeriod
        {
            get { return recurringPeriod; }
            set { recurringPeriod = value; }
        }
        public string TransactionType
        {
            get { return transactionType; }
            set { transactionType = value; }
        }

        private void AllEventsCtrl_Load(object sender, EventArgs e)
        {
            lblDate.Text = Convert.ToString(Date);
            lblName.Text = EventName;
            lblType.Text = Type;
            lblAmount.Text = Convert.ToString(Amount);
            if (IsRecurring) {
                lblStatus.Text = "Recurring";
            }
            else
            {
                lblStatus.Text = "Non-Recurring";
            }
            lblRecurringPeriod.Text = RecurringPeriod;
            lblTransactionType.Text = TransactionType;
        }
    }
}
