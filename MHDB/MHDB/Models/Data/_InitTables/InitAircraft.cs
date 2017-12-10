using MHDB.Models.Data.FixedWingAircraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHDB.Models.Data
{
    internal class InitAircraft
    {
        internal static void AircraftInit()
        {
            AddBomber.InitBomber();
            AddCommandAndControl.InitCommandAndControl();
            AddFighter.InitFighter();
            AddGroundAttack.InitGroundAttack();
            AddGunship.InitGunship();
            AddTransport.InitTransport();
            AddUAV.InitUAV();
        }
    }
}
