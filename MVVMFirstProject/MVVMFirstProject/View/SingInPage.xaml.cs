﻿using MVVMFirstProject.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMFirstProject.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingInPage : ContentPage
    {
        public SingInPage()
        {
            InitializeComponent();
            BindingContext = new SingInViewModel();
        }
    }
}