using HashWhiteEventApp.BusinessLogicLayer;
using HashWhiteEventApp.BusinessLogicLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HashWhiteEventApp.PresentationLayer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterUser : ContentPage
    {
        BusinessFacade m_oBusinessFacade;

        public RegisterUser()
        {
            InitializeComponent();
            m_oBusinessFacade = new BusinessFacade();
        }

        void OnRegisterButtonClicked(object sender, EventArgs args)
        {
            User oUser = new User();
            oUser.Name = "Rafi";
            oUser.PhoneNo = "245245";
            oUser.EmailID = "asdf@asd.com";
            var iResult=m_oBusinessFacade.RegisterUser(oUser).Result;

            if (iResult == 0)
            {
                DisplayAlert("Error", "USer Registration Failed", "Cancel");
            }
        }
    }
}