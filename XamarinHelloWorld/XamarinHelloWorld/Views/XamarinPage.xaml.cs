using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinHelloWorld.ViewModels;

namespace XamarinHelloWorld.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamarinPage : ContentPage
    {
        public XamarinPage()
        {
            InitializeComponent();
            BindingContext = new XamarinClientViewModel();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var enteredText = NameEntry.Text;
            ((XamarinClientViewModel)BindingContext).UpdateGreeting(enteredText);
        }
    }
}