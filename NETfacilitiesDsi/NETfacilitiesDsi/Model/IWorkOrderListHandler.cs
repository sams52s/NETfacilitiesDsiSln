using System;
using System.Collections.Generic;
using System.Text;
using NETfacilitiesDsi.Enum;

namespace NETfacilitiesDsi.Model
{
    public interface IWorkOrderListHandler
    {
        void TableListLoaded(Dictionary<WorkOrderStatus, int> tableInfos);
        void TableListUnloaded(string errorMessage);
    }
}
