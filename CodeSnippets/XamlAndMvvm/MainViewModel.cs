using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MyApp.ViewModels
{
    //<IntroViewModel>
	public class MainViewModel : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged;

        private string text;
        public string Text
        {
            get => text;
            set
            {
                if(text != value)
                {
                    text = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Text)));
                }
            }
        }
    }
    //</IntroViewModel>

    public class Main2ViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //<CommandIntro>
        private ICommand save;
        public ICommand Save
        {
            get => save;
            set
            {
                if(save != value)
                {
                    save = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Save)));
                }
            }
        }
        //</CommandIntro>
    }
}

