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
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MHDB.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Data : Page
    {
        private string TableSelected {get; set;}
        public Data()
        {
            this.InitializeComponent();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            //using (var db = new DatabaseContext())
            //{
            //    Test.ItemsSource = db.Pistols.ToList();
            //}
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                //Images.ItemsSource = db.Pistols;
                //Test.ItemsSource = db.Pistols;
                Info.ItemsSource = db.Pistols;
                //List<Button> ButtonList = new List<Button>();
                //ButtonList.Add(new Button { Content=})
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            //DatabaseHelper dbhelper = new DatabaseHelper();
            
            //dbhelper.ResetDatabase();
            //using (var db = new DatabaseContext())
            //{
            //    Images.ItemsSource = db.Pistols;
            //    Test.ItemsSource = db.Pistols;
            //}
        }

        private void SmallArmButtonClick(object sender, RoutedEventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                //var test = db.SmallArms;
                //Info.ItemsSource = db.SmallArms;
                TableSelected = "SmallArms";
                var test = new List<string>
                {
                    "Pistols",
                    "SubmachineGuns",
                    "RiflesAndCarbines"
                };
                SelectTable.ItemsSource = test;
            }
            SelectTable.Visibility = Visibility.Visible;
        }

        private void ArtilleryButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void VehiclesButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void AircraftButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void HelicoptersButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void ShipsButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void SelectTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            using (var db = new DatabaseContext())
            {
                Info.ItemsSource = db.Pistols;
            }
        }
    }
}
