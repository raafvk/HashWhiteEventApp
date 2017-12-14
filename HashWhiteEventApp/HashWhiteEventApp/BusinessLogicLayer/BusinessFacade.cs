using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashWhiteEventApp.BusinessLogicLayer.Models;
using HashWhiteEventApp.DataAccessLayer;

namespace HashWhiteEventApp.BusinessLogicLayer
{
    class BusinessFacade
    {
        SecurityManager m_oSecurityManager;
        //static 
        UserManager m_oUserManager;

        public BusinessFacade()
        {
            m_oSecurityManager = new SecurityManager();
            m_oUserManager = new UserManager();
        }

        public bool AuthenticateUser(string szUserName, string szPassword)
        {
            return m_oSecurityManager.AuthenticateUser(szUserName, szPassword);
        }

        internal Task<int> RegisterUser(User oUser)
        {
            return m_oUserManager.RegisterUser(oUser);
        }
    }
}
