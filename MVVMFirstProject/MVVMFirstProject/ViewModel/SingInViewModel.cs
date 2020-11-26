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

        public ICommand SingInCommand => new Command(SingButtonClicked);

        async public void SingButtonClicked()
        {
            await App.Current.MainPage.DisplayAlert("Registro completado.", "", "Ok");
            await App.Current.MainPage.Navigation.PopAsync();
        }
    }
}
