using System;
using System.Collections.Generic;
using System.Text;

namespace NETfacilitiesDsi.Model
{
    public interface IButtonListHandler
    {
        void ButtonListLoaded(List<ButtonInfo> buttonInfos);
        void ButtonListLoadedFailed(string errorMessage);
    }
}
