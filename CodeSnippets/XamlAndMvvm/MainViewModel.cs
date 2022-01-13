using System;
using System.ComponentModel;

namespace CodeSnippets.XamlAndMvvm
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
}

