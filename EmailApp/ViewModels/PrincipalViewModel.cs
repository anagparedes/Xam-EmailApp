using EmailApp.Models;

using EmailApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    public class PrincipalViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Mail> Mails { get; set; } = new ObservableCollection<Mail>();
        private Mail _mail;
        public Mail SelectedMail

        {
            get
            {
                return _mail;
            }

            set
            {
                _mail = value;
                if(_mail != null)
                {
                    SelectedMailCommand.Execute(_mail);
                }
            }
        
        
        }
                         
        public ICommand AddMailCommand { get; }
        private ICommand SelectedMailCommand { get; }
        public ICommand DeleteCommand { get; }

        public PrincipalViewModel()
        {
            AddMailCommand = new Command(AddMail);
            SelectedMailCommand = new Command<Mail>(OnMailSelected);
            DeleteCommand = new Command<Mail>(OnDelete);
        }

        private void OnDelete(Mail mail)
        {
            Mails.Remove(mail);
        }

        private async void OnMailSelected(Mail mail)
        {
            await App.Current.MainPage.Navigation.PushAsync(new DetailPage(mail.To,mail.From,mail.Subject,mail.Body));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private async void AddMail()
        {
            await App.Current.MainPage.Navigation.PushAsync(new AddMailPage(Mails));
            
        }
   




    }
}