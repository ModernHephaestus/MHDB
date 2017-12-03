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
using MHDB.Models;
using Microsoft.Toolkit.Uwp;
using Microsoft.EntityFrameworkCore;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MHDB
{
    /// <summary>
    /// Page which contains the Hamburger Menu and the Frame where the other pages are loaded into.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            HamburgerMenu.ItemsSource = MenuItem.GetMainItems();
            HamburgerMenu.OptionsItemsSource = MenuItem.GetOptionsItems();
            ContentFrame.Navigate(typeof(Views.Home));
        }
        private void OnMenuItemClick(object sender, ItemClickEventArgs e)
        {
            var menuItem = e.ClickedItem as MenuItem;
            ContentFrame.Navigate(menuItem.PageType);
        }

        private void HamburgerMenu_LostFocus(object sender, RoutedEventArgs e)
        {
            HamburgerMenu.IsPaneOpen = false;
        }
    }
    
}
