using Animals.com.animals.basic;
using System.Threading.Tasks;

namespace Animals.com.animals.login
{
    public class LoginViewModel : ViewModelBase
    {
        private const string _uservalue = "username";
        private const string _passwordvalue = "password";

        private string username;
        private string password;

        public string Username { get => username; set 
            { 
                username = value;
                _ = CheckInput();
            }
        }
        public string Password
        {
            get => password; set
            {
                password = value;
                _ = CheckInput();
            }
        }

        public bool IsLoginEnabled { get; set; }

        private async Task CheckInput()
        {
            await Task.Delay(500);
            IsLoginEnabled = _uservalue.Equals(Username?.Trim().ToLower()) && _passwordvalue.Equals(Password?.Trim().ToLower());
            RaisePropertyChanged(nameof(IsLoginEnabled));
        }

    }
}
