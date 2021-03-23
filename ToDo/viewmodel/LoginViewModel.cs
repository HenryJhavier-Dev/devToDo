using System;
using System.Windows.Input;
using ToDo.view;
using Xamarin.Forms;

namespace ToDo.viewmodel
{
    public class LoginViewModel: BaseViewModel
    {

        #region fields
        #endregion

        #region properties
        #endregion

        #region commands
        public ICommand LoginCommand { get; set; }
        #endregion

        public LoginViewModel()
        {
            LoginCommand = new Command(
                execute: async ()  => {
                    await Application.Current.MainPage.Navigation.PushAsync(new NewToDoPage());
                    Console.WriteLine("Execute");
                },
                canExecute: () =>
                {
                    Console.WriteLine("canExecute");
                    return true;
                });
        }
    }
}
