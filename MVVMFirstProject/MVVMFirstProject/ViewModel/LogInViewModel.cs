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
        private String varName, varPassword;
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


        public event PropertyChangedEventHandler PropertyChanged;
        
        public ICommand LogInCommand => new Command(LogButtonClicked);
        public ICommand RegisterCommand => new Command(RegisterButtonClicked);

        #region LogButtonClicked()
        async private void LogButtonClicked()
        {
            //Check if there's any empty entry
            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Password))
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
