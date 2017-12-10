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
    internal class MenuItem
    {
        /// <summary>
        /// This class provides the Hamburger Menu items used for navigation throughout the app.
        /// </summary>
        internal Symbol Icon { get; set; }
        internal string Name { get; set; }
        internal Type PageType { get; set; }

        internal static List<MenuItem> GetMainItems()
        {
            var items = new List<MenuItem>
            {
                new MenuItem() { Icon = Symbol.Home, Name = "Home", PageType = typeof(Views.Home) },
                new MenuItem() { Icon = Symbol.ViewAll, Name = "Data", PageType = typeof(Views.Data) },
                new MenuItem() { Icon = Symbol.TwoPage, Name = "Compare", PageType = typeof(Views.Compare) }
            };
            return items;
        }

        internal static List<MenuItem> GetOptionsItems()
        {
            var items = new List<MenuItem>
            {
                new MenuItem() { Icon = Symbol.Setting, Name = "Settings", PageType = typeof(Views.Settings) }
            };
            return items;
        }
    }
}
