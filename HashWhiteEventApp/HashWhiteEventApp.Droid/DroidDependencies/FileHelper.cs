using System;
using System.IO;
using System.Runtime.CompilerServices;
using Android.App;
using Android.Content.Res;
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

        public string GetAssetFileContenet(string filename)
        {
            AssetManager manager = Application.Context.Assets;
            using (StreamReader streamReader = new StreamReader(manager.Open(filename)))
            {   
                var result = streamReader.ReadToEnd();
                streamReader.Close();
                return result;
            }

            
        }
    }
}