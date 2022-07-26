using NETfacilitiesDsi.Model;
using NETfacilitiesDsi.ViewModel;
using Syncfusion.XForms.Buttons;
using System;
using System.Collections.Generic;
using NETfacilitiesDsi.View.ContentView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamForms.Controls;

namespace NETfacilitiesDsi.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage, IButtonListHandler
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();

            Proxy.GetButtonInfo(this);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
               // WorkOrderStatusCustomButton button1 = (WorkOrderStatusCustomButton)sender;
               CustomeBtn button1= (CustomeBtn)sender;
               string commandParameter = button1.CommandParam.ToString();

                overall.IsVisible = commandParameter == "OverAll";
                overdue.IsVisible = commandParameter == "Overdue";
                today.IsVisible = commandParameter == "Today";
                pyramid.IsVisible = commandParameter == "Pyramid";
                graph.IsVisible = commandParameter == "Graph";
                //calender.IsVisible = commandParameter == "Calender";
                if(commandParameter == "Calender") 
                    await Navigation.PushAsync(new CalendarView());
                

            }
            catch (Exception exception)
            {
                await DisplayAlert("Error occurred", exception.Message.ToString(), "Ok");
            }
        }

        public void ButtonListLoaded(List<ButtonInfo> buttonInfos)
        {
            foreach (ButtonInfo buttoninfo in buttonInfos)
            {
                CustomeBtn button = new CustomeBtn()
                {
                    Text = buttoninfo.Text,
                    //CommandParameter = buttoninfo.CommandParameter,
                    //ImageSource = buttoninfo.ImageSource,
                    Image = buttoninfo.ImageSource,
                    CommandParam = buttoninfo.CommandParameter,
                    BackgroundColor = buttoninfo.BackgroundColor
                };
                button.Clicked += Button_Clicked;
                ButtonContainer.Children.Add(button);
            }
        }

        public void ButtonListLoadedFailed(string errorMessage)
        {
            throw new NotImplementedException();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            overall.LoadData();
            overdue.LoadData();
            today.LoadData();
            pyramid.LoadData();

            
            //your code here;

        }
    }
}