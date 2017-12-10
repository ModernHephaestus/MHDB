using MHDB.Models.Data.HelicopterRotorcraft;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHDB.Models.Data
{
    internal class InitHelicopters
    {
        internal static void HelicoptersInit()
        {
            AddAttack.InitAttack();
            AddObservation.InitObservation();
            AddUtility.InitUtility();
        }
    }
}
