using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVVMFirstProject.Model
{
    class User : INotifyPropertyChanged
    {
        private String varName, varEmail, varPassword, varConfirmPassword;
        public String Name { 
            get 
            {
                return varName;
            }
            set 
            {
                //varName = value;
                //PropertyChanged?.Invoke(this, 
                //    new PropertyChangedEventArgs(nameof(Name)));
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
    }
}
