using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DirectShowLib;
//using DirectShowLib.Utils;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Collections;
using ADMIN;
using System.Net.Sockets;
using System.Net;

namespace CAT_CAMERA
{
    public partial class Camera : Form
    {
        public Camera()
        {

            ADMIN.INIT.MinPassLength = 4;    // minimalna d³ugoœæ hase³
            ADMIN.INIT.AllowSaveFormSize = true;   // zezwalaj na zapis po³o¿enia i wielkoœci okien

            /// <summary>
            /// Zainicjiuj parametry programu
            /// </summary>
            /// ADMIN.INIT.WIN10_BIG_FONTS_FIX();
            ADMIN.INIT.USELogs = true;      /// U¿ywaj systemu logowania
            ADMIN.INIT.USEConfig = true;    /// U¿ywaj pliku konfiguracyjnego
            ADMIN.INIT.RunWithWindows = true;  ///Uruchamiaj program z windowsem
            ADMIN.INIT.RunMinimizedToTray = false; ///Uruchamiaj program w postaci zminimalizowanej
            ADMIN.INIT.MinimizeToTray = false;  ///Minimalizuj do traya
            ADMIN.INIT.WaitAfterRun = 0;    // po uruchomieniu programu czekaj xxx sekund na za³adowanie us³ug

            ADMIN.INIT.IsConfigEncrypted = false;   /// Czy plik konfiguracynjy ma byc zakodowany ?
            ADMIN.INIT.AllowConfigNotEncrypted = true;  /// Zezwalaj na niezakodowany plik konfiguracyjny mimo ¿e powinien byc zakodowany - program mo¿e odczytaæ konfig zapisany zwyk³ym tekstem ale gdy zostanie zapisany bêdzie ju¿ zakodowany
            ADMIN.INIT.CatchCriticalException = true;   /// W przypadku b³êdów krytycznych wyœwietl w³asne okno z b³êdem zamiast standartowego
            ADMIN.INIT.autoClose = false;       /// Zamykaj automatycznie okna 
            ADMIN.INIT.autoCloseTime = 4;        /// >Czas automatycznego zamkniêcia okna w sekundach
            ADMIN.INIT.customMessageBoxes = true;       /// True - w³asny styl message boxów false -Systemowe
            ADMIN.INIT.messageBoxesToLog = true;        /// Zapisuj okienka dialogowe do logu

            ADMIN.INIT.UseDB = false;                   // false - program nie uzywa baz danych

            ADMIN.INIT.splashHeader = "ELFRO";       // nag³owek w ADMIN.INIT screenie
            ADMIN.INIT.splashProgramName = "CATControl";       // nazwa programu w ADMIN.INIT screenie
            ADMIN.INIT.splashAdditionalInfo = "";       // dodatkowy opis progrmu
            ADMIN.INIT.splashCopyright = "©'2023 Tomasz Fronczek";  // stopka w ADMIN.INIT screenie

            ADMIN.INIT.disablePremamentUseDB = true;
            ADMIN.INIT.disablePremamentToTray = true;
            // ADMIN.INIT.MaxSteps = 5;     // ile kroków inicjalizacji nie u¿ywaæ
            ADMIN.INIT.stepsSpeed = 50; // co ile ms kolejny krok inicjalizacji

            ADMIN.INIT.preventMultiRuns = false;


            ADMIN.INIT.MinimizeToTray = true;
            ADMIN.INIT.RunMinimizedToTray = true;

            INIT.WIN10_BIG_FONTS_FIX();
            INIT.CatchCriticalException = true;
            Log.logSubFolder = @"LOGS\LOG_CamControl";
            Config.FileName = @"CONFIGS\Config_CamControl.ini";
            Config.ifBadFileName1 = "Config_CamControl.ini";
            Config.ifBadFileName2 = "";
            new ADMIN.Splash(false).fastInit();
            InitializeComponent();
        }

        IBaseFilter videoFilter = null;
        IBaseFilter videoCodecFilter = null;

        IVideoWindow videoWindow = null;
        IMediaControl mediaControl = null;

        IGraphBuilder graphBuilder = null;
        ICaptureGraphBuilder2 captureGraphBuilder = null;



        DsROTEntry rot = null;
        bool previewing = false;
        //   bool recording = false;




        public struct configuration
        {
            public string videoDevice;
            public string videoCodec;
            public string videoSize;
            public string videoFrameRate;


        }


        configuration cfg;


        string sect = "cfg";

        public void SAVE()
        {
            if (loading) return;
            //  SaveCfg(PROCKI.exePathB + "config.cfg");
            string s = PROCKI.ObjectToXML(cfg);
            Config.WriteMultiLineValue(sect, "videoConfig", s);
            Config.WriteValue(sect, "hideBar", hideWindowHeaderToolStripMenuItem.Checked);
            Config.WriteValue(sect, "hideInTaskBar", hideInTaskBarToolStripMenuItem.Checked);
            Config.WriteValue(sect, "onTop", alwaysOnTopToolStripMenuItem.Checked);
            PROCKI.saveFormSize(this);
            Config.WriteConfig();

        }

        public void LOAD()
        {
            //LoadCfg(PROCKI.exePathB + "config.cfg");
            string s = Config.ReadMultiLineValue(sect, "videoConfig");
            if (!string.IsNullOrEmpty(s))
            {
                cfg = ((configuration)(PROCKI.XmlToObject(cfg.GetType(), s)));
            }
            hideWindowHeaderToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "hideBar", hideWindowHeaderToolStripMenuItem.Checked);
            hideInTaskBarToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "hideInTaskBar", false);
            alwaysOnTopToolStripMenuItem.Checked = Config.ReadBoolValue(sect, "onTop", false);


        }




        public void CloseInterfaces()
        {


            if (this.videoWindow != null)
            {
                this.videoWindow.put_Visible(OABool.False);
                this.videoWindow.put_Owner(IntPtr.Zero);
            }


            if (rot != null)
            {
                rot.Dispose();
                rot = null;
            }


            if (this.mediaControl != null) Marshal.ReleaseComObject(this.mediaControl); this.mediaControl = null;

            if (this.videoWindow != null) Marshal.ReleaseComObject(this.videoWindow); this.videoWindow = null;
            if (this.graphBuilder != null) Marshal.ReleaseComObject(this.graphBuilder); this.graphBuilder = null;
            if (this.captureGraphBuilder != null) Marshal.ReleaseComObject(this.captureGraphBuilder); this.captureGraphBuilder = null;
            if (this.videoFilter != null) Marshal.ReleaseComObject(this.videoFilter); this.videoFilter = null;






        }

        /// <summary>
        /// Gets list of a Video Input devices 
        /// </summary>
        public void GetVidDevices()
        {
            VideoDevicesBox.Items.Clear();
            DsDevice[] devices;
            // Get all video input devices
            devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            VideoDevicesBox.Items.Add("<None>");
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i].Name != null) VideoDevicesBox.Items.Add(devices[i].Name);
            }
            VideoDevicesBox.SelectedIndex = 0;

        }


        public void GetVidCodecs()
        {
            VideoCodecsBox.Items.Clear();
            DsDevice[] devices;
            // Get all video input devices
            devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoCompressorCategory);
            VideoCodecsBox.Items.Add("<None>");
            for (int i = 0; i < devices.Length; i++)
            {
                if (devices[i].Name != null) VideoCodecsBox.Items.Add(devices[i].Name);
            }
            VideoCodecsBox.SelectedIndex = 0;

        }




        public IBaseFilter FindVideoCompresor(int idx)
        {
            try
            {
                idx--;

                DsDevice[] devices;
                object source;

                // Get all video input devices
                devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoCompressorCategory);
                if (idx >= 0 && idx < devices.Length)
                {
                    DsDevice device = devices[idx];

                    Guid iid = typeof(IBaseFilter).GUID;
                    device.Mon.BindToObject(null, null, ref iid, out source);

                    // VideoDevicesBox.SelectedIndex = idx + 1;
                    return (IBaseFilter)source;
                }
                else return null;
            }
            catch { return null; }
        }

        public IBaseFilter FindCaptureDevice(string idx)
        {
            try
            {

                DsDevice[] devices;
                object source;

                // Get all video input devices
                devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
                for (int i = 0; i < devices.Length; i++)
                {
                    if (devices[i].Name == idx)
                    {
                        DsDevice device = devices[i];


                        Guid iid = typeof(IBaseFilter).GUID;
                        device.Mon.BindToObject(null, null, ref iid, out source);


                        return (IBaseFilter)source;
                    }
                }
                return null;
            }
            catch { return null; }
        }


        public IBaseFilter FindVideoCompresor(string idx)
        {
            try
            {

                DsDevice[] devices;
                object source;

                // Get all video input devices
                devices = DsDevice.GetDevicesOfCat(FilterCategory.VideoCompressorCategory);
                for (int i = 0; i < devices.Length; i++)
                {
                    if (devices[i].Name == idx)
                    {
                        DsDevice device = devices[i];


                        Guid iid = typeof(IBaseFilter).GUID;
                        device.Mon.BindToObject(null, null, ref iid, out source);


                        return (IBaseFilter)source;
                    }
                }
                return null;
            }
            catch { return null; }
        }




        public void SetupVideoWindow()
        {
            try
            {
                int hr = 0;

                hr = this.videoWindow.put_Owner(panelVideo.Handle);
                DsError.ThrowExceptionForHR(hr);

                hr = this.videoWindow.put_WindowStyle(WindowStyle.Child | WindowStyle.ClipChildren | WindowStyle.ClipSiblings);
                DsError.ThrowExceptionForHR(hr);

                ResizeVideoWindow();
                hr = this.videoWindow.put_Visible(OABool.True);
                DsError.ThrowExceptionForHR(hr);
                videoWindow.put_MessageDrain(panelVideo.Handle);
            }
            catch { }
        }

        public void ResizeVideoWindow()
        {
            // Resize the video preview window to match owner window size
            if (this.videoWindow != null)
            {
                this.videoWindow.SetWindowPosition(0, 0, panelVideo.Width, panelVideo.Height);
            }
        }




        protected object setStreamConfigSetting(IAMStreamConfig streamConfig, string fieldName, object newValue)
        {
            try
            {
                if (streamConfig == null)
                    throw new NotSupportedException();

                object returnValue = null;
                IntPtr pmt = IntPtr.Zero;
                AMMediaType mediaType = new AMMediaType();

                try
                {
                    // Get the current format info
                    int hr = streamConfig.GetFormat(out mediaType);
                    if (hr != 0)
                        Marshal.ThrowExceptionForHR(hr);

                    object formatStruct;
                    if (mediaType.formatType == FormatType.WaveEx)
                        formatStruct = new WaveFormatEx();
                    else if (mediaType.formatType == FormatType.VideoInfo)
                        formatStruct = new VideoInfoHeader();
                    else if (mediaType.formatType == FormatType.VideoInfo2)
                        formatStruct = new VideoInfoHeader2();
                    else
                        throw new NotSupportedException("This device does not support a recognized format block.");

                    // Retrieve the nested structure
                    Marshal.PtrToStructure(mediaType.formatPtr, formatStruct);

                    // Find the required field
                    Type structType = formatStruct.GetType();

                    FieldInfo fieldInfo = structType.GetField(fieldName);
                    if (fieldInfo == null)
                        throw new NotSupportedException("Unable to find the member '" + fieldName + "' in the format block.");

                    // Update the value of the field
                    fieldInfo.SetValue(formatStruct, newValue);

                    // PtrToStructure copies the data so we need to copy it back
                    Marshal.StructureToPtr(formatStruct, mediaType.formatPtr, false);

                    // Save the changes
                    hr = streamConfig.SetFormat(mediaType);
                    if (hr != 0)
                        Marshal.ThrowExceptionForHR(hr);
                }
                finally
                {
                    DsUtils.FreeAMMediaType(mediaType);
                    Marshal.FreeCoTaskMem(pmt);
                }
                return (returnValue);
            }
            catch { return null; }
        }


        protected object getStreamConfigSetting(IAMStreamConfig streamConfig, string fieldName)
        {
            try
            {
                if (streamConfig == null)
                    throw new NotSupportedException();
                //    assertStopped();
                //   derenderGraph();

                object returnValue = null;
                IntPtr pmt = IntPtr.Zero;
                AMMediaType mediaType = new AMMediaType();

                try
                {
                    // Get the current format info
                    int hr = streamConfig.GetFormat(out mediaType);
                    if (hr != 0)
                        Marshal.ThrowExceptionForHR(hr);
                    //  Marshal.PtrToStructure(pmt, mediaType);

                    // The formatPtr member points to different structures
                    // dependingon the formatType
                    object formatStruct;
                    if (mediaType.formatType == FormatType.WaveEx)
                        formatStruct = new WaveFormatEx();
                    else if (mediaType.formatType == FormatType.VideoInfo)
                        formatStruct = new VideoInfoHeader();
                    else if (mediaType.formatType == FormatType.VideoInfo2)
                        formatStruct = new VideoInfoHeader2();
                    else
                        throw new NotSupportedException("This device does not support a recognized format block.");

                    // Retrieve the nested structure
                    Marshal.PtrToStructure(mediaType.formatPtr, formatStruct);

                    // Find the required field
                    Type structType = formatStruct.GetType();
                    FieldInfo fieldInfo = structType.GetField(fieldName);
                    if (fieldInfo == null)
                        throw new NotSupportedException("Unable to find the member '" + fieldName + "' in the format block.");

                    // Extract the field's current value
                    returnValue = fieldInfo.GetValue(formatStruct);

                }
                finally
                {
                    DsUtils.FreeAMMediaType(mediaType);
                    Marshal.FreeCoTaskMem(pmt);
                }
                // renderGraph();
                // startPreviewIfNeeded();

                return (returnValue);
            }
            catch { return null; }
        }



        private void SetPinParameters(bool isPreview)
        {
            int hr = 0;
            object o;
            GC.Collect();

            graphBuilder = (IGraphBuilder)new FilterGraph();
            rot = new DsROTEntry(graphBuilder);
            captureGraphBuilder = (ICaptureGraphBuilder2)new CaptureGraphBuilder2();
            captureGraphBuilder.SetFiltergraph(graphBuilder);
            mediaControl = (IMediaControl)this.graphBuilder;
            videoWindow = (IVideoWindow)this.graphBuilder;
            videoFilter = FindCaptureDevice(cfg.videoDevice);
            videoCodecFilter = FindVideoCompresor(cfg.videoCodec);
            // audioFilter = FindAudioDevice(cfg.audioDevice);
            // audioCodecFilter = FindAudioCompresor(cfg.audioCodec);


            if (videoFilter != null)
            {
                //Add the Video input device to the graph
                hr = graphBuilder.AddFilter(videoFilter, "Video Capture Device");
                DsError.ThrowExceptionForHR(hr);


                if (!isPreview)
                {

                    if (videoCodecFilter != null)
                    {
                        hr = graphBuilder.AddFilter(videoCodecFilter, "Video Compressor");
                        DsError.ThrowExceptionForHR(hr);
                    }


                }

                string SvideoFrameRate = cfg.videoFrameRate;




                if (SvideoFrameRate.IndexOf(' ') > 0) SvideoFrameRate = SvideoFrameRate.Remove(SvideoFrameRate.IndexOf(' ') - 1);
                int videoFrameRate;

                int.TryParse(SvideoFrameRate, out videoFrameRate); if (videoFrameRate < 1) videoFrameRate = 25;
                Size size = getVidSize(cfg.videoSize);
                if (size.Width < 1 || size.Height < 1) { size.Width = 320; size.Height = 240; }


                if (isPreview)
                    hr = captureGraphBuilder.FindInterface(PinCategory.Preview, MediaType.Video, videoFilter, typeof(IAMStreamConfig).GUID, out o);
                else
                    hr = captureGraphBuilder.FindInterface(PinCategory.Capture, MediaType.Video, videoFilter, typeof(IAMStreamConfig).GUID, out o);
                if (hr > 0)
                {
                    IAMStreamConfig videoStreamConfig = (IAMStreamConfig)o;
                    long avgTimePerFrame = (long)(10000000 / videoFrameRate);  // klatki na s
                    setStreamConfigSetting(videoStreamConfig, "AvgTimePerFrame", avgTimePerFrame);
                    BitmapInfoHeader bmiHeader;  // rozmiar klatki
                    bmiHeader = (BitmapInfoHeader)getStreamConfigSetting(videoStreamConfig, "BmiHeader");


                    bmiHeader.Width = size.Width;
                    bmiHeader.Height = size.Height;
                    setStreamConfigSetting(videoStreamConfig, "BmiHeader", bmiHeader);
                }





            }


        }




        private void StartPreview()
        {
            try
            {   // IBaseFilter sourceFilter = null;
                label14.Top = panelVideo.Top + ((panelVideo.Height - label14.Height) / 2);
                label14.Left = panelVideo.Left + ((panelVideo.Width - label14.Width) / 2);
                label14.Visible = true;
                label14.Text = "Please Wait.\r\nStarting  ...";

                int hr = 0;

                SetPinParameters(true);
                if (videoFilter != null)
                {


                    hr = captureGraphBuilder.RenderStream(PinCategory.Preview, MediaType.Interleaved, videoFilter, null, null);
                    if (hr < 0)
                        captureGraphBuilder.RenderStream(PinCategory.Preview, MediaType.Video, videoFilter, null, null);


                    SetupVideoWindow();// wrzuæ preview na panel;
                    this.mediaControl.Run();// start preview
                    previewing = true;
                    label14.Visible = false; ;


                }
            }
            catch
            {
                label14.Top = panelVideo.Top + ((panelVideo.Height - label14.Height) / 2);
                label14.Left = panelVideo.Left + ((panelVideo.Width - label14.Width) / 2);
                label14.Visible = true;
                label14.Text = "NO VIDEO !!!\r\nOR VIDEO PROPETERIES ARE BAD !!!\r\n\r\nCheck config and cables.";
            }
        }


        private void StopPreview()
        {
            if (previewing)
            {

                if (mediaControl != null)
                    mediaControl.Stop();

                CloseInterfaces();

                previewing = false;

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            panelVideo.Dock = DockStyle.Fill;
            Application.DoEvents();
            MinimumSize = new Size(320, 240);
            Size = MinimumSize;
            Application.DoEvents();
            PROCKI.loadFormSizeAndLog(this);
            MinimumSize = new Size(320, 240);
            label14.Dock = DockStyle.Fill;



            LOAD();
            hideWindowHeaderToolStripMenuItem_Click(null, null);
            hideInTaskBarToolStripMenuItem_Click(null, null);
            alwaysOnTopToolStripMenuItem_Click(null, null);

            int xofs = Width - ClientSize.Width;
            int yofs = Height - ClientSize.Height;
            panelVideo.Visible = true;

            panelCFG.Visible = false;

            panelVideo.MouseWheel += new MouseEventHandler(s0_MouseWheel);

            StartPreview();
            if (UDPClient.UDP_ENABLED)
            {
                udp = new UDPClient();
                udp.Initialize(IPAddress.Parse("127.0.0.1"));
                if (UDPClient.UDP_ENABLED)
                uDPStatusToolStripMenuItem.Text="UDP status: "+UDPClient.UDP_PORT.ToString()+" / OK ";
                else
                    uDPStatusToolStripMenuItem.Text = "UDP status: " + UDPClient.UDP_PORT.ToString() + " / DISABLED";
            }
            else
            {
                uDPStatusToolStripMenuItem.Text = "UDP status: DISABLED";
            }
      

        }

        UDPClient udp;
      

        

        private void s0_MouseWheel(object sender, MouseEventArgs e)
        {
            int d = e.Delta;

            string s = "";
            if (d > 0) { s = "UP"; }
            if (d < 0) { s = "DOWN"; }
            // s.Value = i.ToString();
            if (d != 0 && UDPClient.UDP_ENABLED &&  udp!=null )
            {
                try
                {
                    byte[] b = PROCKI.stringToBytes(s);
                    udp.Send(b);
                }
                catch { }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (previewing)
            {

                if (mediaControl != null)
                    mediaControl.Stop();
                previewing = false;
            }
            CloseInterfaces();
            GC.Collect();
            SAVE();

        }



        Size beforeConfig;

        private void Config_Click(object sender, EventArgs e)
        {
            beforeConfig = Size;
            int xofs = Width - ClientSize.Width;
            int yofs = Height - ClientSize.Height;
            label14.Visible = false;



            //panelCFG.Width = 533;
            //panelCFG.Height = 310;
            StopPreview(); CloseInterfaces();
            panelVideo.Visible = false;

            panelCFG.Top = 5;
            panelCFG.Left = 5;
            panelCFG.Visible = true;

            Width = panelCFG.Width + xofs + 10;
            Height = panelCFG.Height + yofs + 10;


            GetVidDevices();

            GetVidCodecs();


            VideoDevicesBox.SelectedIndex = -1;
            for (int i = 0; i < VideoDevicesBox.Items.Count; i++)
                if (VideoDevicesBox.Items[i].ToString() == cfg.videoDevice) VideoDevicesBox.SelectedIndex = i;

            VideoCodecsBox.SelectedIndex = -1;
            for (int i = 0; i < VideoCodecsBox.Items.Count; i++)
                if (VideoCodecsBox.Items[i].ToString() == cfg.videoCodec) VideoCodecsBox.SelectedIndex = i;

            VideoSizeBox.SelectedIndex = -1;
            for (int i = 0; i < VideoSizeBox.Items.Count; i++)
                if (VideoSizeBox.Items[i].ToString() == cfg.videoSize) VideoSizeBox.SelectedIndex = i;

            FrameRateBox.SelectedIndex = -1;
            for (int i = 0; i < FrameRateBox.Items.Count; i++)
                if (FrameRateBox.Items[i].ToString() == cfg.videoFrameRate) FrameRateBox.SelectedIndex = i;





        }

        public Size getVidSize(string selection)
        {
            try
            {
                int x, y;

                string x1 = selection.Substring(0, selection.IndexOf('x'));
                string y1 = selection.Substring(selection.IndexOf('x') + 1, selection.Length - selection.IndexOf('x') - 1);
                int.TryParse(x1, out x);
                int.TryParse(y1, out y);
                return new Size(x, y);
            }
            catch
            { return new Size(0, 0); }

        }


        private void Back_Click(object sender, EventArgs e)
        {
            if (VideoDevicesBox.SelectedIndex > -1) cfg.videoDevice = VideoDevicesBox.Items[VideoDevicesBox.SelectedIndex].ToString(); else cfg.videoDevice = null;
            if (VideoCodecsBox.SelectedIndex > -1) cfg.videoCodec = VideoCodecsBox.Items[VideoCodecsBox.SelectedIndex].ToString(); else cfg.videoCodec = null;
            if (VideoSizeBox.SelectedIndex > -1) cfg.videoSize = VideoSizeBox.Items[VideoSizeBox.SelectedIndex].ToString(); else cfg.videoSize = "640x480";

            if (FrameRateBox.SelectedIndex > -1) cfg.videoFrameRate = FrameRateBox.Items[FrameRateBox.SelectedIndex].ToString(); else cfg.videoFrameRate = "25";



            SAVE();

            CloseInterfaces();
            int xofs = Width - ClientSize.Width;
            int yofs = Height - ClientSize.Height;
            panelVideo.Visible = true;

            panelCFG.Visible = false;


            Size = beforeConfig;
            StartPreview();
        }

        #region DragNdrop
        int sx, sy, lx, ly;
        bool dwn = false;
        private bool loading = true;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Form || sender is Panel && e.Button== MouseButtons.Left)
            {

                sx = MousePosition.X;
                sy = MousePosition.Y;
                lx = Left;
                ly = Top;
                dwn = true;
            }
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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dwn = false;
            if (!loading && UDPClient.UDP_ENABLED) SAVE();
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            dwn = false;
        }
        #endregion









        private void One_Click(object sender, EventArgs e)
        {
            if (label14.Visible) return;
            Size size = getVidSize(cfg.videoSize);
            int divider = 1;
            if (sender is ToolStripMenuItem)
            {
                string name = ((ToolStripMenuItem)sender).Name;
                if (name == "Half") divider = 2;
                if (name == "Quarter") divider = 4;
                if (name == "One") divider = 1;


            }
            if (divider != 0)
            {
                int x = panelVideo.Width;
                int y = panelVideo.Height;
                int dx = Width - panelVideo.Width;
                int dy = Height - panelVideo.Height;


                size.Width = size.Width / divider;
                size.Height = size.Height / divider;

                size.Width += dx;
                size.Height += dy;
                if (MinimumSize.Width > size.Width || MinimumSize.Height > size.Height)
                    MinimumSize = size;
                Size = size;

            }
            else
            {


            }



            if (previewing)
            {
                SetupVideoWindow();
            }
           // SAVE();
        }

        private void fitWidthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label14.Visible) return;
            Size r = getVidSize(cfg.videoSize);
            if (r == null) return;
            int x = panelVideo.Width;
            int y = panelVideo.Height;
            int dx = Width - panelVideo.Width;
            int dy = Height - panelVideo.Height;
            double scale = (r.Height * 1.0) / (r.Width * 1.0);
            int nx = (int)Math.Floor(y / scale);
            Width = nx + dx;
            if (previewing)
            {
                SetupVideoWindow();
            }
        }

        private void fitHeightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (label14.Visible) return;
            Size r = getVidSize(cfg.videoSize);
            if (r == null) return;
            int x = panelVideo.Width;
            int y = panelVideo.Height;
            int dx = Width - panelVideo.Width;
            int dy = Height - panelVideo.Height;
            double scale = (r.Height * 1.0) / (r.Width * 1.0);
            int ny = (int)Math.Floor(x * scale);
            Height = ny + dy;
            if (previewing)
            {
                SetupVideoWindow();
            }
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
            Application.DoEvents();
            if (previewing)
            {
                SetupVideoWindow();
            }

            SAVE();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = alwaysOnTopToolStripMenuItem.Checked;

            Application.DoEvents();
            if (previewing)
            {
                SetupVideoWindow();
            }

            SAVE();
        }

        private void hideInTaskBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInTaskbar = !hideInTaskBarToolStripMenuItem.Checked;
            if (!loading)
            {
                Application.DoEvents();
                Config_Click(null, null);
                Application.DoEvents();
                Back_Click(null, null);

                SAVE();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loading = false;
        }

        private void Camera_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            PROCKI.saveFormSizeAndLog(this);
            INIT.UNLOAD();
        }


        private void Camera_Resize(object sender, EventArgs e)
        {
            if (videoWindow != null) SetupVideoWindow();
            if (!loading && UDPClient.UDP_ENABLED) SAVE();
        }


        private void VideoCodecsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (videoCodecFilter != null)
            {
                Marshal.ReleaseComObject(videoCodecFilter);
                videoCodecFilter = null;
                videoCodecFilter = FindVideoCompresor(VideoCodecsBox.SelectedIndex);
            }
        }









    }
}