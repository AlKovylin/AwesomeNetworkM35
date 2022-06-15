using AwesomeNetworkM35.Models;

namespace AwesomeNetworkM35.ViewModel
{
    public class UserViewModel
    {
        public User User { get; set; }

        public UserViewModel(User user)
        {
            User = user;
        }

    }
}
