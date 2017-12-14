using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashWhiteEventApp.Utilities
{
    /// <summary>
    /// Interface to abstract the platform-specific functionality, 
    /// eg: to determine the location of the database file. 
    /// </summary>
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);

    }
}
