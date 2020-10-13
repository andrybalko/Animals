using Animals.com.animals.main;

namespace Animals.com.animals.login
{
    public partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }

        private void User_Completed(object sender, System.EventArgs e)
        {
            Pass.Focus();
        }

        private async void Login_Clicked(object sender, System.EventArgs e)
        {
            //this handler is made here to realize navigation. 
			//Proper way is to use any framework like Prism/MvvmCross/etc and navigate from viewmodels
            await Navigation.PushAsync(new MainPage());
        }
    }
}