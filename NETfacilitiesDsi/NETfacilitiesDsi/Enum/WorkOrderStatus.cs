using System;
using System.Collections.Generic;
using System.Text;

namespace NETfacilitiesDsi.Enum
{ 
    public enum WorkOrderStatus
        {
            Opened,
            Re_Opened,
            Approved,
            Dispatched,
            In_Progress,
            Denied,
            Canceled,
            Completed,
            Closed,
            On_Hold,
            Overdue,

        }
    


    public static class WorkOrderStatusClass
    {
        public static string GetDisplayName(this WorkOrderStatus wos)
        {
            switch (wos)
            {
                case WorkOrderStatus.Opened:
                    return "Opened";
                case WorkOrderStatus.Re_Opened:
                    return "Re-Opened";
                case WorkOrderStatus.Approved:
                    return "Approved";
                case WorkOrderStatus.Dispatched:
                    return "Dispatched";
                case WorkOrderStatus.In_Progress:
                    return "In Progress";
                case WorkOrderStatus.Denied:
                    return "Denied";
                case WorkOrderStatus.Canceled:
                    return "Canceled";
                case WorkOrderStatus.Completed:
                    return "Completed";
                case WorkOrderStatus.Closed:
                    return "Closed";
                case WorkOrderStatus.On_Hold:
                    return "On Hold";
                case WorkOrderStatus.Overdue:
                    return "Overdue";
                default: return "No value founded";
            }

        }
    }
    
}
