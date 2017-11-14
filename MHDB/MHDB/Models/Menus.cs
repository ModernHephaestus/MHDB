using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace MHDB.Models
{
    public class MenuItem
    {
        public Symbol Icon { get; set; }
        public string Name { get; set; }
        public Type PageType { get; set; }

        public static List<MenuItem> GetMainItems()
        {
            var items = new List<MenuItem>
            {
                new MenuItem() { Icon = Symbol.Accept, Name = "Home", PageType = typeof(Views.Home) },
                new MenuItem() { Icon = Symbol.Send, Name = "Data", PageType = typeof(Views.Data) },
                new MenuItem() { Icon = Symbol.Shop, Name = "Compare", PageType = typeof(Views.Compare) }
            };
            return items;
        }

        public static List<MenuItem> GetOptionsItems()
        {
            var items = new List<MenuItem>
            {
                new MenuItem() { Icon = Symbol.Setting, Name = "OptionItem1", PageType = typeof(Views.Settings) }
            };
            return items;
        }
    }
}
