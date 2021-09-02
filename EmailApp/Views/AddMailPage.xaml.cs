using EmailApp.Models;
using EmailApp.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddMailPage : ContentPage
    {
        public AddMailPage(ObservableCollection<Mail> mails)
        {
            InitializeComponent();
            BindingContext = new AddMailViewModel(mails);
        }
    }
}