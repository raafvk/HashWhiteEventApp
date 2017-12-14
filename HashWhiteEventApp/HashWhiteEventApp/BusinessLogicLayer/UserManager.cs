using HashWhiteEventApp.BusinessLogicLayer.Models;
using HashWhiteEventApp.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashWhiteEventApp.BusinessLogicLayer
{
    class UserManager
    {
        DataManager m_oDataManager;
        public UserManager()
        {
            m_oDataManager = new DataManager();
        }

        internal Task<int> RegisterUser(User oUser)
        {
            return m_oDataManager.SaveItemAsync(oUser);
        }


    }
}
