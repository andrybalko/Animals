using Animals.com.animals.home;
using Animals.com.animals.options;
using Xamarin.Forms;

namespace Animals.com.animals.main
{
    public partial class MainPage
    {
        MainViewModel vm;
        public MainPage()
        {
            InitializeComponent();
            vm = new MainViewModel();
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            if (sender.Equals(logoutBtn))
            {
                Application.Current.MainPage = new NavigationPage(new HomePage());
            }
            else
            {
                Navigation.PushModalAsync(new OptionsPage(vm.SetAnimal, vm.Animal));
            }
            
        }
    }
}