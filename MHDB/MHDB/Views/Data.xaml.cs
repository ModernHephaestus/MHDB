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
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MHDB.Views
{
    /// <summary>
    /// Page where you view and select which pieces of hardware you want to compare.
    /// </summary>
    public sealed partial class Data : Page
    {
        private string _TableSelected {get; set;}
        private string _TypeSelected { get; set; }
        private object _Item1 { get; set; }
        private object _Item2 { get; set; }
        private Pistols TestObject { get; set; } = new Pistols();

        private List<GenericHardware> DataContent { get; set; }
        public Data()
        {
            this.InitializeComponent();
        }

        private void SelectLevel_ItemClick(object sender, ItemClickEventArgs e)
        {
            DatabaseHelper DbHelper = new DatabaseHelper();
            var ClickedItem = (TextBlock)e.ClickedItem;
            SelectTable.ItemsSource = DbHelper.FillTableList(ClickedItem.Text);
            _TableSelected = ClickedItem.Text;
            ClearSelected();
            Info.Visibility = Visibility.Collapsed;
            SelectTable.Visibility = Visibility.Visible;
        }

        

        private void SelectTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DatabaseHelper DbHelper = new DatabaseHelper();
                Info.ItemsSource = DbHelper.SelectTable(SelectTable.SelectedItem.ToString());
                Info.Visibility = Visibility.Visible;
                _TypeSelected = SelectTable.SelectedItem.ToString();
            }
            catch
            {

            }
        }
        private void Info_ItemClick(object sender, ItemClickEventArgs e)
        {
            dynamic ItemInfo = (GenericHardware)e.ClickedItem;
            switch (_TableSelected)
            {
                case "SmallArms":
                    {
                        ItemInfo = (SmallArms)e.ClickedItem;
                    }
                    break;
                case "Artillery":
                    {
                        ItemInfo = (Artillery)e.ClickedItem;
                    }
                    break;
                case "Vehicles":
                    {
                        ItemInfo = (Vehicles)e.ClickedItem;
                    }
                    break;
                case "FixedWingAircraft":
                    {
                        ItemInfo = (FixedWingAircraft)e.ClickedItem;
                    }
                    break;
                case "HelicopterRotorcraft":
                    {
                        ItemInfo = (HelicopterRotorcraft)e.ClickedItem;
                    }
                    break;
                case "Ships":
                    {
                        ItemInfo = (Ships)e.ClickedItem;
                    }
                    break;
            };
            if((string)SelectedItem1.Tag == "Empty")
            {
                SelectedItem1.Text = ItemInfo.ModelName;
                _Item1 = ItemInfo;
                SelectedItem1.Tag = "Filled";
            }
            else if ((string)SelectedItem2.Tag == "Empty")
            {
                SelectedItem2.Text = ItemInfo.ModelName;
                _Item2 = ItemInfo;
                SelectedItem2.Tag = "Filled";
            }
        }

        private void ItemPanel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Item = (TextBlock)e.ClickedItem;
            if (Item.Name == SelectedItem1.Name)
            {
                SelectedItem1.Tag = "Empty";
                _Item1 = null;
                SelectedItem1.Text = "Item 1 Selection Empty";
            }
            else if (Item.Name == SelectedItem2.Name)
            {
                _Item2 = null;
                SelectedItem2.Tag = "Empty";
                SelectedItem2.Text = "Item 2 Selection Empty";
            }
            else if (Item.Name == ClearSelections.Name)
            {
                ClearSelected();
            }
            else
            {
                Dictionary<string, object> dictionary = new Dictionary<string, object>
                {
                    { "Item1", _Item1 },
                    { "Item2", _Item2 },
                    { "Type", _TypeSelected },
                    { "Table", _TableSelected }
                };
                Frame.Navigate(typeof(Compare), dictionary);
            }
        }

        private void ClearSelected()
        {
            _Item1 = null;
            _Item2 = null;
            SelectedItem1.Tag = "Empty";
            SelectedItem1.Text = "Item 1 Selection Empty";
            SelectedItem2.Tag = "Empty";
            SelectedItem2.Text = "Item 2 Selection Empty";
        }
    }
}
