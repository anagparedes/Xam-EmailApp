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
    public class AddMailViewModel : INotifyPropertyChanged
    {

        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; } }
        
        
        public ICommand SendMailCommand { get; }

        private ObservableCollection<Mail> _mails;

        public event PropertyChangedEventHandler PropertyChanged;

        public AddMailViewModel(ObservableCollection<Mail> mails)
        {
            _mails = mails;
            SendMailCommand = new Command(async()=>
            {
                mails.Add(new Mail(To, From, Subject, Body, Date));
                await App.Current.MainPage.Navigation.PopAsync();
            }
            );

   

        }

     
    }
}