using MHDB.Models.DatabaseItems;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MHDB.Views
{
    /// <summary>
    /// This page compares the two pices of hardwars sent from the Data page.
    /// </summary>
    public sealed partial class Compare : Page
    {
        private object PassedItem1 { get; set; }
        private object PassedItem2 { get; set; }
        private string _PassedType { get; set; }
        private string _PassedTable { get; set; }
        public Compare()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        { 
            
            if (e.Parameter == null)
            {
                return;
            }
            var DataDictionary = (Dictionary<string , object>)e.Parameter;
            PassedItem1 = DataDictionary.ElementAt(0).Value;
            PassedItem2 = DataDictionary.ElementAt(1).Value;
            _PassedType = DataDictionary.ElementAt(2).Value.ToString();
            _PassedTable = DataDictionary.ElementAt(3).Value.ToString();
            InitCompare();
        }
        private void InitCompare()
        {
            switch (_PassedTable)
            {
                case "Small Arms":
                    {
                        ObservableCollection<SmallArms> ComparedItems = new ObservableCollection<SmallArms>
                        {
                            (SmallArms)PassedItem1,
                            (SmallArms)PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["SmallArmsTemplate"];
                    }
                    break;
                case "Artillery":
                    {
                        ObservableCollection<Artillery> ComparedItems = new ObservableCollection<Artillery>
                        {
                            (Artillery)PassedItem1,
                            (Artillery)PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["ArtilleryTemplate"];
                    }
                    break;
                case "Vehicles":
                    {
                        ObservableCollection<Vehicles> ComparedItems = new ObservableCollection<Vehicles>
                        {
                            (Vehicles)PassedItem1,
                            (Vehicles)PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;

                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["VehiclesTemplate"];
                    }
                    break;
                case "Aircraft":
                    {
                        ObservableCollection<FixedWingAircraft> ComparedItems = new ObservableCollection<FixedWingAircraft>
                        {
                            (FixedWingAircraft)PassedItem1,
                            (FixedWingAircraft)PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["AircraftTemplate"];
                    }
                    break;
                case "Helicopters":
                    {
                        ObservableCollection<HelicopterRotorcraft> ComparedItems = new ObservableCollection<HelicopterRotorcraft>
                        {
                            (HelicopterRotorcraft)PassedItem1,
                            (HelicopterRotorcraft)PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["AircraftTemplate"];
                    }
                    break;
                case "Ships":
                    {
                        ObservableCollection<Ships> ComparedItems = new ObservableCollection<Ships>
                        {
                            (Ships)PassedItem1,
                            (Ships)PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["ShipsTemplate"];
                    }
                    break;
            }
        }
    }
}
