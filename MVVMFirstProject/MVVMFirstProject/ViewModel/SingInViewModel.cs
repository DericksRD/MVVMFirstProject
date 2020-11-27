using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMFirstProject.ViewModel
{
    class SingInViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        public ICommand SingInCommand => new Command(SingButtonClicked);

        #region SingButtonClicked()
        async public void SingButtonClicked()
        {
            if(string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Email) ||
               string.IsNullOrEmpty(Password) || string.IsNullOrEmpty(ConfirmPassword))
            {
                await App.Current.MainPage.DisplayAlert("No se puede completar la acción",
                                                        "Debe completar todos los campos para continuar",
                                                        "OK");
            }else if (!Password.Equals(ConfirmPassword))
            {
                await App.Current.MainPage.DisplayAlert("No se puede completar la acción",
                                                        "Ambas contraseñas no coinciden",
                                                        "Intentar de nuevo");
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Registro completado.", "", "Ok");
                await App.Current.MainPage.Navigation.PopAsync();
            }
        }
        #endregion
    }
}
