using AwesomeNetworkM35.Models.Users;

namespace AwesomeNetworkM35.ViewModel.Account
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
