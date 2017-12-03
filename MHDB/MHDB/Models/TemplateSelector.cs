using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MHDB.Models.DatabaseItems;
namespace MHDB.Models
{
    internal class TemplateSelector : DataTemplateSelector
    {
        public DataTemplate SmallArmsTemplate { get; set; }
        public DataTemplate ArtilleryTemplate { get; set; }
        public DataTemplate VehiclesTemplate { get; set; }
        public DataTemplate AircraftTemplate { get; set; }
        public DataTemplate HelicopterTemplate { get; set; }
        public DataTemplate ShipsTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is SmallArms)
                return SmallArmsTemplate;
            if (item is Artillery)
                return ArtilleryTemplate;
            if (item is Vehicles)
                return VehiclesTemplate;
            if (item is FixedWingAircraft)
                return AircraftTemplate;
            if (item is HelicopterRotorcraft)
                return HelicopterTemplate;
            if (item is Ships)
                return ShipsTemplate;
            return base.SelectTemplateCore(item, container);
        }
    }
}
