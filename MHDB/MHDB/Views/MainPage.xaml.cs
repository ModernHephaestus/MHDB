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
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //internal SQLiteConnection DbConn { get; set; }
        DatabaseHelper DbHelper { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            DbHelper = new DatabaseHelper();
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
