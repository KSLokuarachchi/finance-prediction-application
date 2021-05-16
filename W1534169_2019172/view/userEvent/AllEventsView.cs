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

namespace W1534169_2019172.view.userEvent
{
    public partial class AllEventsView : Form
    {
        EventDetailsController eventDetailsController = new EventDetailsController();
        AllEventsCtrl eventsCtrl;
        const int SPACE = 20;

        public AllEventsView()
        {
            InitializeComponent();
        }

        private void AllEventsView_Load(object sender, EventArgs e)
        {
            List<UserEvents> eventsList = eventDetailsController.getAllEvents();

            int i = 0;
            /*Rendering forms according to the amount*/
            foreach (var evt in eventsList)
            {
                eventsCtrl = new AllEventsCtrl();
                eventsCtrl.userEvent = evt;

                eventsCtrl.Date = evt.Date;
                eventsCtrl.EventName = evt.Name;
                eventsCtrl.Type = evt.Type;
                eventsCtrl.Amount = evt.Amount;
                eventsCtrl.IsRecurring = evt.IsRecurring;
                eventsCtrl.RecurringPeriod = evt.RecurringPeriod;
                eventsCtrl.TransactionType = evt.TransactionType;

                eventsCtrl.Location = new Point(40, (SPACE * 10) + ((eventsCtrl.Height + SPACE) * i));
                allEventsPanel.Controls.Add(eventsCtrl);
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeView().Show();
        }
    }
}
