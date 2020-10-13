using Animals.com.animals.basic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Animals.com.animals.home
{
    public class HomeViewModel: ViewModelBase
    {

        public ICommand AboutCommand => new Command(() =>
        {
            //do nothing 
        });
    }
}
