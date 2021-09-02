
using EmailApp.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand { get; }


        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void OnLogin(object obj)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Warning!", "The fields are required to login!","Ok");
           
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Welcome!", $"{Email}","Ok");
                await App.Current.MainPage.Navigation.PushAsync(new PrincipalPage());


            }


        }
             
    }
}