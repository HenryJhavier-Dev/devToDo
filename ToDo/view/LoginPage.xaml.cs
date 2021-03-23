using System;
using System.Collections.Generic;
using ToDo.viewmodel;
using Xamarin.Forms;

namespace ToDo.view
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel();
        }
    }
}
