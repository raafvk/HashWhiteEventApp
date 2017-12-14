using HashWhiteEventApp.BusinessLogicLayer.Models;
using HashWhiteEventApp.Utilities;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HashWhiteEventApp.DataAccessLayer
{
    class DataManager
    {
        readonly SQLiteAsyncConnection m_oSQLiteAsyncConnection;
        public DataManager()
        {
            string szDBPath = DependencyService.Get<IFileHelper>().GetLocalFilePath("DB_HashWhite.db3");
            m_oSQLiteAsyncConnection = new SQLiteAsyncConnection(szDBPath);
            m_oSQLiteAsyncConnection.CreateTableAsync<User>().Wait();
            Debug.WriteLine("After the table creations");
        }

        public Task<List<User>> GetItemsAsync()
        {
            return m_oSQLiteAsyncConnection.Table<User>().ToListAsync();
        }

        public Task<List<User>> GetItemsNotDoneAsync()
        {
            return m_oSQLiteAsyncConnection.QueryAsync<User>("SELECT * FROM [User] WHERE [Done] = 0");
        }

        public Task<User> GetItemAsync(int id)
        {
            return m_oSQLiteAsyncConnection.Table<User>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(User item)
        {
            if (item.ID != 0)
            {
                return m_oSQLiteAsyncConnection.UpdateAsync(item);
            }
            else
            {
                return m_oSQLiteAsyncConnection.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(User item)
        {
            return m_oSQLiteAsyncConnection.DeleteAsync(item);
        }
    }
}
