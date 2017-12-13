using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashWhiteEventApp.BusinessLogicLayer
{
    class SecurityManager
    {
        public SecurityManager()
        {

        }

        public bool AuthenticateUser(string szUserName, string szPassword)
        {
            bool bRetVal = false;

            if (szUserName == "aaa" && szPassword == "")
            {
                bRetVal = true;
            }

            return bRetVal;
        }
    }

   
}
