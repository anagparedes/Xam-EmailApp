using EmailApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    public class DetailViewModel : INotifyPropertyChanged
    {

        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        private DateTime _date;
        public DateTime Date { get { return _date; } set { _date = value; } }

        public DetailViewModel(string to, string from, string subject, string body)
        {
            To = to;
            From = from;
            Subject = subject;
            Body = body;
            
        }

     

        public ObservableCollection<Mail> Mails { get; set; } = new ObservableCollection<Mail>();

        public event PropertyChangedEventHandler PropertyChanged;
    }
    
}