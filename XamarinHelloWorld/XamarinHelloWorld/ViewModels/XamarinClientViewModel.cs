using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using XamarinClient;

namespace XamarinHelloWorld.ViewModels
{
    public class XamarinClientViewModel : INotifyPropertyChanged
    {
        private Client _client = new Client();

        private string _greeting;
        public string Greeting
        {
            get
            {
                return _greeting;
            }
            set
            {
                _greeting = value;
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(Greeting)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        internal void UpdateGreeting(string enteredText)
        {
            Greeting = _client.GetGreeting(enteredText);
        }
    }
}
