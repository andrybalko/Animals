using System;

namespace Animals.com.animals.options
{
    public partial class OptionsPage
    {
        private readonly Action<string> setAnimal;
        OptionsViewModel vm;
        public OptionsPage(Action<string> setAnimal, string animal)
        {
            InitializeComponent();
            this.setAnimal = setAnimal;
            vm = new OptionsViewModel() { SelectedAnimal = animal };
            BindingContext = vm;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            setAnimal(vm.SelectedAnimal);
            Navigation.PopModalAsync();
        }
    }
}