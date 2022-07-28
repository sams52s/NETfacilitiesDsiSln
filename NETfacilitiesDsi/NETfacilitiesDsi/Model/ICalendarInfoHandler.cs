using System;
using System.Collections.Generic;
using System.Text;

namespace NETfacilitiesDsi.Model
{
    public interface ICalendarInfoHandler
    {
        void CalendarInfoDetailes(List<CalendarInfo> calendarInfos);
        void CalendarInfoDetailesUnloaded(string errorMessage);
    }
}

