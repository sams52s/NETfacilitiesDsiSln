using NETfacilitiesDsi.Enum;
using NETfacilitiesDsi.Model;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NETfacilitiesDsi.View.ContentView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkOrderListView : Xamarin.Forms.ContentView, IWorkOrderListHandler
    {
        public WorkOrderListType Perametar { get; set; }
        public static readonly BindableProperty PeramitarProperty = BindableProperty.Create(
            propertyName: "Perametar",
            returnType: typeof(WorkOrderListType),
            declaringType: typeof(WorkOrderListView),
            defaultBindingMode: BindingMode.TwoWay
            );

        public WorkOrderListView()
        {
            InitializeComponent();
            
            
        }

        public void LoadData()
{
    Proxy.GetWorkStatusInfo(this, Perametar);
        }

        #region TableList

        public void TableListLoaded(Dictionary<WorkOrderStatus, int> tableInfos)
        {
            List<WorkOrderStatus> displayStatuses = new List<WorkOrderStatus>();
            displayStatuses.Add(WorkOrderStatus.Opened);
            displayStatuses.Add(WorkOrderStatus.Re_Opened);
            displayStatuses.Add(WorkOrderStatus.Approved);
            displayStatuses.Add(WorkOrderStatus.Dispatched);
            displayStatuses.Add(WorkOrderStatus.In_Progress);
            displayStatuses.Add(WorkOrderStatus.Denied);
            displayStatuses.Add(WorkOrderStatus.Canceled);
            displayStatuses.Add(WorkOrderStatus.Completed);
            displayStatuses.Add(WorkOrderStatus.Closed);
            displayStatuses.Add(WorkOrderStatus.On_Hold);
            displayStatuses.Add(WorkOrderStatus.Overdue);
            int totalCount = 0;

            for (int i = 0; i < displayStatuses.Count; i++)
            {
                 Label _label = new Label()
                 {
                     Text = displayStatuses[i].GetDisplayName()
                 };
                 OverAllTableContainer.Children.Add(_label, 0, i);
                 int count = (tableInfos.ContainsKey(displayStatuses[i])) ? tableInfos[displayStatuses[i]] : 0;
                 totalCount += count;
                Label _label2 = new Label()
                 {
                     Text = count.ToString()
            };
                 OverAllTableContainer.Children.Add(_label2, 1, i);
            }
            TotalNumber.Text = totalCount.ToString();

        }

        public void TableListUnloaded(string errorMessage)
        { }

        #endregion TableList
    }
}