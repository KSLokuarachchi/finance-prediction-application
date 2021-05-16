using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using W1534169_2019172.controller.userEvents;
using W1534169_2019172.model.userEvents;
using W1534169_2019172.view.common;
using W1534169_2019172.view.expense;

namespace W1534169_2019172.view.userEvent
{
    public partial class EventCreateView : Form
    {
        AddExpenseOptionsCtrl eventsCtrl = null;
        AddEventsCtrl[] eventsCtrlList;
        List<UserEvents> userEvents = new List<UserEvents>();
        EventDetailsController eventsController;
        const int SPACE = 20;
        public EventCreateView()
        {
            InitializeComponent();
        }

        private void EventCreateView_Load(object sender, EventArgs e)
        {
            eventsCtrl = new AddExpenseOptionsCtrl();
            eventsCtrl.Location = new Point(38, 77);

            this.Controls.Add(eventsCtrl);
            eventsCtrl.btnAddExpense.Click += BtnAddExpense_Click;
        }

        private void BtnAddExpense_Click(object sender, EventArgs e)
        {
            Int32 expensesAmount = eventsCtrl.ExpensesAmount;

            int count = 0;
            while (true)
            {
                if (eventsPanel.Controls[String.Format("eventsCtrl{0}", count)] != null)
                {
                    eventsPanel.Controls.Remove(eventsPanel.Controls[String.Format("eventsCtrl{0}", count)]);
                    count++;
                }
                else
                {
                    break;
                }
            }

            eventsCtrlList = new AddEventsCtrl[expensesAmount];

            /*Rendering forms according to the amount*/
            for (int i = 0; i < expensesAmount; i++)
            {
                eventsCtrlList[i] = new AddEventsCtrl();
                eventsCtrlList[i].Location = new Point(40, (SPACE * 10) + ((eventsCtrlList[i].Height + SPACE) * i));
                eventsCtrlList[i].Name = String.Format("eventsCtrl{0}", i);
                eventsPanel.Controls.Add(eventsCtrlList[i]);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            eventsCtrl = new AddExpenseOptionsCtrl();

            foreach (AddEventsCtrl eventCtrl in eventsCtrlList)
            {
                UserEvents userEvent = new UserEvents();
                userEvent.Date = eventsCtrl.SelectedDate;
                userEvent.Name = eventCtrl.EventName;
                userEvent.Type = eventCtrl.EventType;
                userEvent.Amount = eventCtrl.Amount;
                userEvent.IsRecurring = eventCtrl.isRecurring;
                userEvent.RecurringPeriod = eventCtrl.RecurringPeriod;
                userEvent.TransactionType = eventCtrl.TransactionType;

                userEvents.Add(userEvent);
                eventCtrl.Enabled = false;
            }

            eventsController = new EventDetailsController();
            eventsController.createEvent(userEvents);

            this.btnSave.Text = "Saved!";
            this.btnSave.ForeColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeView().Show();
        }
    }
}
