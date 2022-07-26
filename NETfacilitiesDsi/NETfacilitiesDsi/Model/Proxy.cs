using NETfacilitiesDsi.Enum;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace NETfacilitiesDsi.Model
{
    public class Proxy
    {
        #region ScrollViewHomePageBtn

       /* #region ICommandProperty

        public static ICommand Overdue { get; private set; }
        public static ICommand OverAll { get; private set; }
        public static ICommand Calender { get; private set; }
        public static ICommand Graph { get; private set; }
        public static ICommand Pyramid { get; private set; }
        public static ICommand Today { get; private set; }

        #endregion*/


        public static void GetButtonInfo(IButtonListHandler callbackHandler)
        {
            List<ButtonInfo> result = new List<ButtonInfo>();
            result.Add(new ButtonInfo()
            {
                Text = "Over All",
                //CommandParameter = OverAll,
                CommandParameter = "OverAll",
                ImageSource = "clipboard.png",
                BackgroundColor = Color.CornflowerBlue
            });
            result.Add(new ButtonInfo()
            {
                Text = "Overdue",
                //CommandParameter = Overdue,
                CommandParameter = "Overdue",
                ImageSource = "baggage.png",
                BackgroundColor = Color.White
            });
            result.Add(new ButtonInfo()
            {
                Text = "Today's",
                ImageSource = "Today.png",
                //CommandParameter = Today,
                CommandParameter = "Today",
                BackgroundColor = Color.White
            });
            result.Add(new ButtonInfo()
            {
                Text = "High Priority",
                ImageSource = "Pyramid.png",
                //CommandParameter = Pyramid,
                CommandParameter = "Pyramid",
                BackgroundColor = Color.White
            });
            result.Add(new ButtonInfo()
            {
                Text = "Graph",
                ImageSource = "graph.png",
                //CommandParameter = Graph,
                CommandParameter = "Graph",
                BackgroundColor = Color.White
            });
            result.Add(new ButtonInfo()
            {
                Text = "Calender",
                ImageSource = "calendar.png",
               // CommandParameter = Calender,
                CommandParameter = "Calender",
                BackgroundColor = Color.White
            });
            callbackHandler.ButtonListLoaded(result);
        }

        #endregion


        #region GetWorkStatusInfo

        public static void GetWorkStatusInfo(IWorkOrderListHandler callbackHandler, System.Enum workOrderStatus)
        {
            #region DictionaryForWorkOrderStatus
            Dictionary<WorkOrderStatus, int> result = new Dictionary<WorkOrderStatus, int>();
            WorkOrderStatus Opened = WorkOrderStatus.Opened;
            WorkOrderStatus Re_Opened = WorkOrderStatus.Re_Opened;
            WorkOrderStatus Approved = WorkOrderStatus.Approved;
            WorkOrderStatus Dispatched = WorkOrderStatus.Dispatched;
            WorkOrderStatus In_Progress = WorkOrderStatus.In_Progress;
            WorkOrderStatus Denied = WorkOrderStatus.Denied;
            WorkOrderStatus Canceled = WorkOrderStatus.Canceled;
            WorkOrderStatus Completed = WorkOrderStatus.Completed;
            WorkOrderStatus Closed = WorkOrderStatus.Closed;
            WorkOrderStatus On_Hold = WorkOrderStatus.On_Hold;
            WorkOrderStatus Overdue = WorkOrderStatus.Overdue;


            #endregion

            switch (workOrderStatus)
            {
                #region OverAll

                case WorkOrderListType.Overall:
                    result.Add(Opened, 7);
                    result.Add(Re_Opened, 5);
                    result.Add(Approved, 10);
                    result.Add(Dispatched, 15);
                    result.Add(In_Progress, 4);
                    result.Add(Denied, 1);
                    result.Add(Canceled, 0);
                    result.Add(Completed, 3);
                    result.Add(Closed, 0);
                    result.Add(On_Hold, 5);
                    result.Add(Overdue, 11);
                    break;

                #endregion OverAll

                #region Overdue

                case WorkOrderListType.Overdue:
                    result.Add(Opened, 7);
                    result.Add(Re_Opened, 5);
                    result.Add(Approved, 10);
                    result.Add(Dispatched, 15);
                    result.Add(In_Progress, 4);
                    result.Add(Denied, 1);
                    result.Add(Canceled, 0);
                    result.Add(Completed, 3);
                    result.Add(Closed, 0);
                    result.Add(On_Hold, 5);
                    result.Add(Overdue, 11);
                    break;

                #endregion Overdue

                #region Today

                case WorkOrderListType.Today:
                    result.Add(Opened, 0);
                    result.Add(Re_Opened, 2);
                    result.Add(Approved, 0);
                    result.Add(Dispatched, 5);
                    result.Add(In_Progress, 3);
                    result.Add(Denied, 2);
                    result.Add(Canceled, 1);
                    result.Add(Completed, 0);
                    result.Add(Closed, 0);
                    result.Add(On_Hold, 0);
                    result.Add(Overdue, 0);
                    break;

                #endregion Today

                #region Pyramid

                case WorkOrderListType.Pyramid:
                    result.Add(Opened, 4);
                    result.Add(Re_Opened, 1);
                    result.Add(Approved, 0);
                    result.Add(Dispatched, 1);
                    result.Add(In_Progress, 5);
                    result.Add(Denied, 14);
                    result.Add(Canceled, 1);
                    result.Add(Completed, 5);
                    result.Add(Closed, 0);
                    result.Add(On_Hold, 15);
                    result.Add(Overdue, 1);
                    break;

                #endregion Pyramid

                default:
                    break;
            }

            callbackHandler.TableListLoaded(result);
        }

        #endregion


        #region GetCalenderInfo
        public static void GetCalendarInfo(ICalendarInfoHandler callbackHandler, int date)
        {
            Dictionary<CalendarInfo, string> calendarInfo = new Dictionary<CalendarInfo, string>();

            CalendarInfoTitelName WorkOrder = CalendarInfoTitelName.WorkOrder;
            CalendarInfoTitelName Originator = CalendarInfoTitelName.Originator;
            CalendarInfoTitelName Area = CalendarInfoTitelName.Area;
            CalendarInfoTitelName LocationNotes = CalendarInfoTitelName.LocationNotes;
            CalendarInfoTitelName ServiceType = CalendarInfoTitelName.ServiceType;
            CalendarInfoTitelName TaskName = CalendarInfoTitelName.TaskName;

            //calendarInfo.Add(WorkOrder, "17941931");
            //callbackHandler.CalendarInfoDetailes(calendarInfo);
        }


        #endregion

    }
}