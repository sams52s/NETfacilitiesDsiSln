using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Threading.Tasks;

namespace NETfacilitiesDsi.Enum
{
    public enum CalendarInfoTitelName
    {
        WorkOrder,
        Originator,
        Area,
        LocationNotes,
        ServiceType,
        TaskName
    }

    public static class CalendarInfoClass
    {
        public static string DisplayCalendarTitel(this CalendarInfoTitelName calendarInfo)
        {
            switch (calendarInfo)
            {
                case CalendarInfoTitelName.WorkOrder: return "WORK ORDER";
                case CalendarInfoTitelName.Originator: return "ORIGINATOR";
                case CalendarInfoTitelName.Area: return "SITE:SUB-SITE,AREA";
                case CalendarInfoTitelName.LocationNotes: return "LOCATION NOTES";
                case CalendarInfoTitelName.ServiceType: return "SERVICE TYPE";
                case CalendarInfoTitelName.TaskName: return "TASK NAME";
                default: return "No value founded";
            }
        }
    }
}
