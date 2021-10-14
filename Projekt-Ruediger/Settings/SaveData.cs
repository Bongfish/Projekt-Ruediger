using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_Ruediger.Settings
{
    class SaveData
    {
        public static int MaxSaveData { get; private set; } = 0;

        public static bool SetMaxSaveAmount(string Amount)
        {
            if (!int.TryParse(Amount, out int x))
            {
                return false;
            }
            MaxSaveData = Convert.ToInt32(Amount);
            return true;
        }
    }
}
