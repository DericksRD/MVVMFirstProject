using MVVMFirstProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMFirstProject.ViewModel
{
    class LogInViewModel
    {
        //private String email;

        //public String Email 
        //{
        //    get
        //    {
        //        return email;
        //    }
        //    set
        //    {
        //        email = value;
        //        PropertyChanged?.Invoke(this, 
        //                        new PropertyChangedEventArgs(nameof(Email)));
        //    }
        //}
        //public LogInViewModel user = new LogInViewModel();


        //public event PropertyChangedEventHandler PropertyChanged;
        //public ICommand LogInCommand => new Command(LogButtonClicked);

        //async private void LogButtonClicked()
        //{
        //    //Check if there's any empty entry
        //    if(string.IsNullOrEmpty(user.Email))
        //        //string.IsNullOrEmpty(user.Password))
        //    {
        //        await App.Current.MainPage.DisplayAlert("No se puede completar la acción",
        //            "Debe llenar todos los campos para continuar", "Ok");
        //    }
        //    else
        //    {
        //        await App.Current.MainPage.DisplayAlert("Welcome back", "", "Ok");
        //    }
        //}
    }
}
