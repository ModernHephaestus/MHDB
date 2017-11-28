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
using System.Reflection;
using MHDB.Models.DatabaseItems;
using Windows.ApplicationModel.DataTransfer;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MHDB.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Data : Page
    {
        DataPackage dataPackage = new DataPackage();
        public Data()
        {
            this.InitializeComponent();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                Test.ItemsSource = db.Pistols.ToList();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                Test.ItemsSource = db.Pistols;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DatabaseHelper dbhelper = new DatabaseHelper();
            
            dbhelper.ResetDatabase();
            using (var db = new DatabaseContext())
            {
                Test.ItemsSource = db.Pistols;
            }
        }
    }
}
