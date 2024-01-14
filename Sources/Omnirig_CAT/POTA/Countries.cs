using ADMIN;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Omnirig_CAT.POTA
{
    internal class Countries
    {
        public class country
        {

            //countryCode	name	prefixRegex	prefix


            public string countryCode = "";
            public string countryName = "";

            public string prefixRegex = "";

            public List<string> prefixes;




            public country(string[] c)
            {

                //Poland;PL;POL;616;SP;3Z/HF/SN/SO/SP/SQ/SR


                if (c.Length > 0) countryCode = c[0].Trim().ToUpper();
                if (c.Length > 1) countryName = c[1].Trim();
                if (c.Length > 2) prefixRegex = c[2].Trim().ToUpper();
                if (c.Length > 3)
                {
                    prefixes = new List<string>();
                    string[] c2 = c[3].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string s in c2)
                    {
                        if (s.Length > 1) prefixes.Add(s);
                        else
                        {
                            prefixes.Add(s);
                            for (int i = 0; i < 10; i++) prefixes.Add(s + i.ToString()) ;
                        }
                    }
                }

            }




        }

        public static List<country> countryList = new List<country>();

      

        public static string getCountryCodeByCallSign(string callSign)
        {
            if (countryList != null && countryList.Count > 0 && !string.IsNullOrEmpty(callSign))
            {
                callSign = callSign.Trim().ToUpper();
                foreach (country country in countryList)
                {
                    if (country.prefixes != null)
                    {
                        foreach (string s in country.prefixes)
                        { 
                        if (callSign == s) return country.countryCode;
                        }
                    }
                }
                if (callSign.Length > 2)
                {
                    callSign = callSign.Substring(0, 2);
                    return getCountryCodeByCallSign(callSign);
                }


            }
            return "";
        }


        public static string getCountryNameByCallSign(string callSign)
        {
            if (countryList != null && countryList.Count > 0 && !string.IsNullOrEmpty(callSign))
            {
                callSign = callSign.Trim().ToUpper();
                foreach (country country in countryList)
                {
                    foreach (string s in country.prefixes)
                    {
                        if (callSign == s) return country.countryName;
                    }
                }
                if (callSign.Length > 2)
                {
                    callSign = callSign.Substring(0, 2);
                    return getCountryNameByCallSign(callSign);
                }
            }
            return callSign;
        }


        public static void Load()
        {
            try
            {
                if ((countryList == null || countryList.Count < 1) && File.Exists(PROCKI.exePathB + "countries.csv"))
                {
                    string[] countries = File.ReadAllLines(PROCKI.exePathB + "countries.csv");
                    if (countries != null && countries.Length > 0)
                    {
                        foreach (string country in countries)
                        {
                            //Agalega & St. Brandon;MU;MUS;480;;3B6/3B7
                            string[] c = country.Split(new char[] { ';' }, StringSplitOptions.None);
                            if (c != null && c.Length > 0)
                            {
                                countryList.Add(new Countries.country(c));
                            }
                        }
                    }

                }

            }
            catch { }
        }
    }
}
