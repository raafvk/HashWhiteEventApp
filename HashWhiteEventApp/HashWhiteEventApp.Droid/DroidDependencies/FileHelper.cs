using System;
using System.IO;
using Xamarin.Forms;
using System.Runtime.CompilerServices;
using HashWhiteEventApp.Droid.DroidDependencies;
using HashWhiteEventApp.Utilities;

[assembly: Xamarin.Forms.Dependency(typeof(FileHelper))]
namespace HashWhiteEventApp.Droid.DroidDependencies
{
    public class FileHelper:IFileHelper
    {
        public string GetLocalFilePath(string filename)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			return Path.Combine(path, filename);
		}
    }
}