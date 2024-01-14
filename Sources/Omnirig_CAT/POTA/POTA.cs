
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using static Omnirig_CAT.POTA.AlertSOTA;


namespace Omnirig_CAT.POTA
{
    public class SpotPOTA
    {
        public class spotJson
        {

            public string spotId;
            public string activator;
            public string frequency;
            public string mode;
            public string reference;
            public string parkName;
            public string spotTime;
            public string spotter;
            public string comments;
            public string source;
            public string invalid;
            public string name;
            public string locationDesc;
            public string grid4;
            public string grid6;
            public string latitude;
            public string longitude;
            public string count;
            public string expire;

            private string country;
          
            public string getCountryName
            {
                get
                {
                    if (string.IsNullOrEmpty(country))
                    {
                       
                            country=Countries.getCountryNameByCallSign(activator);
                       

                    }
                    return country;
                }
            }


        }

        public static spotJson fillSpot(string[] elements)
        {
            spotJson spot = new spotJson();

            foreach (string element in elements)
            {
                if (element.IndexOf(":") > -1)
                {
                    string[] el = element.Split(':');
                    if (el.Length > 1)
                    {
                        string n = el[0].ToLower().Trim();
                        string val = el[1].Trim();
                        if (el.Length > 2)
                        {
                            for (int i = 2; i < el.Length; i++) val += ":" + el[i];
                        }
                        if (val.EndsWith(","))
                            val = val.Substring(0, val.Length - 1);
                        if (val == "null") val = "";
                        switch (n)
                        {

                            case "spotid": spot.spotId = val; break;
                            case "activator": spot.activator = val; break;
                            case "frequency": spot.frequency = val; break;
                            case "mode": spot.mode = val; break;
                            case "reference": spot.reference = val; break;
                            case "parkname": spot.parkName = val; break;
                            case "spottime": spot.spotTime = val.Replace("T", " "); break;
                            case "spotter": spot.spotter = val; break;
                            case "comments": spot.comments = val; break;
                            case "source": spot.source = val; break;
                            case "invalid": spot.invalid = val; break;
                            case "name": spot.name = val; break;
                            case "locationdesc": spot.locationDesc = val; break;
                            case "grid4": spot.grid4 = val; break;
                            case "grid6": spot.grid6 = val; break;
                            case "latitude": spot.latitude = val; break;
                            case "longitude": spot.longitude = val; break;
                            case "count": spot.count = val; break;
                            case "expire": spot.expire = val; break;


                        }


                    }
                }

            }


            return spot;
        }


        public static string getLocation(spotJson sj)
        {
            if (sj == null) return "";
            if (!string.IsNullOrEmpty(sj.grid6)) return sj.grid6;
            return sj.grid4;

        }


        public static List<spotJson> spotList;
        public static bool DeserializeSPOT_JSON(string JSON)
        {
           
            spotList = new List<spotJson>();
            JSON = "\n" + JSON.Replace("[", "").Replace("]", "").Replace("\r", "").Replace(",\n", "\n").Replace("\"", "");
            string[] s = JSON.Split(new string[] { "\n{" }, StringSplitOptions.RemoveEmptyEntries);
            if (s != null && s.Length > 0)
            {
                foreach (string s2 in s)
                {
                    string sa = s2.Trim();
                    if (!string.IsNullOrEmpty(sa) && sa.EndsWith("}"))
                        sa = sa.Substring(0, sa.Length - 1);

                    if (!string.IsNullOrEmpty(sa))
                    {
                        string[] elements = sa.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);


                        spotList.Add(fillSpot(elements));
                    }
                }


            }
            return spotList != null && spotList.Count > 0;
        }
    }


    public class ActivationPOTA
    {
        public class activationJson
        {
            public string scheduledActivitiesId;
            public string schedulerUserId;
            public string activator;
            public string name;
            public string reference;
            public string locationDesc;
            public string activityStart;
            public string activityEnd;
            public string startDate;
            public string endDate;
            public string startTime;
            public string endTime;
            public string frequencies;
            public string comments;

            private string country;
            public string getCountryName
            {
                get
                {
                    if (string.IsNullOrEmpty(country))
                    {

                        country = Countries.getCountryNameByCallSign(activator);

                    }
                    return country;
                }
            }

        }


        public static activationJson fillActivation(string[] elements)
        {
            activationJson activation = new activationJson();

            foreach (string element in elements)
            {
                if (element.IndexOf(":") > -1)
                {
                    string[] el = element.Split(':');
                    if (el.Length > 1)
                    {
                        string n = el[0].ToLower().Trim();
                        string val = el[1].Trim();
                        if (el.Length > 2)
                        {
                            for (int i = 2; i < el.Length; i++) val += ":" + el[i];
                        }
                        if (val.EndsWith(","))
                            val = val.Substring(0, val.Length - 1);
                        if (val == "null") val = "";
                        switch (n)
                        {

                            case "scheduledactivitiesid": activation.scheduledActivitiesId = val; break;
                            case "scheduleruserid": activation.schedulerUserId = val; break;
                            case "activator": activation.activator = val; break;
                            case "name": activation.name = val; break;
                            case "reference": activation.reference = val; break;
                            case "locationdesc": activation.locationDesc = val; break;
                            case "activitystart": activation.activityStart = val; break;
                            case "activityend": activation.activityEnd = val; break;
                            case "startdate": activation.startDate = val; break;
                            case "enddate": activation.endDate = val; break;
                            case "starttime": activation.startTime = val.Replace("T", " "); break;
                            case "endtime": activation.endTime = val.Replace("T", " "); break;
                            case "frequencies": activation.frequencies = val; break;
                            case "comments": activation.comments = val; break;


                        }


                    }
                }

            }


            return activation;
        }



        public static List<activationJson> activationList;
        public static bool DeserializeACTIVATION_JSON(string JSON)
        {
            activationList = new List<activationJson>();
            JSON = "\n" + JSON.Replace("[", "").Replace("]", "").Replace("\r", "").Replace(",\n", "\n").Replace("\"", "");
            string[] s = JSON.Split(new string[] { "\n{" }, StringSplitOptions.RemoveEmptyEntries);
            if (s != null && s.Length > 0)
            {
                foreach (string s2 in s)
                {
                    string sa = s2.Trim();
                    if (!string.IsNullOrEmpty(sa) && sa.EndsWith("}"))
                        sa = sa.Substring(0, sa.Length - 1);

                    if (!string.IsNullOrEmpty(sa))
                    {
                        string[] elements = sa.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                        activationList.Add(fillActivation(elements));
                    }
                }


            }
            return activationList != null && activationList.Count > 0;
        }
    }
}
