using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using ToDo.Helpers;
using ToDo.Model;

namespace ToDo.DataService
{
    /// <summary>
    /// This class is used to maintain the data in local.
    /// </summary>
    public class SQLiteDatabase
    {

        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<SQLiteDatabase> Instance = new AsyncLazy<SQLiteDatabase>(async () =>
        {
            var instance = new SQLiteDatabase();

            CreateTableResult result = await Database.CreateTableAsync<Assignment>();

            return instance;
        });

        public SQLiteDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }


        public Task<List<Assignment>> GetItemsAsync()
        {
            return Database.Table<Assignment>().ToListAsync();
        }

        public Task<List<Assignment>> GetItemsNotDoneAsync()
        {
            // SQL queries are also possible
            return Database.QueryAsync<Assignment>("SELECT * FROM [Assignment] WHERE [Done] = 0");
        }

        public Task<Assignment> GetItemAsync(int id)
        {
            return Database.Table<Assignment>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Assignment item)
        {
            if (item.Id != 0)
            {
                return Database.UpdateAsync(item);
            }
            else
            {
                return Database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Assignment item)
        {
            return Database.DeleteAsync(item);
        }
    }
}
