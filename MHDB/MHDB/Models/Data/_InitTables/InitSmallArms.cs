using MHDB.Models.Data.SmallArms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHDB.Models.Data
{
    internal class InitSmallArms
    {
        internal static void SmallArmsInit()
        {
            AddAntiMaterial.InitAntiMaterial();
            AddDMRSniperRifles.InitDMRSniperRifles();
            AddMachineGuns.InitMachineGuns();
            AddPistols.InitPistols();
            AddRiflesAndCarbines.InitRiflesAndCarbines();
            AddShotguns.InitShotguns();
            AddSubmachineGuns.InitSubmachineGuns();
        }
    }
}
