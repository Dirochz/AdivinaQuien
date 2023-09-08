using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinaQuien.Metodos
{
    internal class Version7
    {
        public string NombreJson(int num) 
        {
            string path = "C:\\AdivinaQuien\\" + Properties.Settings.Default.version + "\\Config.json";
            string json = File.ReadAllText(path);
            JObject obj = JObject.Parse(json);
            string Json = string.Empty;
            switch (num)
            {
                case 1:
                    Json = (string)obj["Carta1"]["nombre"];
                    break;

                case 2:
                    Json = (string)obj["Carta2"]["nombre"];
                    break;

                case 3:
                    Json = (string)obj["Carta3"]["nombre"];
                    break;

                case 4:
                    Json = (string)obj["Carta4"]["nombre"];
                    break;

                case 5:
                    Json = (string)obj["Carta5"]["nombre"];
                    break;

                case 6:
                    Json = (string)obj["Carta6"]["nombre"];
                    break;

                case 7:
                    Json = (string)obj["Carta7"]["nombre"];
                    break;

                case 8:
                    Json = (string)obj["Carta8"]["nombre"];
                    break;

                case 9:
                    Json = (string)obj["Carta9"]["nombre"];
                    break;

                case 10:
                    Json = (string)obj["Carta10"]["nombre"];
                    break;
            }
            return Json;
        }
        
        public string InfoJson(int num) 
        {
            string path = "C:\\AdivinaQuien\\" + Properties.Settings.Default.version + "\\Config.json";
            string json = File.ReadAllText(path);
            JObject obj = JObject.Parse(json);
            string Json = string.Empty;
            switch (num)
            {
                case 1:
                    Json = NombreJson(1) + ": " + (string)obj["Carta1"]["Info"];
                    break;

                case 2:
                    Json = NombreJson(2) + ": " + (string)obj["Carta2"]["Info"];
                    break;

                case 3:
                    Json = NombreJson(3) + ": " + (string)obj["Carta3"]["Info"];
                    break;

                case 4:
                    Json = NombreJson(4) + ": " + (string)obj["Carta4"]["Info"];
                    break;

                case 5:
                    Json = NombreJson(5) + ": " + (string)obj["Carta5"]["Info"];
                    break;

                case 6:
                    Json = NombreJson(6) + ": " + (string)obj["Carta6"]["Info"];
                    break;

                case 7:
                    Json = NombreJson(7) + ": " + (string)obj["Carta7"]["Info"];
                    break;

                case 8:
                    Json = NombreJson(8) + ": " + (string)obj["Carta8"]["Info"];
                    break;

                case 9:
                    Json = NombreJson(9) + ": " + (string)obj["Carta9"]["Info"];
                    break;

                case 10:
                    Json = NombreJson(10) + ": " + (string)obj["Carta10"]["Info"];
                    break;
            }
            return Json;
        }
    }
}
