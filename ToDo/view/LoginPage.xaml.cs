using System;
using System.Collections.Generic;
using ToDo.ViewModel;
using Xamarin.Forms;

namespace ToDo.View
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
