using ADMIN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Omnirig_CAT.POTA
{
    internal class QRZ
    {
        public static volatile string userName = "";
        public static volatile string password = "";

        public static volatile string sect = "qrz";
        public static volatile string userKey = "";
        public static volatile string[] callSignData = new string[] { };

        public static volatile bool getExtendedInfo = false;
        public static volatile string queryCountryFlag;
        public static volatile string queryCountry;
        public static volatile string queryUserName;
        public static volatile bool querySuccesed;

        public static void LOAD()
        {
            userName = Config.ReadEncryptedValue(sect, "userName", "");
            password = Config.ReadEncryptedValue(sect, "password", "");
            getExtendedInfo = Config.ReadBoolValue(sect, "extInfo", false);
        }

        public static void SAVE(string _userName, string _password, bool extInfo)

        {
            userName = _userName;
            password = _password;
            getExtendedInfo = extInfo;
            SAVE();
        }

        private static void SAVE()
        {
            Config.WriteEncryptedValue(sect, "userName", userName);
            Config.WriteEncryptedValue(sect, "password", password);
            Config.WriteValue(sect, "extInfo", getExtendedInfo);
        }

        public static bool logIn()
        {
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password)) LOAD();
            return logIn(userName, password);
        }

        public static bool logIn(string _userName, string _password)
        {
            if (!getExtendedInfo) return true;
            if (!string.IsNullOrEmpty(_userName) && !string.IsNullOrEmpty(_password))
                try
                {
                    userKey = "";
                    string url = "http://xml.qrz.com/bin/xml?username=" + _userName + ";password=" + _password;
                    string x = HTTP.GET(url);
                    if (!string.IsNullOrEmpty(x))
                    {
                        x = x.Replace("\r", "").Trim();
                        string[] lines = x.Split('\n');
                        if (lines != null && lines.Length > 0)
                        {
                            foreach (string line in lines)
                            {
                                string nl = line.Trim().ToLower().Replace(" ", "");
                                if (nl.StartsWith("<key>", StringComparison.OrdinalIgnoreCase))
                                {
                                    userKey = nl.Replace("<key>", "").Replace("</key>", "");
                                    return true;
                                }

                            }


                        }

                    }
                }
                catch { }
            return false;
        }

        public static bool getCallsignData(string callSign, string otherRegion)
        {
            callSignData = new string[] { };


            getBaseInfo(callSign, otherRegion);



            if (getExtendedInfo)
            {
                try
                {
                    if (!string.IsNullOrEmpty(userKey))
                    {
                        string url = "http://xml.qrz.com/bin/xml?s=" + userKey + ";callsign=" + callSign;

                        string s = HTTP.GET(url).Replace("><", ">\r\n<");
                        if (!string.IsNullOrEmpty(s))
                        {
                            string q = "<Callsign>"; int idx = s.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                            if (idx > -1)
                                s = s.Substring(idx + q.Length);

                            q = "</Callsign>"; idx = s.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                            if (idx > -1)
                                s = s.Substring(0, idx);
                            s = s.Replace("\r", "");
                            callSignData = PROCKI.Split(s, "\n");

                            if (!string.IsNullOrEmpty(getCallSignElement("<error>")))
                            {
                                querySuccesed = false;
                                return false;
                            }
                            queryUserName = getCallSignElement("<fname>") + " " + getCallSignElement("<name>");
                            return true;

                        }
                    }
                }
                catch { }
            }

            return querySuccesed;




        }

        private static void getBaseInfo(string callSign, string otherRegion)
        {
            //BASE INFO WITH FLAGS
            string s = ADMIN.HTTP.GET("https://www.qrz.com/db/" + callSign);

            if (!string.IsNullOrEmpty(s))
            {

                string q = "<!-- begin calldata -->";
                int idx = s.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                if (idx > -1)
                    s = s.Substring(idx + q.Length);

                q = "<!-- end calldata -->";
                idx = s.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                if (idx > -1)
                    s = s.Substring(0, idx);

                s = s.Replace("\r", "").Replace("\n\n", "\n").Replace("\n\n", "\n").Trim();
                if (!string.IsNullOrEmpty(s))
                {
                    string[] lines = PROCKI.Split(s, "\n");
                    if (lines.Length > 0)
                    {
                        foreach (string line in lines)
                        {
                            if (!string.IsNullOrEmpty(line))
                            {
                                string currentLine = line.Trim();
                                string noSpacesLine = currentLine.Replace(" ", "").Trim();
                                q = "imgid=\"flg\"src=\""; idx = noSpacesLine.IndexOf(q, StringComparison.OrdinalIgnoreCase);

                                if (idx > -1) //FLAG IMAGE
                                {
                                    string flag = noSpacesLine.Substring(idx + q.Length);
                                    q = "\""; idx = flag.IndexOf(q);
                                    if (idx > -1)
                                    {
                                        flag = flag.Substring(0, idx).Trim();
                                        if (!string.IsNullOrEmpty(flag))
                                            queryCountryFlag = flag;
                                        try
                                        {
                                            string f = Path.GetFileName(queryCountryFlag);
                                            string fDir = PROCKI.exePathB + "FlagsCache";
                                            if (!Directory.Exists(fDir))
                                                Directory.CreateDirectory(fDir);

                                            string fn = PROCKI.addFolderSeparator(fDir) + f;
                                            if (!File.Exists(fn))
                                            {
                                                WebClient client = new WebClient();
                                                client.DownloadFile(new Uri(queryCountryFlag), fn);
                                            }
                                        }
                                        catch { }

                                        if (!string.IsNullOrEmpty(otherRegion))
                                        try
                                        {
                                                string f = Countries.getCountryCodeByCallSign( otherRegion) + ".png";
                                                string dir = Path.GetDirectoryName(queryCountryFlag);
                                            string fDir = PROCKI.exePathB + "FlagsCache";
                                            if (!Directory.Exists(fDir))
                                                Directory.CreateDirectory(fDir);

                                            string fn = PROCKI.addFolderSeparator(fDir) + f;
                                            if (!File.Exists(fn))
                                            {
                                                WebClient client = new WebClient();
                                                    //https://static.qrz.com/static/flags-iso/flat/32/BR.png
                                                    dir =  dir + "/" + f;
                                                    dir = dir.Replace("\\", "/").Replace("https:/", "https://").Replace("http:/", "http://");

                                                client.DownloadFile(new Uri(dir), fn);
                                            }
                                        }
                                        catch { }


                                    }
                                }

                                q = "position:relative;top:-8px;\">"; idx = currentLine.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                                if (idx > -1) //Country Name
                                {
                                    string country = currentLine.Substring(idx + q.Length);
                                    q = "<"; idx = country.IndexOf(q);
                                    if (idx > -1)
                                    {
                                        country = country.Substring(0, idx).Trim();
                                        if (!string.IsNullOrEmpty(country))
                                            queryCountry = country;
                                    }
                                }


                            }
                        }

                        queryUserName = "Login required ";
                        querySuccesed = true;
                    }

                }
            }
        }

        public static string getCallSignElement(string element)
        {
            element = element.ToLower().Trim();
            foreach (string s in callSignData)
            {
                string s3 = s.Trim();
                string s2 = s3.Replace(" ", "").ToLower();
                if (s2.StartsWith(element))
                {
                    string q = "</"; int idx = s3.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                    if (idx > -1)
                        s3 = s3.Substring(0, idx);

                    q = ">"; idx = s3.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                    if (idx > -1)
                        s3 = s3.Substring(idx + 1);
                    return s3;
                }

            }
            return "";
        }

        internal static string fieldToNiceName(string v)
        {
            v = v.Trim().ToLower();


            switch (v)
            {
                case "call": v = "Call Sign"; break;
                case "dxcc": v = "DX cc"; break;
                case "fname": v = "First Name"; break;
                case "name": v = "Last Name"; break;
                case "addr1": v = "Address 1"; break;
                case "addr2": v = "Address 2"; break;
                case "state": v = "State"; break;
                case "zip": v = "Zip code"; break;
                case "country": v = "Country"; break;
                case "lat": v = "Latitude"; break;
                case "lon": v = "Longitude"; break;
                case "grid": v = "Grid Square"; break;
                case "ccode": v = "CC code"; break;
                case "land": v = "Land"; break;
                case "class": v = "Class"; break;
                case "email": v = "Public Email"; break;
                case "u_views": v = "Lookups"; break;
                case "moddate": v = "Last Update"; break;
                case "cqzone": v = "CQ zone"; break;
                case "ituzone": v = "ITU zone"; break;
                case "locref": v = "Loc ref"; break;
                case "born": v = "Birth Year"; break;
                case "user": v = "User"; break;


                case "county": v = "County"; break;
                case "fips": v = "Fips"; break;

                case "efdate": v = "Ef date"; break;
                case "expdate": v = "Expired date"; break;
                case "p_call": v = "Previous Call"; break;

                case "codes": v = "Codes"; break;


                case "url": v = "URL"; break;
                case "views": v = "Views"; break;
                case "bio": v = "Bio"; break;
                case "image": v = "Image"; break;
                case "serial": v = "Serial"; break;

                case "msa": v = "MSA"; break;
                case "areacode": v = "Area Code"; break;
                case "timezone": v = "Time Zone"; break;
                case "gmtoffset": v = "GMT Offset"; break;
                case "dst": v = "DST"; break;
                case "eqsl": v = "e QSL"; break;
                case "mqsl": v = "mail QSL"; break;
                case "qslmgr": v = "QSL manager"; break;



            }

            return v;

        }
    }
}
