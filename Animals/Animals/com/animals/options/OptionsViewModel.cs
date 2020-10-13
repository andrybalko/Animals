using Animals.com.animals.basic;
using System.Collections.ObjectModel;

namespace Animals.com.animals.options
{
    public class OptionsViewModel : ViewModelBase
    {
        private string selectedAnimal;
        private ObservableCollection<string> animals;

        public string SelectedAnimal
        {
            get => selectedAnimal;
            set
            {
                selectedAnimal = value;
                RaisePropertyChanged(nameof(SelectedAnimal));
            }
        }

        public ObservableCollection<string> Animals { get => animals; set 
            {
                animals = value; 
                RaisePropertyChanged(nameof(Animals));
            } 
        }
        public OptionsViewModel()
        {
            Animals = new ObservableCollection<string>()
            {
                "Rabbit",
                "Cat",
                "Dog",
                "Cow",
                "Pelican",
                "Fish",
                "Mouse",
            };
        }
    }
}
