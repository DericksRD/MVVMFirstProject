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
    class LogInViewModel : INotifyPropertyChanged
    {
        private String varName, varEmail, varPassword, varConfirmPassword;
        public String Name
        {
            get
            {
                return varName;
            }
            set
            {
                varName = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(Name)));
            }
        }
        public String Email
        {
            get
            {
                return varEmail;
            }
            set
            {
                varEmail = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(Email)));
            }
        }
        public String Password
        {
            get
            {
                return varPassword;
            }
            set
            {
                varPassword = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(Password)));
            }
        }
        public String ConfirmPassword
        {
            get
            {
                return varConfirmPassword;
            }
            set
            {
                varConfirmPassword = value;
                PropertyChanged?.Invoke(this,
                    new PropertyChangedEventArgs(nameof(ConfirmPassword)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        public ICommand LogInCommand => new Command(LogButtonClicked);
        public ICommand RegisterCommand => new Command(RegisterButtonClicked);

        #region LogButtonClicked()
        async private void LogButtonClicked()
        {
            //Check if there's any empty entry
            if(string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
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
