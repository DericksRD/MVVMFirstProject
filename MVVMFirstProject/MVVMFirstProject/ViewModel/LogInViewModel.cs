using MVVMFirstProject.Model;
using MVVMFirstProject.View;
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
        public User user1 = new User();
        public String email { get; set; }
        public String password { get; set; }

        /*public LogInViewModel user = new LogInViewModel();*/
        public ICommand LogInCommand => new Command(LogButtonClicked);
        public ICommand RegisterCommand => new Command(RegisterButtonClicked);

        #region LogButtonClicked()
        async private void LogButtonClicked()
        {
            //Check if there's any empty entry
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                await App.Current.MainPage.DisplayAlert("No se puede completar la acción",
                    $"Debe de completar todos los campos", "Ok");
            }else
            {
                await App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
        }
        #endregion

        #region RegisterButtonClicked()
        async public void RegisterButtonClicked()
        {
            await App.Current.MainPage.Navigation.PushAsync(new SingInPage());
        }
        #endregion

    }
}
