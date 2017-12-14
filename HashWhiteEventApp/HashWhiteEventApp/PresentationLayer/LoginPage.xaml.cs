using HashWhiteEventApp.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace HashWhiteEventApp.PresentationLayer
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        BusinessFacade m_oBusinessFacade;

        public LoginPage()
        {
            InitializeComponent();
            m_oBusinessFacade = new BusinessFacade();
        }

        void OnLoginButtonClicked(object sender, EventArgs args)
        {
            if (m_oBusinessFacade.AuthenticateUser("aaa", ""))
            {
                DisplayAlert("Info","Login Success","Cancel");
            }
        }

        async void OnRegisterButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RegisterUser());
        }
    }
}