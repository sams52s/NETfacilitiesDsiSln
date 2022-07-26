using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using NETfacilitiesDsi.Annotations;
using NETfacilitiesDsi.Request;
using NETfacilitiesDsi.View;
using Xamarin.Forms;

namespace NETfacilitiesDsi.ViewModel
{
    public class LoginViewModel:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string _email, _password, _errorMsg;
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Password"));
            }
        }
        public INavigation Navigation { get; set; }
        public ICommand LoginBtnClicked { get; private set; }
        public ICommand FGPassBtnClicked { get; private set; }
       public LoginViewModel(INavigation navigation)
        {
            Navigation = navigation;
            this.LoginBtnClicked = new Command(async () => await Login());
            this.FGPassBtnClicked = new Command(async () => await Navigation.PushAsync(new LoginView()));


        }
        public async Task Login()
        {
            LoginRequest loginRequest = new LoginRequest();
            bool loginValidation = loginRequest.Login(_email, _password);
            if (loginValidation)
            {
                App.IsUserLoggedIn = true;
                await Navigation.PushAsync(new HomePage());
            }
            else
            {
                ErrorMsg = "Login Failed";
                // App.IsUserLoggedIn = false;
                await Navigation.PushAsync(new LoginView());
            }
        }

        public string ErrorMsg
        {
            get => _errorMsg;
            set
            {
                _errorMsg = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ErrorMsg"));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }


}
