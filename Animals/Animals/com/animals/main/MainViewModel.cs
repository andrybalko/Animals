using Animals.com.animals.basic;
using System;
using Xamarin.Forms;

namespace Animals.com.animals.main
{
    public class MainViewModel:ViewModelBase
    {
        public DateTime CurrentTime { get; set; }

        public string Animal { get; private set; }

        public Action<string> SetAnimal { get; private set; }

        private bool isTimerRunning;

        public MainViewModel()
        {
            SetAnimal = new Action<string>((animal)=> SelectAnimal(animal));
            CurrentTime = DateTime.Now;
            isTimerRunning = true;
            StartTimer();
        }

        private void SelectAnimal(string animal)
        {
            Animal = animal;
            RaisePropertyChanged(nameof(Animal));
        }

        private void StartTimer()
        {
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                CurrentTime = CurrentTime.Add(TimeSpan.FromSeconds(1));
                RaisePropertyChanged(nameof(CurrentTime));
                return isTimerRunning;
            });
        }

        public void StopTimer()
        {
            isTimerRunning = false;
        }
    }
}
