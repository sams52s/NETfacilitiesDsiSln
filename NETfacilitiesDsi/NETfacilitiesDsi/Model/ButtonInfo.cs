using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace NETfacilitiesDsi.Model
{
    public class ButtonInfo
    {
        
        public string Text { get; set; }
        public string ImageSource { get; set; }
       //public System.Windows.Input.ICommand CommandParameter { get; set; }
       public string CommandParameter { get; set; }
        public Color BackgroundColor { get; set; }
    }
}
