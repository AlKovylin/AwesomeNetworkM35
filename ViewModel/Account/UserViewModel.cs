using AwesomeNetworkM35.Models.Users;
using System.Collections.Generic;

namespace AwesomeNetworkM35.ViewModel.Account
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }
        public List<User> Friends { get; set; }

    }
}
