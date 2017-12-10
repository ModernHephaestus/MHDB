using MHDB.Models.Data.Artillery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHDB.Models.Data
{
    internal class InitArtillery
    {
        internal static void ArtilleryInit()
        {
            AddAirDefense.InitAirDefense();
            AddHowitzers.InitHowitzers();
            AddMortars.InitMortars();
        }
    }
}
