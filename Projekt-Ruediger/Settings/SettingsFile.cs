using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Ruediger.Settings
{
    class SettingsFile
    {
        public static void ReadFile()
        {
            string filePath = "./Settings.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Es gibt keine Settingsdatei.");
                //Datei erstellen (Provisorisch)
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine("");
                return;
            }
            StreamReader sr = new StreamReader(filePath);
            string line = "";
            while ((line = sr.ReadLine()) != null)
            {
                string[] splittedData = line.Split('=', (char)2);
                switch (splittedData[0].Trim())
                {
                    case "MaxSaveAmount":
                        if (!SaveData.SetMaxSaveAmount(splittedData[1]))
                        {
                            MessageBox.Show("Die Datei enthält Fehler");
                            return;
                        }
                        break;
                }
            }
        }
    }
}
