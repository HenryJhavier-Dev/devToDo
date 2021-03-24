using System;
using System.Windows.Input;
using ToDo.Model;
using Xamarin.Forms;

namespace ToDo.ViewModel
{
    public class NewToDoViewModel: BaseViewModel
    {
        #region commands
        public ICommand SaveNewTodoCommand { get; set; }
        #endregion
        public NewToDoViewModel()
        {
            SaveNewTodoCommand = new Command(SaveNewTodoClicked);
        }

        public async void SaveNewTodoClicked() {

            var newTodo = new Assignment
            {
                Name = "Test Todo",
                Created = new DateTime(),
                Duration = new TimeSpan(),
                Succes = false
            };

            var dataBase = await App.DataBase;
            var saveItem = await dataBase.SaveItemAsync(newTodo);

            if (saveItem > 0)
            {
                //Insert Item
            }
            else {
               // Error inset item 
            }

            Console.WriteLine("Salvo el registro");

    }
    }
}
