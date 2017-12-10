using MHDB.Models.DatabaseItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
namespace MHDB.Models.Data
{
    class AddItems
    {

        internal static void AddSA(DatabaseItems.SmallArms Item, string SType)
        {
            using (var db = new DatabaseContext())
            {
                
                switch (SType)
                {
                    case "AntiMaterial":
                        AntiMaterial tempAM = new AntiMaterial();
                        foreach(PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempAM, x.GetValue(Item));
                        }
                        db.SmallArms.Add(tempAM);
                        break;
                    case "DMRSniperRifles":
                        DMRSniperRifles tempDSR = new DMRSniperRifles();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempDSR, x.GetValue(Item));
                        }
                        db.SmallArms.Add(tempDSR);
                        break;
                    case "MachineGuns":
                        MachineGuns tempMG = new MachineGuns();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempMG, x.GetValue(Item));
                        }
                        db.SmallArms.Add(tempMG);
                        break;
                    case "Pistols":
                        Pistols tempP = new Pistols();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempP, x.GetValue(Item));
                        }
                        db.SmallArms.Add(tempP);
                        break;
                    case "RiflesAndCarbines":
                        RiflesAndCarbines tempRAC = new RiflesAndCarbines();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempRAC, x.GetValue(Item));
                        }
                        db.SmallArms.Add(tempRAC);
                        break;
                    case "Shotguns":
                        Shotguns tempSh = new Shotguns();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempSh, x.GetValue(Item));
                        }
                        db.SmallArms.Add(tempSh);
                        break;
                    case "SubmachineGuns":
                        SubmachineGuns tempSMG = new SubmachineGuns();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempSMG, x.GetValue(Item));
                        }
                        db.SmallArms.Add(tempSMG);
                        break;
                }
                db.SaveChanges();
            }
        }

        internal static void AddArt(object Item, string SType)
        {
            using (var db = new DatabaseContext())
            {

                switch (SType)
                {
                    case "AirDefense":
                        AirDefense tempAD = new AirDefense();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempAD, x.GetValue(Item));
                        }
                        db.Artillery.Add(tempAD);
                        break;
                    case "Howitzers":
                        Howitzers tempH = new Howitzers();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempH, x.GetValue(Item));
                        }
                        db.Artillery.Add(tempH);
                        break;
                    case "Mortars":
                        Mortars tempM = new Mortars();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempM, x.GetValue(Item));
                        }
                        db.Artillery.Add(tempM);
                        break;
                    
                }
                db.SaveChanges();

            }
        }

        internal static void AddVeh(object Item, string SType)
        {
            using (var db = new DatabaseContext())
            {

                switch (SType)
                {
                    case "APCs":
                        APCs tempA = new APCs();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempA, x.GetValue(Item));
                        }
                        db.Vehicles.Add(tempA);
                        break;
                    case "IFVs":
                        IFVs tempI = new IFVs();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempI, x.GetValue(Item));
                        }
                        db.Vehicles.Add(tempI);
                        break;
                    case "Tanks":
                        Tanks tempTa = new Tanks();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempTa, x.GetValue(Item));
                        }
                        db.Vehicles.Add(tempTa);
                        break;
                    case "Trucks":
                        Trucks tempTr = new Trucks();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempTr, x.GetValue(Item));
                        }
                        db.Vehicles.Add(tempTr);
                        break;

                }
                db.SaveChanges();

            }
        }

        internal static void AddFWA(object Item, string SType)
        {
            using (var db = new DatabaseContext())
            {

                switch (SType)
                {
                    case "Bomber":
                        Bomber tempB = new Bomber();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempB, x.GetValue(Item));
                        }
                        db.FixedWingAircraft.Add(tempB);
                        break;
                    case "CommandAndControl":
                        CommandAndControl tempCAC = new CommandAndControl();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempCAC, x.GetValue(Item));
                        }
                        db.FixedWingAircraft.Add(tempCAC);
                        break;
                    case "Fighter":
                        Fighter tempF = new Fighter();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempF, x.GetValue(Item));
                        }
                        db.FixedWingAircraft.Add(tempF);
                        break;
                    case "GroundAttack":
                        GroundAttack tempGA = new GroundAttack();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempGA, x.GetValue(Item));
                        }
                        db.FixedWingAircraft.Add(tempGA);
                        break;
                    case "Gunship":
                        Gunship tempG = new Gunship();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempG, x.GetValue(Item));
                        }
                        db.FixedWingAircraft.Add(tempG);
                        break;
                    case "Transport":
                        Transport tempT = new Transport();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempT, x.GetValue(Item));
                        }
                        db.FixedWingAircraft.Add(tempT);
                        break;
                    case "UAV":
                        Transport tempU = new Transport();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempU, x.GetValue(Item));
                        }
                        db.FixedWingAircraft.Add(tempU);
                        break;

                }
                db.SaveChanges();

            }
        }

        internal static void AddHR(object Item, string SType)
        {
            using (var db = new DatabaseContext())
            {

                switch (SType)
                {
                    case "Attack":
                        Attack tempA = new Attack();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempA, x.GetValue(Item));
                        }
                        db.HelicopterRotorcraft.Add(tempA);
                        break;
                    case "Observation":
                        Observation tempO = new Observation();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempO, x.GetValue(Item));
                        }
                        db.HelicopterRotorcraft.Add(tempO);
                        break;
                    case "Utility":
                        Utility tempU = new Utility();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempU, x.GetValue(Item));
                        }
                        db.HelicopterRotorcraft.Add(tempU);
                        break;
                }
                db.SaveChanges();

            }
        }

        internal static void AddSh(object Item, string SType)
        {
            using (var db = new DatabaseContext())
            {

                switch (SType)
                {
                    case "AircraftCarriers":
                        AircraftCarriers tempAC = new AircraftCarriers();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempAC, x.GetValue(Item));
                        }
                        db.Ships.Add(tempAC);
                        break;
                    case "AmphibiousWarfare":
                        AmphibiousWarfare tempAW = new AmphibiousWarfare();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempAW, x.GetValue(Item));
                        }
                        db.Ships.Add(tempAW);
                        break;
                    case "Cruisers":
                        Cruisers tempC = new Cruisers();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempC, x.GetValue(Item));
                        }
                        db.Ships.Add(tempC);
                        break;
                    case "Destroyers":
                        Destroyers tempD = new Destroyers();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempD, x.GetValue(Item));
                        }
                        db.Ships.Add(tempD);
                        break;
                    case "Frigates":
                        Frigates tempF = new Frigates();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempF, x.GetValue(Item));
                        }
                        db.Ships.Add(tempF);
                        break;
                    case "Submarines":
                        Submarines tempS = new Submarines();
                        foreach (PropertyInfo x in Item.GetType().GetProperties())
                        {
                            x.SetValue(tempS, x.GetValue(Item));
                        }
                        db.Ships.Add(tempS);
                        break;
                }
                db.SaveChanges();

            }
        }
    }
}
