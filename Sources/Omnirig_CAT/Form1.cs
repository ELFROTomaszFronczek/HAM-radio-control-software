﻿using ADMIN;
using OmniRig;
using POTA_To_CAT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnirig_CAT
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            ADMIN.INIT.MinPassLength = 4;    // minimalna długość haseł
            ADMIN.INIT.AllowSaveFormSize = true;   // zezwalaj na zapis położenia i wielkości okien

            /// <summary>
            /// Zainicjiuj parametry programu
            /// </summary>
            /// ADMIN.INIT.WIN10_BIG_FONTS_FIX();
            ADMIN.INIT.USELogs = true;      /// Używaj systemu logowania
            ADMIN.INIT.USEConfig = true;    /// Używaj pliku konfiguracyjnego
            ADMIN.INIT.RunWithWindows = true;  ///Uruchamiaj program z windowsem
            ADMIN.INIT.RunMinimizedToTray = false; ///Uruchamiaj program w postaci zminimalizowanej
            ADMIN.INIT.MinimizeToTray = false;  ///Minimalizuj do traya
            ADMIN.INIT.WaitAfterRun = 0;    // po uruchomieniu programu czekaj xxx sekund na załadowanie usług

            ADMIN.INIT.IsConfigEncrypted = false;   /// Czy plik konfiguracynjy ma byc zakodowany ?
            ADMIN.INIT.AllowConfigNotEncrypted = true;  /// Zezwalaj na niezakodowany plik konfiguracyjny mimo że powinien byc zakodowany - program może odczytać konfig zapisany zwykłym tekstem ale gdy zostanie zapisany będzie już zakodowany
            ADMIN.INIT.CatchCriticalException = true;   /// W przypadku błędów krytycznych wyświetl własne okno z błędem zamiast standartowego
            ADMIN.INIT.autoClose = false;       /// Zamykaj automatycznie okna 
            ADMIN.INIT.autoCloseTime = 4;        /// >Czas automatycznego zamknięcia okna w sekundach
            ADMIN.INIT.customMessageBoxes = true;       /// True - własny styl message boxów false -Systemowe
            ADMIN.INIT.messageBoxesToLog = true;        /// Zapisuj okienka dialogowe do logu

            ADMIN.INIT.UseDB = false;                   // false - program nie uzywa baz danych

            ADMIN.INIT.splashHeader = "ELFRO";       // nagłowek w ADMIN.INIT screenie
            ADMIN.INIT.splashProgramName = "CATControl";       // nazwa programu w ADMIN.INIT screenie
            ADMIN.INIT.splashAdditionalInfo = "";       // dodatkowy opis progrmu
            ADMIN.INIT.splashCopyright = "©'2023 Tomasz Fronczek";  // stopka w ADMIN.INIT screenie

            ADMIN.INIT.disablePremamentUseDB = true;
            ADMIN.INIT.disablePremamentToTray = true;
            // ADMIN.INIT.MaxSteps = 5;     // ile kroków inicjalizacji nie używać
            ADMIN.INIT.stepsSpeed = 50; // co ile ms kolejny krok inicjalizacji

            ADMIN.INIT.preventMultiRuns = true;


            ADMIN.INIT.MinimizeToTray = true;
            ADMIN.INIT.RunMinimizedToTray = true;

            INIT.WIN10_BIG_FONTS_FIX();
            INIT.CatchCriticalException = true;
            Log.logSubFolder = @"LOGS\LOG_CATControl";
            Config.FileName = @"CONFIGS\Config_CATControl.ini";
            Config.ifBadFileName1 = "Config_CATControl.ini";
            Config.ifBadFileName2 = "";
            new ADMIN.Splash(false).fastInit();

            InitializeComponent();
        }

        OmniRig.OmniRigX omniRigEngine;
        private bool rig1;
        RigX currentRig;

        string sect = "cfg";

        long lastFreq = -1;
        private bool inClicked = false;
        private int t2Cntr;
        long frequency = -11;

        int skipTimer = 0;

        int freqDelta = 0;
        private bool loading = true;

        bool tx = false;
        private bool inBand;
        private bool inMode;

        int longPanel2Width;
        int txDelta;


        long transponderOffset = 0;


        public delegate void OmnirigDelegate(int RigNumber, object Command, object Reply);
        public OmnirigDelegate OminRigDel;


        private int UDP_PORT = 5432;
        UDPServer udp;

        public delegate void MyDelegate(string msg);
        public MyDelegate del;

        int lv = 100;


        POTA_To_CAT.FormPOTA pota;

        public bool VFO_A { get; private set; }

        private string vfo;
        private int timerReadYaesuCntr = -1;
        private Font fontBold;
        private Font fontRegular;

        int sx, sy, lx, ly;
        bool dwn = false;
        //  private volatile bool stopWorker = false;

        private void Form1_Load(object sender, EventArgs e)
        {


            buttonHide_Click(null, null);

            longPanel2Width = panel2.Width;
            txDelta = buttonTX.Left - panel2.Right;
            hideInTaskBarToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "hideInTaskBar", false);
            alwaysOnTopToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "onTop", false);
            tXOnCharToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "txOnChar", false);
            tXOnlyWhenPressedToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "txWhenPressed", true);
            onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "chngModeOnBandChng", false);
            runCameraModuleToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "runCameraModule", false);
            runNTPTimeSyncOnStartToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "runNTPModule", false);
            displayToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "display12Digit", false);

            workWithTransponderToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "workWithTransponder", false);

            string s = Config.ReadValue(sect, "transponderOffset", "0");
            if (!long.TryParse(s, out transponderOffset)) transponderOffset = 0;
            transponderOfffsetToolStripMenuItem.Text = "Transponder offset: " + transponderOffset + " Hz";

            bool openPota = Config.ReadBoolValue(sect, "potaShow", false);
            if (openPota) pOTAModuleToolStripMenuItem_Click(null, null);


            UDP_PORT = Config.ReadIntValue(sect, "UDP_PORT", UDP_PORT);


            vFOAMainToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "VFOA", true);
            vFOBSubToolStripMenuItem.Checked = !vFOAMainToolStripMenuItem.Checked;
            VFO_A = vFOAMainToolStripMenuItem.Checked;
            setVfo();


            if (runCameraModuleToolStripMenuItem.Checked)
            {
                runCameraModuleNowToolStripMenuItem_Click(null, null);
            }

            hideWindowHeaderToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "hideBar", hideWindowHeaderToolStripMenuItem.Checked);
            hideWindowHeaderToolStripMenuItem_Click(null, null);

            hideInTaskBarToolStripMenuItem_Click(null, null);
            alwaysOnTopToolStripMenuItem_Click(null, null);

            displayToolStripMenuItem_Click(null, null);

            Application.DoEvents();
            PROCKI.loadFormSizeAndLog(this);

            showDoplerEffectModuleToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "dopplerVisible", false);
            int v;
            v = Config.ReadIntValue(sect, "dopplerFrequency", 0);
            if (v > 100) v = 100;
            if (v < -100) v = -100;
            trackBarDopplerFrequency.Value = v;

            v = Config.ReadIntValue(sect, "dopplerTime", 100);
            if (v < 100) v = 100;
            if (v > 1000) v = 1000;
            trackBarDopplerTime.Value = v;

            Application.DoEvents();
            if (showDoplerEffectModuleToolStripMenuItem.Checked)
                showDoplerEffectModuleToolStripMenuItem_Click(null, null);

            Application.DoEvents();
            omniRigEngine = new OmniRigX();
            omniRigEngine.CustomReply += OmniRigEngine_CustomReply;

            rig1 = Config.ReadBoolValue(sect, "rig1", true);

            if (OminRigDel == null)
            {
                OminRigDel = new OmnirigDelegate(OmnirigGetCommand);

            }
            fontBold = new Font(offAntenaTunerToolStripMenuItem.Font, FontStyle.Bold);
            fontRegular = new Font(offAntenaTunerToolStripMenuItem.Font, FontStyle.Regular);


            if (rig1)
            {
                currentRig = omniRigEngine.Rig1;
                selectRig1ToolStripMenuItem.Checked = true;
                selectRig2ToolStripMenuItem.Checked = false;
            }
            else
            {
                currentRig = omniRigEngine.Rig2;
                selectRig1ToolStripMenuItem.Checked = false;
                selectRig2ToolStripMenuItem.Checked = true;
            }




            Application.DoEvents();
            timerGetFrequency.Start();
            labelRig.Text = currentRig.RigType;

            s0.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s1.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s2.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s3.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s4.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s5.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s6.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s7.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s8.MouseWheel += new MouseEventHandler(s0_MouseWheel);

            s9.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s10.MouseWheel += new MouseEventHandler(s0_MouseWheel);
            s11.MouseWheel += new MouseEventHandler(s0_MouseWheel);

            loading = false;
            configureControlUDPPortToolStripMenuItem.Text += UDP_PORT;





            timerNTP.Start();

        }

        bool closed = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            timerDoppler.Stop();
            //stopWorker = true;
            Application.DoEvents();

            try
            {

                if (runCameraModuleToolStripMenuItem.Checked)
                {
                    Process[] p = Process.GetProcessesByName("CAT_CAMERA");
                    if (p != null || p.Length > 0)
                    {

                        foreach (Process proc in p)
                        {

                            proc.Kill();
                        }
                    }


                }
            }

            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }

            try
            {
                timerGetFrequency.Stop();
                timer2.Stop();
                Application.DoEvents();
                stopTX();
                Application.DoEvents();



            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
            PROCKI.saveFormSizeAndLog(this);

            SAVE(); closed = true;
         
            INIT.UNLOAD();
        }

        private void SAVE()
        {
            try
            {
                if (loading || closed) return;
                Config.WriteValue(sect, "hideInTaskBar", hideInTaskBarToolStripMenuItem.Checked);
                Config.WriteValue(sect, "onTop", alwaysOnTopToolStripMenuItem.Checked);
                Config.WriteValue(sect, "rig1", rig1);

                Config.WriteValue(sect, "txOnChar", tXOnCharToolStripMenuItem.Checked);
                Config.WriteValue(sect, "txWhenPressed", tXOnlyWhenPressedToolStripMenuItem.Checked);

                Config.WriteValue(sect, "chngModeOnBandChng", onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Checked);
                Config.WriteValue(sect, "hideBar", hideWindowHeaderToolStripMenuItem.Checked);
                Config.WriteValue(sect, "runCameraModule", runCameraModuleToolStripMenuItem.Checked);
                Config.WriteValue(sect, "UDP_PORT", UDP_PORT);


                Config.WriteValue(sect, "runNTPModule", runNTPTimeSyncOnStartToolStripMenuItem.Checked);
                Config.WriteValue(sect, "display12Digit", displayToolStripMenuItem.Checked);

                Config.WriteValue(sect, "workWithTransponder", workWithTransponderToolStripMenuItem.Checked);

                Config.WriteValue(sect, "transponderOffset", transponderOffset);

                Config.WriteValue(sect, "dopplerVisible", showDoplerEffectModuleToolStripMenuItem.Checked);

                Config.WriteValue(sect, "dopplerFrequency", trackBarDopplerFrequency.Value);
                Config.WriteValue(sect, "dopplerTime", trackBarDopplerTime.Value);

                bool ps = true;
                if (pota == null | FormPOTA.isClosed) ps=false;

                Config.WriteValue(sect, "potaShow", ps);
                Config.ReadBoolValue(sect, "VFOA", vFOAMainToolStripMenuItem.Checked);


                Config.WriteConfig();
            }
            catch { }
        }



        private void startUDP_SERVER()
        {
            if (del == null || udp == null)
            {
                del = new MyDelegate(receiveUDP_Camera);

                udp = new UDPServer();
                udp.Initialize(this, del, UDP_PORT);
                udp.StartMessageLoop();
            }


        }


        private void receiveUDP_Camera(string msg)
        {
            inClicked = true;
            if (msg == "UP") { frequency += 1000; }
            if (msg == "DOWN") { frequency -= 1000; }
            writeFrequency();
            inClicked = false;

        }


        long getFrequency()
        {
            if (VFO_A) return currentRig.FreqA;
            else return currentRig.FreqB;
        }


        private void timerGetFrequency_Tick(object sender, EventArgs e)
        {
            try
            {
                if (inClicked) return;
                if (skipTimer > 0)
                {
                    skipTimer--;
                    return;
                }
                if (!workWithTransponderToolStripMenuItem.Checked)
                {
                    frequency = getFrequency();
                }
                else
                {
                    frequency = getFrequency() + transponderOffset;
                }


                labelMode.Text = niceString(currentRig.Mode);//.ToString();

                showFreq();
                if (!inBand) selectBand();
                if (!inMode) SelectMode();
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }


        }

        private void SelectMode()
        {
            try
            {
                inMode = true;
                int nx = 0;
                for (int i = 0; i < comboBoxMode.Items.Count; i++)
                {
                    if (comboBoxMode.Items[i].ToString() == labelMode.Text) nx = i;
                }
                comboBoxMode.SelectedIndex = nx;
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
            inMode = false;
        }

        private void selectBand()
        {
            try
            {
                inBand = true;
                long fk = frequency / 1000;

                int nBand = 0;
                switch (fk)
                {

                    case long i when i >= 1810 && i <= 2000: nBand = 1; break;
                    case long i when i >= 3500 && i <= 3800: nBand = 2; break;
                    case long i when i >= 5351 && i <= 5367: nBand = 3; break;
                    case long i when i >= 7000 && i <= 7200: nBand = 4; break;
                    case long i when i >= 10100 && i <= 10150: nBand = 5; break;
                    case long i when i >= 14000 && i <= 14350: nBand = 6; break;
                    case long i when i >= 18068 && i <= 18168: nBand = 7; break;
                    case long i when i >= 21000 && i <= 21450: nBand = 8; break;
                    case long i when i >= 24890 && i <= 24990: nBand = 9; break;

                    case long i when i >= 28000 && i <= 29700: nBand = 10; break;
                    case long i when i >= 50000 && i <= 50500: nBand = 11; break;
                    case long i when i >= 70000 && i <= 70300: nBand = 12; break;

                    case long i when i >= 144000 && i <= 146000: nBand = 13; break;
                    case long i when i >= 430000 && i <= 440000: nBand = 14; break;
                    default: nBand = 0; break;
                }
                if (nBand != comboBoxBand.SelectedIndex) comboBoxBand.SelectedIndex = nBand;
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }

            inBand = false;
        }

        private void showFreq()
        {
            try
            {
                if (lastFreq != frequency)
                {
                    lastFreq = frequency;
                    string s = frequency.ToString();
                    sDot.Visible = !(s.Length < 4);

                    while (s.Length < 12) { s = "*" + s; }
                    s0.Value = s[11].ToString();
                    s1.Value = s[10].ToString();
                    s2.Value = s[9].ToString();
                    s3.Value = s[8].ToString();
                    s4.Value = s[7].ToString();
                    s5.Value = s[6].ToString();
                    s6.Value = s[5].ToString();
                    s7.Value = s[4].ToString();
                    s8.Value = s[3].ToString();
                    s9.Value = s[2].ToString();
                    s10.Value = s[1].ToString();
                    s11.Value = s[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
        }

        private string niceString(RigParamX mode)
        {
            string s = mode.ToString().Replace("PM_", "").Replace("_L", " LSB").Replace("_U", " USB").Replace('_', ' ');
            return s;
        }


        private void button500_Click(object sender, EventArgs e)
        {
            inClicked = true;
            frequency = ((frequency / 1000) * 1000) + 500;
            writeFrequency();
            inClicked = false;
        }


        private void button000_Click(object sender, EventArgs e)
        {
            inClicked = true;
            frequency = (frequency / 1000) * 1000;
            writeFrequency();
            inClicked = false;

        }

        void writeVFO(long freq)
        {
            if (VFO_A) currentRig.FreqA = (int)freq;
            else
                currentRig.FreqB = (int)freq;
        }

        private void writeFrequency()
        {
            try
            {
                if (frequency < 1000) frequency = 1000;
                if (frequency > 999999999999) frequency = 999999999999;

                if (!workWithTransponderToolStripMenuItem.Checked)
                {
                    writeVFO(frequency);
                }

                else
                {
                    long fq = frequency - transponderOffset;
                    //currentRig.FreqA = (int)fq;
                    writeVFO(fq);
                }

                showFreq();
                skipTimer = 2;
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
        }


        private void startT2()
        {
            t2Cntr = 0;
            timer2.Interval = 500;
            timer2.Start();
            timer2_Tick(null, null);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (freqDelta == 0)
            {
                timer2.Stop(); return;
            }
            if (t2Cntr < 10) t2Cntr++;
            if (t2Cntr == 1) timer2.Interval = 400;
            if (t2Cntr == 2) timer2.Interval = 300;
            if (t2Cntr == 3) timer2.Interval = 200;
            if (t2Cntr == 4) timer2.Interval = 100;

            inClicked = true;
            // freqDelta = int.Parse(((Button)sender).Tag.ToString());
            frequency = frequency + freqDelta;
            writeFrequency();
            inClicked = false;
            timer2.Start();
        }


        private void stopT2()
        {
            timer2.Stop(); freqDelta = 0; t2Cntr = 0;
        }

        private void s1_MouseDown(object sender, MouseEventArgs e)
        {

            inClicked = true;
            int i = int.Parse(((SevenSegment)sender).Tag.ToString());

            if (e.Button == MouseButtons.Left) { freqDelta = i; }
            if (e.Button == MouseButtons.Right) { freqDelta = -i; }

            inClicked = false;
            startT2();
        }

        private void s1_MouseUp(object sender, MouseEventArgs e)
        {
            stopT2();
        }


        private void s0_MouseWheel(object sender, MouseEventArgs e)
        {
            int d = e.Delta;
            inClicked = true;
            // SevenSegment s = (SevenSegment)sender;
            //  if (s.Value == "*") s.Value = "0";
            //int i = int.Parse(s.Value);
            long i = long.Parse(((SevenSegment)sender).Tag.ToString());

            if (d > 0) { frequency += i; }
            if (d < 0) { frequency -= i; }
            // s.Value = i.ToString();
            writeFrequency();
            inClicked = false;

        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dwn)
            {
                int dx = sx - MousePosition.X;
                int dy = sy - MousePosition.Y;

                this.Left = lx - dx;
                this.Top = ly - dy;
            }

        }


        private void comboBoxBand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inBand) return;
            inClicked = true;
            if (comboBoxBand.SelectedIndex < 1) return;
            RigParamX mode = RigParamX.PM_SSB_U;
            bool chng = false;
            switch (comboBoxBand.SelectedIndex)
            {
                case 1: frequency = 1850000; mode = RigParamX.PM_SSB_L; chng = true; break;
                case 2: frequency = 3722000; mode = RigParamX.PM_SSB_L; chng = true; break;
                case 3: frequency = 5360000; mode = RigParamX.PM_SSB_L; chng = true; break;
                case 4: frequency = 7100000; mode = RigParamX.PM_SSB_L; chng = true; break;
                case 5: frequency = 10120000; chng = true; break;
                case 6: frequency = 14200000; chng = true; break;
                case 7: frequency = 18150000; chng = true; break;
                case 8: frequency = 21300000; chng = true; break;
                case 9: frequency = 24960000; chng = true; break;

                case 10: frequency = 29000000; chng = true; break;
                case 11: frequency = 50300000; chng = true; break;

                case 12: frequency = 70260000; chng = true; break;
                case 13: frequency = 145000000; chng = true; break;
                case 14: frequency = 435000000; chng = true; break;


            }

            //  comboBox1.SelectedIndex = 0;
            if (chng)
            {
                writeFrequency();
                if (onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Checked && niceString(mode) != labelMode.Text) currentRig.Mode = mode;
            }
            inClicked = false;
        }

        private void comboBoxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (inMode) return;
                RigParamX mode = RigParamX.PM_SSB_L;

                switch (comboBoxMode.SelectedIndex)
                {
                    case 1: mode = RigParamX.PM_CW_L; break;
                    case 2: mode = RigParamX.PM_CW_U; break;
                    case 3: mode = RigParamX.PM_SSB_L; break;
                    case 4: mode = RigParamX.PM_SSB_U; break;
                    case 5: mode = RigParamX.PM_DIG_L; break;
                    case 6: mode = RigParamX.PM_DIG_U; break;
                    case 7: mode = RigParamX.PM_AM; break;
                    case 8: mode = RigParamX.PM_FM; break;
                }
                currentRig.Mode = mode;
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
        }




        private void selectRig1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentRig = omniRigEngine.Rig1;
                selectRig1ToolStripMenuItem.Checked = true;
                selectRig2ToolStripMenuItem.Checked = false;
                rig1 = true;
                labelRig.Text = currentRig.RigType; SAVE();
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
        }

        private void selectRig2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                currentRig = omniRigEngine.Rig2;
                selectRig1ToolStripMenuItem.Checked = false;
                selectRig2ToolStripMenuItem.Checked = true;
                rig1 = false;
                labelRig.Text = currentRig.RigType; SAVE();
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
        }




        private void buttonTX_Click(object sender, EventArgs e)
        {
            if (tXOnlyWhenPressedToolStripMenuItem.Checked) return;
            tx = !tx;
            if (tx) startTX();
            else
                stopTX();

        }

        private void stopTX()
        {
            try
            {
                tx = false;
                currentRig.Tx = RigParamX.PM_RX;
                buttonTX.BackColor = Color.Green;
                timerStopTx.Stop();
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
        }

        void startTX()
        {
            try
            {
                tx = true;
                currentRig.Tx = RigParamX.PM_TX;
                buttonTX.BackColor = Color.Red;
                timerStopTx.Start();
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
                labelErr.Visible = true;
            }
        }

        private void timerStopTx_Tick(object sender, EventArgs e)
        {
            stopTX();

        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = alwaysOnTopToolStripMenuItem.Checked; SAVE();
        }

        private void hideInTaskBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = !hideInTaskBarToolStripMenuItem.Checked; SAVE();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void buttonTX_MouseDown(object sender, MouseEventArgs e)
        {
            if (!tXOnlyWhenPressedToolStripMenuItem.Checked) return;
            startTX();
        }

        private void buttonTX_MouseUp(object sender, MouseEventArgs e)
        {
            if (!tXOnlyWhenPressedToolStripMenuItem.Checked) return;
            stopTX();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tXOnCharToolStripMenuItem.Checked && e.KeyCode == Keys.Oem5)
                startTX();

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (tXOnCharToolStripMenuItem.Checked && e.KeyCode == Keys.Oem5)
                stopTX();
        }

        private void comboBoxBand_DropDown(object sender, EventArgs e)
        {
            inBand = true;
        }

        private void comboBoxBand_DropDownClosed(object sender, EventArgs e)
        {
            inBand = false;
        }

        private void comboBoxMode_DropDown(object sender, EventArgs e)
        {
            inMode = true;
        }

        private void comboBoxMode_DropDownClosed(object sender, EventArgs e)
        {
            inMode = false;
        }

        private void labelErr_Click(object sender, EventArgs e)
        {
            labelErr.Visible = false;
        }

        private void hideWindowHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hideWindowHeaderToolStripMenuItem.Checked)
            {
                if (MinimumSize.Width > ClientRectangle.Width || MinimumSize.Height > ClientRectangle.Height)
                {
                    MinimumSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
                }
                FormBorderStyle = FormBorderStyle.None;
            }
            else
                FormBorderStyle = FormBorderStyle.Sizable;
            SAVE();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Form || sender is Panel || sender is Label)
            {

                sx = MousePosition.X;
                sy = MousePosition.Y;
                lx = Left;
                ly = Top;
                dwn = true;
            }
        }


        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dwn = false;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            dwn = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void configureControlUDPPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = -1;
            if (InputBox.ShowDialog("Enter UDP Port", "Enter UDP Port", UDP_PORT.ToString(), 1, 65535, out i) == DialogResult.OK)
            {

                UDP_PORT = i;
            }
        }


        private bool IsRunAsAdmin()
        {
            WindowsIdentity id = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(id);

            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }

        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!displayToolStripMenuItem.Checked)
            {

                panel2.Width = longPanel2Width - s9.Right;

            }
            else
            {
                panel2.Width = longPanel2Width;

            }
            Application.DoEvents();
            button000.Left = button500.Left = panel2.Right + 6;
            labelMode.Left = panel2.Right - labelMode.Width;
            comboBoxMode.Left = panel2.Right - comboBoxMode.Width;
            Application.DoEvents();
            label3.Left = comboBoxMode.Left - label3.Width - 6;
            //int txDelta2 = buttonTX.Left - button000.Right;

            Application.DoEvents();


            MinimumSize = new Size(panel2.Right + txDelta + buttonTX.Width + 6, MinimumSize.Height);
            Width = MinimumSize.Width;
            // Width = panel2.Right + txDelta;


        }

        private void transponderOfffsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string i = transponderOffset.ToString();
            if (InputBox.ShowDialog("Enter Transponder Offset in Hz", "Enter Transponder Offset in Hz", i, out i, false, false) == DialogResult.OK)
            {
                long o = -1;
                if (long.TryParse(i, out o))
                {
                    transponderOffset = o;
                    transponderOfffsetToolStripMenuItem.Text = "Transponder offset: " + transponderOffset + " Hz";

                }
            }

        }

        private void showDoplerEffectModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showDoplerEffectModuleToolStripMenuItem.Checked)

            {
                int dh = Height - ClientRectangle.Height;
                Height = dh + panelDoppler.Height + panelDoppler.Top + 8;
                panelDoppler.Visible = true;
                trackBarDopplerTime_Scroll(null, null);
            }
            else
            { buttonHide_Click(null, null); }
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            timerDoppler.Stop();
            showDoplerEffectModuleToolStripMenuItem.Checked = false;
            int hd = Height - ClientRectangle.Height;
            Height = hd + comboBoxBand.Top + comboBoxBand.Height + 8;
            panelDoppler.Visible = false;
        }

        private void trackBarDopplerTime_Scroll(object sender, EventArgs e)
        {
            if (trackBarDopplerFrequency.Value > 0)
                labelDopplerFrequency.Text = "+" + trackBarDopplerFrequency.Value.ToString() + " Hz";
            else

                labelDopplerFrequency.Text = trackBarDopplerFrequency.Value.ToString() + " Hz";


            labelDopplerTime.Text = trackBarDopplerTime.Value.ToString() + " ms.";
            timerDoppler.Interval = trackBarDopplerTime.Value;

        }

        private void timerDoppler_Tick(object sender, EventArgs e)
        {
            frequency += trackBarDopplerFrequency.Value;
            writeFrequency();
        }

        private void buttonStartDoppler_Click(object sender, EventArgs e)
        {
            timerDoppler.Start();
        }

        private void buttonStopDoppler_Click(object sender, EventArgs e)
        {
            timerDoppler.Stop();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            DopplerCalculator dp = new DopplerCalculator();
            if (dp.ShowDialog() == DialogResult.OK)
            {
                if (dp.cF >= trackBarDopplerFrequency.Minimum && dp.cF <= trackBarDopplerFrequency.Maximum
                    &&
                    dp.cT >= trackBarDopplerTime.Minimum && dp.cT <= trackBarDopplerTime.Maximum

                    )
                {
                    trackBarDopplerFrequency.Value = -dp.cF;
                    trackBarDopplerTime.Value = dp.cT;
                    trackBarDopplerTime_Scroll(null, null);
                }
            }
        }


        private void readValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            timerReadYaesuCntr = 0;
            readNextYaesuValue();

        }


        private void vFOAMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vFOAMainToolStripMenuItem.Checked = true;
            vFOBSubToolStripMenuItem.Checked = false;
            VFO_A = vFOAMainToolStripMenuItem.Checked;
            setVfo();

        }

        private void setVfo()
        {
            vfo = "0";
            if (!VFO_A) vfo = "1";

        }

        private void vFOBSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vFOAMainToolStripMenuItem.Checked = false;
            vFOBSubToolStripMenuItem.Checked = true;
            VFO_A = vFOAMainToolStripMenuItem.Checked;
            setVfo();
        }

        private void showOmnirigDialogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            omniRigEngine.DialogVisible = true;
        }

        private void showOmniRigDialogToRestartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            omniRigEngine.DialogVisible = true;
        }


        internal void updateFrequency(string freq, string mode)
        {
            mode = mode.ToUpper().Trim();
            freq = PROCKI.ConvDotToDecimalSep(freq).ToUpper().Trim();




            string f = "";
            /*    foreach (char c in freq)
                {
                    if ((c >= '0' && c <= '9') || c == '.' || c == ',') f += c;
                    else break;
                }*/
            f = freq.Replace("MHZ", "").Replace("KHZ", "").Replace(")", "").Replace("(", "").Trim();


            if (!string.IsNullOrEmpty(f))
            {
                double i = -1;
                if (double.TryParse(f, out i))
                {
                    if (freq.IndexOf("KHZ") > 0) i = i * 1000;
                    else
                    if (freq.IndexOf("MHZ") > 0) i = i * 1000000;
                    else
                    {
                        if (i < 1000) i = i * 1000000;
                        else
                        if (i < 1000000) i = i * 1000;

                    }


                    long fq = (long)i;
                    int sx = comboBoxMode.SelectedIndex;
                    if (mode.IndexOf("CW") > -1)
                    {
                        if (fq < 10000000) comboBoxMode.SelectedIndex = 1; else comboBoxMode.SelectedIndex = 2;
                    }
                    else

                    if (mode.IndexOf("FM") > -1)
                    {
                        comboBoxMode.SelectedIndex = 8;
                    }
                    else
                    if (mode.IndexOf("AM") > -1)
                    {
                        comboBoxMode.SelectedIndex = 7;
                    }
                    else
                     if (mode.IndexOf("FT8") > -1)
                    {
                        comboBoxMode.SelectedIndex = 4;
                    }
                    else

                    {
                        if (fq < 10000000) comboBoxMode.SelectedIndex = 3; else comboBoxMode.SelectedIndex = 4;
                    }

                    //if (sx!=comboBoxMode.SelectedIndex)
                    frequency = fq;
                    writeFrequency();
                }
            }
        }


        // OMNIRIG COMMAND READED
        private void OmnirigGetCommand(int RigNumber, object Command, object Reply)
        {
            string reply = "";
            string command = "";
            if (Reply is byte[]) reply = PROCKI.bytesToString((byte[])Reply);
            if (Command is byte[]) command = PROCKI.bytesToString((byte[])Command);

            if (!string.IsNullOrEmpty(reply) && reply.Length > 2)
            {

                string r = reply.Substring(0, 2);
                string val = reply.Substring(2).Replace(";", "");
                char lVal = val[val.Length - 1];
                char mVal = ' ';
                if (val.Length > 2) mVal = val[val.Length - 2];
                switch (r)
                {
                    case "PC": setBoldPowerValues(val); break; //POWER VALUE
                    case "RF": setBoldRFValues(lVal); break; //ROOFING FILTER
                    case "AC": setBoldAntenaTuner(lVal); break; //ANTENA TUNER
                    case "AN": setBoldAntenaNumber(mVal); break; //ANTENA NUMBER
                    case "PA": setBoldPreamp(lVal); break; //PREAMP
                    case "RA": setBoldATT(lVal); break; //RF ATT
                    case "GT": setBoldAGC(lVal); break; //AGC
                }

            }
            if (timerReadYaesuCntr > -1)
                readNextYaesuValue();

        }


        //REPLY FROM TRX
        private void OmniRigEngine_CustomReply(int RigNumber, object Command, object Reply)
        {
            BeginInvoke(OminRigDel, new object[] { RigNumber, Command, Reply });
        }

        void sendCustomCommandVFO(string command, int value)
        {

            currentRig.SendCustomCommand(command + vfo + value + ";", 0, "");
            wait();
            currentRig.SendCustomCommand(command + vfo + ";", 0, "");



        }


        #region YAESU

        #region ANTENA_NUMBER

        private void setBoldAntenaNumber(char lVal)
        {
            antena1ToolStripMenuItem.Font = fontRegular;
            antena2ToolStripMenuItem.Font = fontRegular;
            antena3ToolStripMenuItem.Font = fontRegular;


            switch (lVal)
            {
                case '1': antena1ToolStripMenuItem.Font = fontBold; break;
                case '2': antena2ToolStripMenuItem.Font = fontBold; break;
                case '3': antena3ToolStripMenuItem.Font = fontBold; break;
            }
        }

        private void antena1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sendCustomCommandVFO("AN", 1);
        }

        private void antena2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sendCustomCommandVFO("AN", 2);
        }

        private void antena3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            sendCustomCommandVFO("AN", 3);
        }
        #endregion

        #region PRE_AMP

        private void setBoldPreamp(char lVal)
        {
            ipoToolStripMenuItem.Font = fontRegular;
            aMP1ToolStripMenuItem.Font = fontRegular;
            aMP2ToolStripMenuItem.Font = fontRegular;


            switch (lVal)
            {
                case '0': ipoToolStripMenuItem.Font = fontBold; break;
                case '1': aMP1ToolStripMenuItem.Font = fontBold; break;
                case '2': aMP2ToolStripMenuItem.Font = fontBold; break;
            }
        }
        private void ipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("PA", 0);
        }

        private void aMP1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("PA", 1);
        }



        private void aMP2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("PA", 2);
        }
        #endregion

        #region RF_ATTENUATOR

        private void setBoldATT(char lVal)
        {
            ATT_OFF_ToolStripMenuItem.Font = fontRegular;
            ATT_6_ToolStripMenuItem.Font = fontRegular;
            ATT_12_ToolStripMenuItem.Font = fontRegular;
            ATT_18_ToolStripMenuItem.Font = fontRegular;


            switch (lVal)
            {
                case '0': ATT_OFF_ToolStripMenuItem.Font = fontBold; break;
                case '1': ATT_6_ToolStripMenuItem.Font = fontBold; break;
                case '2': ATT_12_ToolStripMenuItem.Font = fontBold; break;
                case '3': ATT_18_ToolStripMenuItem.Font = fontBold; break;
            }
        }

        private void oFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RA", 0);
        }

        private void dBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RA", 1);
        }

        private void dBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RA", 2);
        }

        private void dBToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RA", 3);
        }

        #endregion

        #region AGC

        private void setBoldAGC(char lVal)
        {
            agcOFF_ToolStripMenuItem.Font = fontRegular;
            agcFAST_ToolStripMenuItem.Font = fontRegular;
            agcMID_ToolStripMenuItem.Font = fontRegular;
            agcSLOW_ToolStripMenuItem.Font = fontRegular;
            agcAUTO_ToolStripMenuItem.Font = fontRegular;
            switch (lVal)
            {
                case '0': agcOFF_ToolStripMenuItem.Font = fontBold; break;
                case '1': agcFAST_ToolStripMenuItem.Font = fontBold; break;
                case '2': agcMID_ToolStripMenuItem.Font = fontBold; break;
                case '4': agcSLOW_ToolStripMenuItem.Font = fontBold; break;
                case '5': agcAUTO_ToolStripMenuItem.Font = fontBold; agcAUTO_ToolStripMenuItem.Text = "AUTO - FAST"; break;
                case '6': agcAUTO_ToolStripMenuItem.Font = fontBold; agcAUTO_ToolStripMenuItem.Text = "AUTO - MID"; break;
                case '7': agcAUTO_ToolStripMenuItem.Font = fontBold; agcAUTO_ToolStripMenuItem.Text = "AUTO - SLOW"; break;

            }
        }

        private void agcOFFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("GT", 0);
        }

        private void aGCFASTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("GT", 1);
        }

        private void aGCMIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("GT", 2);
        }

        private void aGCSLOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("GT", 3);
        }

        private void aGCAUTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("GT", 4);
        }

        #endregion



        #region Roofing_Filter

        private void setBoldRFValues(char lVal)
        {



            toolStripMenuItem12kHz.Font = fontRegular;
            ToolStripMenuItem3kHz.Font = fontRegular;
            ToolStripMenuItem1_2kHz.Font = fontRegular;
            ToolStripMenuItem600Hz.Font = fontRegular;
            ToolStripMenuItem300Hz.Font = fontRegular;

            switch (lVal)
            {
                case '6': toolStripMenuItem12kHz.Font = fontBold; break;
                case '7': ToolStripMenuItem3kHz.Font = fontBold; break;
                case '8': ToolStripMenuItem1_2kHz.Font = fontBold; break;
                case '9': ToolStripMenuItem600Hz.Font = fontBold; break;
                case 'A': ToolStripMenuItem300Hz.Font = fontBold; break;
            }
        }

        private void toolStripMenuItem12kHz_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RF", 1);
        }

        private void ToolStripMenuItem3kHz_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RF", 2);
        }

        private void ToolStripMenuItem1_2kHz_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RF", 3);
        }

        private void ToolStripMenuItem600Hz_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RF", 4);
        }

        private void ToolStripMenuItem300Hz_Click(object sender, EventArgs e)
        {
            sendCustomCommandVFO("RF", 5);
        }

        #endregion


        #region ANTENA_TUNNER
        private void setBoldAntenaTuner(char val)
        {


            offAntenaTunerToolStripMenuItem.Font = fontRegular;
            OnAntenaTunerToolStripMenuItem.Font = fontRegular;

            if (val == '0') offAntenaTunerToolStripMenuItem.Font = fontBold;
            else OnAntenaTunerToolStripMenuItem.Font = fontBold;

        }
        private void OnAntenaTunerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentRig.SendCustomCommand("AC001;", 0, "");
            System.Threading.Thread.Sleep(100);
            currentRig.SendCustomCommand("AC;", 0, "");
        }

        private void offAntenaTunerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentRig.SendCustomCommand("AC000;", 0, "");
            System.Threading.Thread.Sleep(100);
            currentRig.SendCustomCommand("AC;", 0, "");
        }

        private void tuningNownotWorkedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentRig.SendCustomCommand("AC002;", 0, "AC002;");
        }
        #endregion

        #region TRX_Power
        private void setBoldPowerValues(string val)
        {
            int i = -1;


            w5ToolStripMenuItem.Font = fontRegular;
            w25ToolStripMenuItem.Font = fontRegular;
            w50ToolStripMenuItem.Font = fontRegular;
            w75ToolStripMenuItem.Font = fontRegular;
            w100ToolStripMenuItem.Font = fontRegular;
            wFixedToolStripMenuItem.Font = fontRegular;
            wFixedToolStripMenuItem.Text = "Fixed:";



            if (int.TryParse(val, out i))
            {
                switch (i)
                {
                    case 5: w5ToolStripMenuItem.Font = fontBold; break;
                    case 25: w25ToolStripMenuItem.Font = fontBold; break;
                    case 50: w50ToolStripMenuItem.Font = fontBold; break;
                    case 75: w75ToolStripMenuItem.Font = fontBold; break;
                    case 100: w100ToolStripMenuItem.Font = fontBold; break;
                    default: wFixedToolStripMenuItem.Font = fontBold; wFixedToolStripMenuItem.Text = "Fixed: " + i + "W"; break;
                }

            }

        }

        private void w5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPower(5);
        }

        private void w25ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPower(25);
        }

        private void w50ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPower(50);
        }

        private void w75ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPower(75);
        }

        private void w100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setPower(100);
        }




        private void wFixedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = -1;
            if (InputBox.ShowDialog("Enter power value (5-100)", "Enter Power Value", lv.ToString(), 5, 100, out i) == DialogResult.OK)
            {
                setPower(i);
            }


        }

        private void setPower(int i)
        {
            lv = i;
            string s = i.ToString();
            while (s.Length < 3) s = "0" + s;
            currentRig.SendCustomCommand("PC" + s + ";", 0, "");
            System.Threading.Thread.Sleep(100);
            currentRig.SendCustomCommand("PC;", 0, "");

        }
        #endregion


        private void onTRXToolStripMenuItem_Click(object sender, EventArgs e)
        {

            currentRig.SendCustomCommand("PS1;", 0, "");
            for (int i = 0; i < 12; i++) wait();
            currentRig.SendCustomCommand("PS1;", 0, "");

        }


        private void offTRXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FastQuestion.ShowQuestion("Are You sure to switch off TRX\r\nTurning On back may not be possible in the program.\r\nThen You must do it manually on TRX ", "Attention !!!", ImageType.Warning, IloscPrzyciskow.trzy, "YES", "NO", "Cancel") == FastQuestionResult.button1)
                currentRig.SendCustomCommand("PS0;", 0, "");
        }


        private void readNextYaesuValue()
        {
            wait();
            timerReadYaesuCntr++;
            switch (timerReadYaesuCntr)
            {
                case 1: currentRig.SendCustomCommand("PC;", 0, ""); break;//GET POWER
                case 2: currentRig.SendCustomCommand("RF" + vfo + ";", 0, ""); break;// GET ROOFING FILTER
                case 3: currentRig.SendCustomCommand("AC;", 0, ""); break; //ANTENA TUNNER SETTINGS
                case 4: currentRig.SendCustomCommand("AN" + vfo + ";", 0, ""); break; // ANTENA NUMBER
                case 5: currentRig.SendCustomCommand("PA" + vfo + ";", 0, ""); break; // PRE AMP
                case 6: currentRig.SendCustomCommand("RA" + vfo + ";", 0, ""); break; // RF ATTENUATOR
                case 7: currentRig.SendCustomCommand("GT" + vfo + ";", 0, ""); break; // AGC
                default: timerReadYaesuCntr = -1; break;

            }
        }

        #endregion



        private void wait()
        {
            for (int i = 0; i < 12; i++)
            {
                Application.DoEvents();
                System.Threading.Thread.Sleep(10);
            }
        }

        #region NTP


        private void timerNTP_Tick(object sender, EventArgs e)
        {
            timerNTP.Stop();
            if (runNTPTimeSyncOnStartToolStripMenuItem.Checked)
            {

                try
                {
                    bool wasWritten = false;


                    string s = Config.ReadValue(sect, "lastNTPTime");
                    long l = -1;
                    if (!string.IsNullOrEmpty(s))
                    {
                        if (long.TryParse(s, out l))
                        {
                            DateTime n = new DateTime(l);
                            TimeSpan ts = DateTime.Now - n;

                            if (ts.TotalMinutes < 600) wasWritten = true;
                        }

                    }


                    if (!wasWritten)
                    {
                        runNTPTimeSyncNowToolStripMenuItem1_Click(null, null);
                        Config.WriteValue(sect, "lastNTPTime", DateTime.Now.Ticks.ToString());

                    }
                }
                catch (Exception ex)
                {
                    Log.AddException(ex);


                }


            }

        }
        private void runNTPTimeSyncNowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                string fn = PROCKI.exePathB + "SET_NTP_TIME.exe";
                if (File.Exists(fn))
                {
                    if (!IsRunAsAdmin())
                    {
                        ProcessStartInfo proc = new ProcessStartInfo();
                        proc.UseShellExecute = true;
                        proc.WorkingDirectory = PROCKI.exePath;
                        proc.FileName = fn;
                        proc.Verb = "runas";
                        proc.Arguments = "/AUTO_SYNC";
                        Process p = Process.Start(proc);

                    }
                    else
                        Process.Start(fn, "/AUTO_SYNC");
                }
            }
            catch (Exception ex) { Log.AddException(ex); }
        }

        #endregion

        #region CAMERA
        private void runCameraModuleNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(PROCKI.exePathB + "CAT_CAMERA.exe"))
                {
                    Process[] p = Process.GetProcessesByName("CAT_CAMERA");
                    if (p == null || p.Length < 1)
                    {
                        System.Diagnostics.Process.Start(PROCKI.exePathB + "CAT_CAMERA.exe", "/UDP:" + UDP_PORT);

                    }
                }
                startUDP_SERVER();
            }
            catch (Exception ex) { Log.AddException(ex); }
        }
        #endregion


        private void pOTAModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pota == null || FormPOTA.isClosed)
            {
                pota = new POTA_To_CAT.FormPOTA(this);
                pota.Show();
            }
        }

     



    }
}



