using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W1534169_2019172.view.userEvent
{
    public partial class AddEventsCtrl : UserControl
    {
        public AddEventsCtrl()
        {
            InitializeComponent();
        }

        public string EventName
        {
            get
            {
                return this.txtEventName.Text;
            }
        }
        public string EventType
        {
            get
            {
                return this.txtEventType.Text;
            }
        }
        public Double Amount
        {
            get
            {
                return Convert.ToDouble(this.txtAmount.Text);
            }
        }
        public Boolean isRecurring
        {
            get
            {
                return this.chkIsRecurring.Checked;
            }
        }
            public string RecurringPeriod
        {
            get
            {
                return this.cmbRecurringPeriod.Text;
            }
        }
            public string TransactionType
        {
            get
            {
                return this.cmbTransactionType.Text;
            }

        }

        private void chkIsRecurring_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (chkIsRecurring.Checked)
            {
                this.cmbRecurringPeriod.Enabled = true;
            }
        }

        private void AddEventCtrl_Load(object sender, EventArgs e)
        {
            this.cmbRecurringPeriod.Enabled = false;
        }

        private void chkIsRecurring_Click(object sender, EventArgs e)
        {
            if (chkIsRecurring.Checked)
            {
                this.cmbRecurringPeriod.Enabled = true;
            }
            else
            {
                this.cmbRecurringPeriod.Enabled = false;
            }
        }
    }
}
