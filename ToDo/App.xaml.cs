using ToDo.DataService;
using ToDo.View;
using Xamarin.Forms;

namespace ToDo
{
    public partial class App : Application
    {

        #region properties  sqlite
        static AsyncLazy<SQLiteDatabase> database;

        public static AsyncLazy<SQLiteDatabase> DataBase
        {
            get
            {
                if (database == null)
                    database = SQLiteDatabase.Instance;
                return database;
            }
        }
        #endregion

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
