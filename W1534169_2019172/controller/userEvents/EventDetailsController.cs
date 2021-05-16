using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W1534169_2019172.controller.user;
using W1534169_2019172.model.userEvents;

namespace W1534169_2019172.controller.userEvents
{
    class EventDetailsController
    {
        UserEvents events;
        UserDetailsController userController;

        public void createEvent(List<UserEvents> eventsList)
        {
            events = new UserEvents();
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");


            /* Saving results in the database */
            foreach (UserEvents userEvent in eventsList)
            {
                events.createEvent(userEvent, userId);
            }
        }

        public List<UserEvents> getAllEvents()
        {
            events = new UserEvents();
            /* Getting currently logged-in user */
            userController = new UserDetailsController();
            int userId = userController.readFile("currentUser.xml");

            /* Getting results in the database */
            return events.getAllEvents(userId);
          

        }
    }
}
