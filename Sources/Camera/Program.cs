using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CAT_CAMERA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            UDPClient.UDP_ENABLED = false;
            if (args != null && args.Length > 0 && args[0].StartsWith("/UDP:"))
            {
                string p = args[0].Replace("/UDP:", "").Trim();
                int i = -1;
                if (int.TryParse(p, out i))
                {
                    UDPClient.UDP_PORT = i;
                    UDPClient.UDP_ENABLED = true;
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Camera());
        }
    }
}