using System;
using System.Collections.Generic;
using System.Text;

namespace NETfacilitiesDsi.Model
{
    public interface ICalendarInfoHandler
    {
        void CalendarInfoDetailes(Dictionary<CalendarInfo, string> calendarInfoDictionary);
        void CalendarInfoDetailesUnloaded(string errorMessage);
    }
}
