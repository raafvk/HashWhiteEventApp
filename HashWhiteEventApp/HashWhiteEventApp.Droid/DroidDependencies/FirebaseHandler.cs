using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HashWhiteEventApp.Utilities;
using HashWhiteEventApp.Droid.DroidDependencies;
[assembly: Xamarin.Forms.Dependency(typeof(FirebaseHandler))]
namespace HashWhiteEventApp.Droid.DroidDependencies
{
    public class FirebaseHandler:IFirebaseHandler
    {
        private void InitializeFirebase()
        {

        }

        public Task CreateUserAsync(string emailId, string password)
        {
            return Task.Delay(0);
        }

        public Task AuthenticateUser(string emailId, string password)
        {
            return Task.Delay(0);
        }
    }
}