using MHDB.Models;
using MHDB.Models.DatabaseItems;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MHDB.Views
{
    /// <summary>
    /// A Page where new items can be added to the Database.
    /// </summary>
    public sealed partial class Insert : Page
    {
        private string _TableSelected { get; set; }
        private string _TypeSelected { get; set; }
        private object _Item1 { get; set; }
        private object _Item2 { get; set; }
        private ObservableCollection<GenericHardware> NewItem = new ObservableCollection<GenericHardware>();

        public Insert()
        {
            this.InitializeComponent();
        }

        private void SelectLevel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ClickedItem = (TextBlock)e.ClickedItem;
            SelectTable.ItemsSource = DatabaseHelper.FillTableList(ClickedItem.Text);
            _TableSelected = ClickedItem.Text;
            SelectTable.Visibility = Visibility.Visible;
            NewItemInfo.Visibility = Visibility.Collapsed;
        }

        private void SelectTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                _TypeSelected = SelectTable.SelectedItem.ToString();
            }
            catch
            {

            }

            switch (_TableSelected)
            {
                case "Small Arms":
                    {
                        NewItem.Clear();
                        NewItem.Add(new SmallArms());
                        NewItemInfo.ItemsSource = NewItem;
                        NewItemInfo.ItemTemplate = (DataTemplate)Application.Current.Resources["SmallArmsInsertTemplate"];
                    }
                    break;
                case "Artillery":
                    {
                        NewItem.Clear();
                        NewItem.Add(new Artillery());
                        NewItemInfo.ItemsSource = NewItem;
                        NewItemInfo.ItemTemplate = (DataTemplate)Application.Current.Resources["ArtilleryInsertTemplate"];
                    }
                    break;
                case "Vehicles":
                    {
                        NewItem.Clear();
                        NewItem.Add(new Vehicles());
                        NewItemInfo.ItemsSource = NewItem;
                        NewItemInfo.ItemTemplate = (DataTemplate)Application.Current.Resources["VehiclesInsertTemplate"];
                    }
                    break;
                case "Aircraft":
                    {
                        NewItem.Clear();
                        NewItem.Add(new FixedWingAircraft());
                        NewItemInfo.ItemsSource = NewItem;
                        NewItemInfo.ItemTemplate = (DataTemplate)Application.Current.Resources["AircraftInsertTemplate"];
                    }
                    break;
                case "Helicopters":
                    {
                        NewItem.Clear();
                        NewItem.Add(new HelicopterRotorcraft());
                        NewItemInfo.ItemsSource = NewItem;
                        NewItemInfo.ItemTemplate = (DataTemplate)Application.Current.Resources["AircraftInsertTemplate"];
                    }
                    break;
                case "Ships":
                    {
                        NewItem.Clear();
                        NewItem.Add(new Ships());
                        NewItemInfo.ItemsSource = NewItem;
                        NewItemInfo.ItemTemplate = (DataTemplate)Application.Current.Resources["ShipsInsertTemplate"];
                    }
                    break;
            };
            NewItemInfo.Visibility = Visibility.Visible;

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            DatabaseHelper.InsertItem(NewItem.First(),_TableSelected, _TypeSelected);
            NewItemInfo.ItemsSource = null;
            NewItemInfo.Visibility = Visibility.Visible;
        }
    }
}
