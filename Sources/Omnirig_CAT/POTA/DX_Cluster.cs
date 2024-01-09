using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Omnirig_CAT.POTA
{
    public class dxCluster
    {
        public class dxJson
        {

            public string info;//": "FT8 -09db >Tnx 73!",
            public string dx_country;//": "United States",
            public string de_latitude;//": 52.77, 
            public string de_longitude;//": 1.47,
            public string dx_latitude;//": 31.85, 
            public string dx_longitude;//": 96.3, 
            public string de_call;//": "M7AWF",  --- spotter
            public string frequency;//": 7074.0, 
            public string time;//": "2024-01-09T08:23:48",
            public string dx_call;//": "W5AJ",    ---- callsign

            public string id;//": 61264178},


        }

        public static dxJson fillSpot(string[] elements)
        {
            dxJson dx = new dxJson();

            foreach (string element in elements)
            {
                if (element.IndexOf(":") > -1)
                {
                    string[] el = element.Split(':');
                    if (el.Length > 1)
                    {
                        string n = el[0].ToLower().Trim();
                        string val = el[1].Trim();
                        switch (n)
                        {

                            case "info": dx.info = val; break;

                            case "dx_country": dx.dx_country = val; break;
                            case "de_latitude": dx.de_latitude = val; break;
                            case "dx_latitude": dx.dx_latitude = val; break;
                            case "dx_longitude": dx.dx_longitude = val; break;
                            case "de_call": dx.de_call = val; break;
                            case "frequency": dx.frequency = val; break;
                            case "time": dx.time = val; if (el.Length > 2) dx.time += ":" + el[2]; dx.time = dx.time.Replace("T", " "); break;
                            case "dx_call": dx.dx_call = val; break;
                            case "de_longitude": dx.de_longitude = val; break;
                            case "id": dx.id = val; break;



                        }


                    }
                }

            }
            if (!string.IsNullOrEmpty(dx.info))
                dx.info = dx.info.Replace("null", " ");
            else
                dx.info = "";

            return dx;
        }



        public static List<dxJson> dxList;
        public static bool DeserializeSPOT_JSON(string JSON)
        {
            dxList = new List<dxJson>();
            string[] s = JSON.Replace("[", "").Replace("]", "").Split(new string[] { "}," }, StringSplitOptions.RemoveEmptyEntries);
            //  JsonSerializerSettings js =new JsonSerializerSettings();
            //2024-01-07T10:47:41"
            //   js.DateFormatString = "'yyyy'-'MM'-'dd'T'HH':'mm':'ss'";
            if (s != null && s.Length > 0)
            {
                foreach (string s2 in s)
                {
                    if (!string.IsNullOrEmpty(s2))
                    {
                        string s3 = s2.Replace("{", "").Replace("}", "").Replace("\"", "").Replace("\r", "").Replace(",", "").Trim();

                        string[] elements = s3.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                        dxList.Add(fillSpot(elements));
                    }
                }


            }
            return dxList != null && dxList.Count > 0;
        }
    }
}
