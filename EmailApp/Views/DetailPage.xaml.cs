using EmailApp.Models;
using EmailApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EmailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string to, string from, string subject, string body)
        {
            InitializeComponent();
            BindingContext = new DetailViewModel(to,from,subject,body);
        }
    }
}