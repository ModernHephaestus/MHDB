using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MHDB.Models.Data.SmallArms;
using MHDB.Models.Data.Artillery;
using MHDB.Models.Data.Vehicles;
using MHDB.Models.Data.FixedWingAircraft;
using MHDB.Models.Data.HelicopterRotorcraft;
using MHDB.Models.Data.Ships;
namespace MHDB.Models.Data
{
    internal class InitializeData
    {
        public static void InitializeDatabase()
        {
            //SmallArms
            AddAntiMaterial.InitAntiMaterial();
            AddDMRSniperRifles.InitDMRSniperRifles();
            AddMachineGuns.InitMachineGuns();
            AddPistols.InitPistols();
            AddRiflesAndCarbines.InitRiflesAndCarbines();
            AddShotguns.InitShotguns();
            AddSubmachineGuns.InitSubmachineGuns();
            //Artillery
            AddAirDefense.InitAirDefense();
            AddHowitzers.InitHowitzers();
            AddMortars.InitMortars();
            //AddRocketArtillery.InitRocketArtillery();
            //Vehicles
            AddAPCs.InitAPCs();
            AddIFVs.InitIFVs();
            AddTanks.InitTanks();
            AddTrucks.InitTrucks();
            //FixeWingAircraft
            AddBomber.InitBomber();
            AddCommandAndControl.InitCommandAndControl();
            AddFighter.InitFighter();
            AddGroundAttack.InitGroundAttack();
            AddGunship.InitGunship();
            AddTransport.InitTransport();
            AddUAV.InitUAV();
            //HelicopterRotorcraft
            AddAttack.InitAttack();
            AddObservation.InitObservation();
            AddUtility.InitUtility();
            //Ships
            AddAircraftCarriers.InitAircraftCarriers();
            AddAmphibiousWarfare.InitAmphibiousWarfare();
            AddCruisers.InitCruisers();
            AddDestroyers.InitDestroyers();
            AddFrigates.InitFrigates();
            AddSubmarines.InitSubmarines();
        }
    }
}
