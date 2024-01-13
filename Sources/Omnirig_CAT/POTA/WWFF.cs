using ADMIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Omnirig_CAT.POTA
{
    public class WWFF
    {
        public class spotWWFF
        {

            public string dateTime;
            public string frequency;
            public string callSign;
            public string WWFF;
            public string Notes;
            public string Locator;
            public string Latitude;
            public string Longitude;
            public string TITLE;
            public string spotter;
            public string comments;



        }


        public static spotWWFF fillSpot(string[] elements)
        {
            spotWWFF spot = new spotWWFF();

            foreach (string element in elements)
            {
                if (element.IndexOf(":") > -1)
                {
                    string[] el = element.Split(':');
                    if (el.Length > 1)
                    {
                        string n = el[0].ToLower().Trim();
                        string val = el[1].Trim();
                        if (val == "null") val = "";
                        switch (n)
                        {

                            
                            case "datetime": spot.dateTime = val; if (el.Length > 2) spot.dateTime += ":" + el[2]; break;
                            case "frequency": spot.frequency = val; break;
                            case "callsign": spot.callSign = val; break;
                            case "wwff": spot.WWFF = val; break;
                            case "notes": spot.Notes = val; break;
                            case "locator": spot.Locator = val; break;
                            case "latitude": spot.Latitude = val; break;
                            case "longitude": spot.Longitude = val; break;
                            case "title": spot.TITLE = val; break;
                            case "spotter": spot.spotter = val; break;
                            case "comments": spot.comments = val; break;

                        }


                    }
                }

            }


            return spot;
        }



        public static List<spotWWFF> spotList;
        public static bool DeserializeWWFF_html(string html)
        {
            spotList = new List<spotWWFF>();
            html = html.Replace("\r", "").Replace("\n", "\r\n").Trim();

            html = html.Replace("\r\n\r\n", "\r\n"); html = html.Replace("\r\n\r\n", "\r\n").Replace("< ", "<").Replace(" >", "");
            html = html.Replace("< ", "<").Replace(" >", "").Replace("</tr>\r\n<tr>", "\r\n#NEXT#\r\n").Replace("#NEXT#\r\n\r\n<td class=tt1>", "").Replace("\t", "");

            //       string[] elements = html.Split(new string[] { "<td class=spot_lt", "<td class=spot_dt" }, StringSplitOptions.RemoveEmptyEntries);
            string[] elements = html.Split(new string[] { "#NEXT#" }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < elements.Length; i++) elements[i] = clearHTMLTags(elements[i]);

            string s = "";

            foreach (string el in elements)
            {

                string se = el;
                s += se.Replace("\r\n", "") + "\n";
            }



            elements = s.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < elements.Length; i++)
            {
                string[] el = PROCKI.Split(fixElement(elements[i]), "\r\n");

                spotList.Add(fillSpot(el));
            }


           /* s = "";
            foreach (string el in elements)
            {

                s += el + "\r\n";

            }*/

            return spotList != null && spotList.Count > 0;
        }

        private static string trymuj(string row)
        {
            if (row.IndexOf("'") > -1) row = row.Substring(0, row.IndexOf("'")).Trim();
            return row;
        }

        private static string fixElement(string v)
        {
            v = v.Replace("<", "\r\n").Replace(">", "").Replace("\r\n\r\n", "\r\n");
            v = v.Replace("<>", "");

            v = v.Replace("WWFF \r\n", "\r\nWWFF:");
            v = v.Replace("Notes \r\n", "\r\nNotes:");
            v = v.Replace("Locator \r\n", "\r\nLocator:");
            v = v.Replace("Latitude \r\n", "\r\nLatitude:");
            v = v.Replace("Longitude \r\n", "\r\nLongitude:");
            v = v.Replace(", TITLE,'", "\r\nTITLE:");
            v = v.Replace("\r\n\r\n", "\r\n");
            v = v.Replace("\r\n \r\n", "\r\n");
            if (v.StartsWith("\r\n")) v = v.Substring(2);
            v = v.Replace("TITLE:LINK-INFO'", "").Replace("_lt width=45", "").Replace("_lt width=40", "").Replace("_dt width=45", "").Replace("_dt width=40", "");
            v = v.Replace("f=0&c=", "\r\n").Replace(" \r\n", "\r\n").Replace("\r\n ", "\r\n");
            v = v.Replace(";", "").Replace("&#10143", "").Replace("\r\n0\r\n", "\r\n");
            // v = v.Replace(" onmouseover", "\r\nonmouseover");
            v = v.Trim();

            string[] el = v.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            v = "";
            for (int i = 0; i < el.Length; i++)
            {
                el[i] = el[i].Trim();
                if (el[i].StartsWith("img")) el[i] = "";
                if (el[i].StartsWith("a href")) el[i] = "";
                if (el[i].IndexOf("onmouseover") > 0) el[i] = "";
                if (el[i].StartsWith("width=")) el[i] = "";
                if (el[i].IndexOf("width=") > -1)
                {
                    el[i] = removeBspace(el[i]);
                }
                if (el[i].IndexOf("width=") > -1)
                {
                    el[i] = removeBspace(el[i]);
                }


                if (el[i] != "") v += el[i] + "\r\n";
            }

            el = v.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            if (el != null && el.Length > 10)
            {

                v = "dateTime:" + toDate(el[0].ToUpper()) + " " + toTime(el[1]) + "\r\n";
                v += "frequency:" + trymuj(el[2]) + "\r\n";
                v += "callSign:" + removeAspace(trymuj(el[3])) + "\r\n";

                v += trymuj(el[4]) + "\r\n";
                v += trymuj(el[5]) + "\r\n";
                v += trymuj(el[6]) + "\r\n";
                v += trymuj(el[7]) + "\r\n";
                v += trymuj(el[8]) + "\r\n";
                v += trymuj(el[9]) + "\r\n";
                if (el.Length < 12)
                {
                    v += "spotter:" + removeAspace(trymuj(el[10])) + "\r\n";
                    v += "comments:" + removeBspace(trymuj(el[10])) + "\r\n";
                }
                else
                {
                    v += "spotter:" + trymuj(el[10]) + "\r\n";
                    v += "comments:" + trymuj(el[11]) + "\r\n";
                }


            }

            return v;
        }

        private static string removeAspace(string v)
        {
            if (v.IndexOf(" ") > 0)
            {
                return v.Substring(0, v.IndexOf(" ")).Trim();
            }
            return v;
        }

        private static string removeBspace(string v)
        {
            if (v.IndexOf(" ") > 0)
            {
                return v.Substring(v.IndexOf(" ")).Trim();
            }
            return v;
        }

        private static string toTime(string v)
        {
            if (v.Length == 4) return v[0] + "" + v[1] + ":" + v[2] + "" + v[3];
            else
                return v;

        }

        private static string toDate(string v)
        {
            int day = 0;
            int month = 0;
            int year = DateTime.Now.Year;
            string[] mths = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };

            for (int i = 0; i < mths.Length; i++) { if (v.IndexOf(mths[i]) > -1) { month = i + 1; break; } }

            if (v.IndexOf(" ") > 0)
            {
                string d = v.Substring(0, v.IndexOf(" ")).Trim();
                if (!string.IsNullOrEmpty(d))
                {
                    int dd = -1;
                    if (int.TryParse(d, out dd))
                    { day = dd; }
                }

                v = v.Substring(v.IndexOf(" ")).Trim();

                if (v.IndexOf(" ") > 0)
                {
                    string y = v.Substring(v.IndexOf(" ")).Trim();
                    int yy = -1;
                    if (int.TryParse(y, out yy))
                    { year = yy; }
                }



            }
            if (day != 0 && month != 0 && year != 0)
            {
                return year.ToString() + "-" + PROCKI.twoDigit(month) + "-" + PROCKI.twoDigit(day);
            }
            else
                return v;
        }

        private static string[] tags =
        {
            "<b>","</b>","</a>","</td>","</tr>","<tr>","<nobr>","</table>","</nobr>","target=_blank","class=spot","colspan=1","align=center","align=left",
            "<td class=ttmap1","width=22","width=90","width=10","font face=sans-serif","&t=dx onmouseover="," on Reverse Beacon Net', TITLE,'LINK-INFO'",", ABOVE, true, FADEOUT, 400, CENTERMOUSE,true);\"","&t=dx",
            "align=right","td class=tt1","table width='100%'","td","table bgcolor=darkgrey"," class=ttmap2 "," _lt2 width=45 "," _lt2 width=40 "," class=ttmap1 width=70","TITLE:LINK-INFO'","&Map"
        };

        private static string clearHTMLTags(string v)
        {
            foreach (string tag in tags) { v = v.Replace(tag, ""); }
            while (v.IndexOf("\r\n\r\n") > -1)
                v = v.Replace("\r\n\r\n", "\r\n");

            v = v.Replace("&nbsp;", " ");

            while (v.IndexOf("  ") > -1)
                v = v.Replace("  ", " ");

            return v;
        }
    }
}
