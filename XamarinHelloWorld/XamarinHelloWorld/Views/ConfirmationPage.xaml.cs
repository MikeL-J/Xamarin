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
    public partial class ConfirmationPage : ContentPage
    {
        public ConfirmationPage()
        {
            InitializeComponent();
            BindingContext = new XamarinClientViewModel();
            awaitApprovalNotification();
        }

        async void awaitApprovalNotification()
        {
            await Task.Delay(4000);
            await Navigation.PushAsync(new LandingPage());
        }
    }
}