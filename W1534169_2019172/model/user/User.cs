using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1534169_2019172.model.user
{
    public class User
    {
        private int id;
        private string fullName;
        private string email;
        private string phoneNumber;
        private string username;
        private string password;

        public int Id { get => id; set => id = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        public void createUser(User user)
        {
            UserEntity entity = new UserEntity();
            entity.createUser(user);
        }

        public User getUser(User user)
        {
            UserEntity entity = new UserEntity();
            User retrievedUser = entity.getUser(user);

            return retrievedUser;
        }
    }
}
