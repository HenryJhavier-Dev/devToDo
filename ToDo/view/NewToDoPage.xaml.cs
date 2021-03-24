using System;
using System.Collections.Generic;
using ToDo.ViewModel;

using Xamarin.Forms;

namespace ToDo.View
{
    public partial class NewToDoPage : ContentPage
    {
        public NewToDoPage()
        {
            InitializeComponent();
            BindingContext = new NewToDoViewModel();

        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            var dataBase = await App.DataBase;
            var getItem = await dataBase.GetItemsAsync();

        }
    }
}
