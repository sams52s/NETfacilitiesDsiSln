using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETfacilitiesDsi.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NETfacilitiesDsi.View
{
    
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}