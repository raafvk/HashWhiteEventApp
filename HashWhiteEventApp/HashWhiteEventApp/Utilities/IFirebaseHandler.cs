using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashWhiteEventApp.Utilities
{
    /// <summary>
    /// Dependency service interface to perform the firebase operations
    /// </summary>
    public interface IFirebaseHandler
    {
        /// <summary>
        /// Creates a user in firebase
        /// </summary>
        /// <param name="emailId">Email Id of the user</param>
        /// <param name="password">password of the user</param>
        /// <returns>UID of the user from fire base</returns>
        /// <remarks> This method doesnt validates any constraints</remarks>
        Task CreateUserAsync(string emailId, string password);

        /// <summary>
        /// Authenticates the input user details.
        /// </summary>
        /// <param name="emailId">Email ID of the user</param>
        /// <param name="password">Password</param>
        /// <returns></returns>
        Task AuthenticateUser(string emailId, string password);

    }
}
