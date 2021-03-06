﻿using MHDB.Models.DatabaseItems;
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
        private dynamic _PassedItem1 { get; set; }
        private dynamic _PassedItem2 { get; set; }
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
            _PassedItem1 = DataDictionary.ElementAt(0).Value;
            _PassedItem2 = DataDictionary.ElementAt(1).Value;
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
                            (SmallArms)_PassedItem1,
                            (SmallArms)_PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["SmallArmsTemplate"];
                    }
                    break;
                case "Artillery":
                    {
                        ObservableCollection<Artillery> ComparedItems = new ObservableCollection<Artillery>
                        {
                            (Artillery)_PassedItem1,
                            (Artillery)_PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["ArtilleryTemplate"];
                    }
                    break;
                case "Vehicles":
                    {
                        ObservableCollection<Vehicles> ComparedItems = new ObservableCollection<Vehicles>
                        {
                            (Vehicles)_PassedItem1,
                            (Vehicles)_PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;

                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["VehiclesTemplate"];
                    }
                    break;
                case "Aircraft":
                    {
                        ObservableCollection<FixedWingAircraft> ComparedItems = new ObservableCollection<FixedWingAircraft>
                        {
                            (FixedWingAircraft)_PassedItem1,
                            (FixedWingAircraft)_PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["AircraftTemplate"];
                    }
                    break;
                case "Helicopters":
                    {
                        ObservableCollection<HelicopterRotorcraft> ComparedItems = new ObservableCollection<HelicopterRotorcraft>
                        {
                            (HelicopterRotorcraft)_PassedItem1,
                            (HelicopterRotorcraft)_PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["AircraftTemplate"];
                    }
                    break;
                case "Ships":
                    {
                        ObservableCollection<Ships> ComparedItems = new ObservableCollection<Ships>
                        {
                            (Ships)_PassedItem1,
                            (Ships)_PassedItem2
                        };
                        ItemView.ItemsSource = ComparedItems;
                        ItemView.ItemTemplate = (DataTemplate)Application.Current.Resources["ShipsTemplate"];
                    }
                    break;
            }
        }

        private void CompareBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_PassedItem1 > _PassedItem2)
            {
                Winner.Text += _PassedItem1.ModelName;
                Description.Text = "The 1st item averages higher than the 2nd!";
            }
            else
            {
                Winner.Text += _PassedItem2.ModelName;
                Description.Text = "The 2nd item averages higher than the 1st!";
            }
        }
        
    }
}
