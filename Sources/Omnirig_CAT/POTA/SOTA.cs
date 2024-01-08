using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnirig_CAT.POTA
{
    public class SpotSOTA
    {
        public class spotJson
        {

            public string id;
            public string userID;
            public string timeStamp;
            public string comments;
            public string callsign;
            public string associationCode;
            public string summitCode;
            public string activatorCallsign;
            public string activatorName;
            public string frequency;
            public string mode;
            public string summitDetails;
            public string highlightColor;



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
                        switch (n)
                        {


                            case "id": spot.id = val; break;
                            case "userid": spot.userID = val; break;
                            case "timestamp": spot.timeStamp = val; if (el.Length > 2) spot.timeStamp += ":" + el[2]; spot.timeStamp = spot.timeStamp.Replace("T", " "); break;
                            case "comments": spot.comments = val; break;
                            case "callsign": spot.callsign = val; break;
                            case "associationcode": spot.associationCode = val; break;
                            case "summitcode": spot.summitCode = val; break;
                            case "activatorcallsign": spot.activatorCallsign = val; break;
                            case "activatorname": spot.activatorName = val; break;
                            case "frequency": spot.frequency = val; break;
                            case "mode": spot.mode = val; break;
                            case "summitdetails": spot.summitDetails = val; break;
                            case "highlightcolor": spot.highlightColor = val; break;


                        }


                    }
                }

            }


            return spot;
        }





        public static List<spotJson> spotList;
        public static bool DeserializeSPOT_JSON(string JSON)
        {
            spotList = new List<spotJson>();
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

                        spotList.Add(fillSpot(elements));
                    }
                }


            }
            return spotList != null && spotList.Count > 0;
        }
    }


    public class AlertSOTA
    {
        public class alertJson
        {
            public string id;
            public string userID;
            public string timeStamp;
            public string dateActivated;
            public string associationCode;
            public string summitCode;
            public string summitDetails;
            public string posterCallsign;
            public string activatingCallsign;
            public string activatorName;
            public string frequency;
            public string comments;
        }


        public static alertJson fillActivation(string[] elements)
        {
            alertJson alert = new alertJson();

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
                            case "id": alert.id = val; break;
                            case "userid": alert.userID = val; break;
                            case "timestamp": alert.timeStamp = val; if (el.Length > 2) alert.timeStamp += ":" + el[2]; alert.timeStamp = alert.timeStamp.Replace("T", " "); break;
                            case "dateactivated": alert.dateActivated = val; break;
                            case "associationcode": alert.associationCode = val; break;
                            case "summitcode": alert.summitCode = val; break;
                            case "summitdetails": alert.summitDetails = val; break;
                            case "postercallsign": alert.posterCallsign = val; break;
                            case "activatingcallsign": alert.activatingCallsign = val; break;
                            case "activatorname": alert.activatorName = val; break;
                            case "frequency": alert.frequency = val; break;
                            case "comments": alert.comments = val; break;






                        }


                    }
                }

            }


            return alert;
        }



        public static List<alertJson> alertList;
        public static bool DeserializeACTIVATION_JSON(string JSON)
        {
            alertList = new List<alertJson>();
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

                        alertList.Add(fillActivation(elements));
                    }
                }


            }
            return alertList != null && alertList.Count > 0;
        }
    }
}
