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
    public partial class VerifiedPage : ContentPage
    {
        public VerifiedPage(string name)
        {
            InitializeComponent();
            BindingContext = new XamarinClientViewModel();
            ((XamarinClientViewModel)BindingContext).UpdateGreeting(name);
            awaitApprovalNotification();
        }

        async void awaitApprovalNotification()
        {
            CheckMark.IsVisible = true;
            await Task.Delay(5000);
            await Navigation.PushAsync(new ConfirmationPage());
        }
    }
}