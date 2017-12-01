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
        private string _Item1 { get; set; } = "";
        private string _Item2 { get; set; } = "";
        private Pistols TestObject { get; set; } = new Pistols();

        private List<GenericHardware> DataContent { get; set; }
        public Data()
        {
            this.InitializeComponent();
        }
        private void CategoryClick(object sender, RoutedEventArgs e)
        {
            DatabaseHelper DbHelper = new DatabaseHelper();
            var SenderButton = (Button)sender;
            SelectTable.ItemsSource = DbHelper.FillTableList(SenderButton.Content.ToString());
            _TableSelected = SenderButton.Content.ToString();
            SelectTable.Visibility = Visibility.Visible;
        }
        private void SelectTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DatabaseHelper DbHelper = new DatabaseHelper();
                Info.ItemsSource = DbHelper.SelectTable(SelectTable.SelectedItem.ToString());
                _TypeSelected = SelectTable.SelectedItem.ToString();
            }
            catch
            {

            }
        }
        private void Item1_Click(object sender, RoutedEventArgs e)
        {
            Item1Text.Text = Info.SelectedValue.GetType().GetProperties().ToString();

        }

        private void Item2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Info_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ItemInfo = (SmallArms)e.ClickedItem;
            Item1Text.Text = ItemInfo.ModelName;
        }
    }
}
