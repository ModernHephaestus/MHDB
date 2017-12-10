using MHDB.Models;
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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MHDB.Views
{
    /// <summary>
    /// A page where items can be deleted from the database;
    /// </summary>
    public sealed partial class Delete : Page
    {
        private string _TableSelected { get; set; }
        private string _TypeSelected { get; set; }
        private dynamic _Item1 { get; set; }

        public Delete()
        {
            this.InitializeComponent();
        }

        private void SelectLevel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ClickedItem = (TextBlock)e.ClickedItem;
            SelectTable.ItemsSource = DatabaseHelper.FillTableList(ClickedItem.Text);
            _TableSelected = ClickedItem.Text;
            Info.Visibility = Visibility.Collapsed;
            SelectTable.Visibility = Visibility.Visible;
        }

        private void SelectTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChangeInfoSource();
        }

        private void ChangeInfoSource()
        {
            try
            {
                Info.ItemsSource = DatabaseHelper.SelectTable(SelectTable.SelectedItem.ToString());
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
            if ((string)SelectedItem.Tag == "Empty")
            {
                SelectedItem.Text = ItemInfo.ModelName;
                _Item1 = ItemInfo;
                SelectedItem.Tag = "Filled";
            }

        }

        private void ItemPanel_ItemClick(object sender, ItemClickEventArgs e)
        {
            var Item = (TextBlock)e.ClickedItem;
            if (Item.Name == SelectedItem.Name)
            {
                SelectedItem.Tag = "Empty";
                _Item1 = null;
                SelectedItem.Text = "Item Selection Empty";
            }
            else if (Item.Name == DeleteSelected.Name)
            {
                if (_Item1 != null)
                {
                    DatabaseHelper.DeleteItem(_Item1);
                    SelectedItem.Tag = "Empty";
                    _Item1 = null;
                    SelectedItem.Text = "Item Selection Empty";
                    Info.SelectedIndex = -1;
                    ChangeInfoSource();
                }
            }
        }

    }
}
