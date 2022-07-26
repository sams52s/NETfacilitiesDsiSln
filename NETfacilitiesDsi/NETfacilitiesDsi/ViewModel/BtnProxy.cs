using NETfacilitiesDsi.View.ContentView;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NETfacilitiesDsi.ViewModel
{
    public class BtnProxy
    {
        #region _btnColor
        /*
        private string _buttonColorOverAll= "CornflowerBlue";
        private string _buttonColorOverdue="white";
        private string _buttonColorToday  ="white";
        private string _buttonColorPyramid="white";
        private string _buttonColorGraph  ="white";
        private string _buttonColorCalendar = "white";*/
        #endregion

        #region ButtonColorProperty

        /* public string ButtonColorOverAll { get; set=>value; }
         public string ButtonColorOverdue { get; set; }
         public string ButtonColorToday { get; set; }
         public string ButtonColorPyramid { get; set; }
         public string ButtonColorGraph { get; set; }
         public string ButtonColorCalendar { get; set; }
         */
        /* public string ButtonColorOverAll
         {
             get => this._buttonColorOverAll;
             set => this._buttonColorOverAll = value;
         }
         public string ButtonColorOverdue
         {
             get => this._buttonColorOverdue;
             set => this._buttonColorOverdue = value;
         }
         public string ButtonColorToday
         {
             get => this._buttonColorToday;
             set => this._buttonColorToday = value;
         }
         public string ButtonColorPyramid
         {
             get => this._buttonColorPyramid;
             set => this._buttonColorPyramid = value;
         }
         public string ButtonColorGraph
         {
             get => this._buttonColorGraph;
             set => this._buttonColorGraph = value;
         }
         public string ButtonColorCalendar
         {
             get => this._buttonColorCalendar;
             set => this._buttonColorCalendar = value;
         }

         */
        #endregion
        public string OverallViewSL { get; set; }
        public string OverdueSL { get; set; }
        public string TodaySL { get; set; }

        public async Task BtnProperty(string cP)
        {
            switch (cP)
            {
                case "WorkOrderListView":
                    OverallViewSL = "true";
                    OverdueSL = "false";
                    TodaySL = "true";
                    /*ButtonColorOverAll = "CornflowerBlue";
                    ButtonColorOverdue = "white";
                    ButtonColorToday = "white";*/
                    break;
                case "Overdue":
                   /*ButtonColorOverAll = "white";
                    ButtonColorOverdue = "CornflowerBlue";
                    ButtonColorToday = "white";*/
                    break;
                case "Today":
                   /* ButtonColorOverAll = "white";
                    ButtonColorOverdue = "white";
                    ButtonColorToday = "CornflowerBlue";*/
                    break;
                default:
                    /*ButtonColorOverAll = "white";
                    ButtonColorOverdue = "white";
                    ButtonColorToday = "white";*/
                    break;

            }
        }

       


        private Task DisplayAlert(string v1, string v2, string v3)
        {
            throw new NotImplementedException();
        }
    }
}