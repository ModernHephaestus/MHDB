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
using System.ComponentModel;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MHDB.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        public Settings()
        {
            this.InitializeComponent();
        }
        private void RunReset(object sender, DoWorkEventArgs e)
        {
            DatabaseHelper.ResetDatabase();
        }
        private void ResetCompleted( object sender, RunWorkerCompletedEventArgs e)
        {
            ResetProgress.IsActive = false;
        }
        private void ResetDb_Click(object sender, RoutedEventArgs e)
        {
            
            ResetProgress.IsActive = true;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += RunReset;
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(ResetCompleted);
            worker.RunWorkerAsync();
        }
    }
}
