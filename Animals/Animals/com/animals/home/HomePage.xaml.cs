using Animals.com.animals.login;

namespace Animals.com.animals.home
{
    public partial class HomePage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
        }

        private async void Login_Clicked(object sender, System.EventArgs e)
        {
            //this handler is made here to realize navigation. 
			//Proper way is to use any framework like Prism/MvvmCross/etc and navigate from viewmodels
            await Navigation.PushAsync(new LoginPage());
        }
    }
}