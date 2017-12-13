using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashWhiteEventApp.BusinessLogicLayer
{
    class BusinessFacade
    {
        SecurityManager m_oSecurityManager;

        public BusinessFacade()
        {
            m_oSecurityManager = new SecurityManager();

        }

        public bool AuthenticateUser(string szUserName, string szPassword)
        {
            return m_oSecurityManager.AuthenticateUser(szUserName, szPassword);
        }
    }
}
