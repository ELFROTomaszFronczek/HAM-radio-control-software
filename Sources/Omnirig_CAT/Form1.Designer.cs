namespace Omnirig_CAT
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonTX = new System.Windows.Forms.Button();
            this.labelRig = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectRig1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRig2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transponderModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workWithTransponderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transponderOfffsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.hideInTaskBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWindowHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runCameraModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureControlUDPPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNTPTimeSyncOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.tXOnlyWhenPressedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXOnCharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBand = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button500 = new System.Windows.Forms.Button();
            this.button000 = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
            this.labelErr = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timerNTP = new System.Windows.Forms.Timer(this.components);
            this.panelDoppler = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarDopplerFrequency = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarDopplerTime = new System.Windows.Forms.TrackBar();
            this.buttonStartDoppler = new System.Windows.Forms.Button();
            this.buttonStopDoppler = new System.Windows.Forms.Button();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.showDoplerEffectModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelDopplerTime = new System.Windows.Forms.Label();
            this.labelDopplerFrequency = new System.Windows.Forms.Label();
            this.timerDoppler = new System.Windows.Forms.Timer(this.components);
            this.s11 = new Omnirig_CAT.SevenSegment();
            this.s10 = new Omnirig_CAT.SevenSegment();
            this.s9 = new Omnirig_CAT.SevenSegment();
            this.s8 = new Omnirig_CAT.SevenSegment();
            this.s7 = new Omnirig_CAT.SevenSegment();
            this.s6 = new Omnirig_CAT.SevenSegment();
            this.s5 = new Omnirig_CAT.SevenSegment();
            this.s4 = new Omnirig_CAT.SevenSegment();
            this.s3 = new Omnirig_CAT.SevenSegment();
            this.s2 = new Omnirig_CAT.SevenSegment();
            this.s1 = new Omnirig_CAT.SevenSegment();
            this.s0 = new Omnirig_CAT.SevenSegment();
            this.sDot = new Omnirig_CAT.SevenSegment();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelDoppler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDopplerFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDopplerTime)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 333;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(8)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.panelDoppler);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonMenu);
            this.panel1.Controls.Add(this.buttonTX);
            this.panel1.Controls.Add(this.labelRig);
            this.panel1.Controls.Add(this.comboBoxMode);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxBand);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button500);
            this.panel1.Controls.Add(this.button000);
            this.panel1.Controls.Add(this.labelMode);
            this.panel1.Controls.Add(this.labelErr);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(823, 457);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.s11);
            this.panel2.Controls.Add(this.s10);
            this.panel2.Controls.Add(this.s9);
            this.panel2.Controls.Add(this.s8);
            this.panel2.Controls.Add(this.s7);
            this.panel2.Controls.Add(this.s6);
            this.panel2.Controls.Add(this.s5);
            this.panel2.Controls.Add(this.s4);
            this.panel2.Controls.Add(this.s3);
            this.panel2.Controls.Add(this.s2);
            this.panel2.Controls.Add(this.s1);
            this.panel2.Controls.Add(this.s0);
            this.panel2.Controls.Add(this.sDot);
            this.panel2.Location = new System.Drawing.Point(11, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 86);
            this.panel2.TabIndex = 50;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenu.Location = new System.Drawing.Point(748, 114);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(72, 31);
            this.buttonMenu.TabIndex = 49;
            this.buttonMenu.Text = "Menu";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTX
            // 
            this.buttonTX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTX.BackColor = System.Drawing.Color.Green;
            this.buttonTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonTX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonTX.Location = new System.Drawing.Point(767, 38);
            this.buttonTX.Name = "buttonTX";
            this.buttonTX.Size = new System.Drawing.Size(51, 64);
            this.buttonTX.TabIndex = 48;
            this.buttonTX.Text = "TX";
            this.buttonTX.UseVisualStyleBackColor = false;
            this.buttonTX.Click += new System.EventHandler(this.buttonTX_Click);
            this.buttonTX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.buttonTX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // labelRig
            // 
            this.labelRig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.labelRig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRig.ContextMenuStrip = this.contextMenuStrip1;
            this.labelRig.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRig.ForeColor = System.Drawing.Color.Silver;
            this.labelRig.Location = new System.Drawing.Point(11, 3);
            this.labelRig.Name = "labelRig";
            this.labelRig.Size = new System.Drawing.Size(312, 20);
            this.labelRig.TabIndex = 47;
            this.labelRig.Text = "***";
            this.labelRig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRig.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.labelRig.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.labelRig.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.labelRig.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectRig1ToolStripMenuItem,
            this.selectRig2ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.displayToolStripMenuItem,
            this.transponderModeToolStripMenuItem,
            this.showDoplerEffectModuleToolStripMenuItem,
            this.toolStripMenuItem5,
            this.hideInTaskBarToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.hideWindowHeaderToolStripMenuItem,
            this.cameraModuleToolStripMenuItem,
            this.runNTPTimeSyncOnStartToolStripMenuItem,
            this.toolStripMenuItem2,
            this.tXOnlyWhenPressedToolStripMenuItem,
            this.tXOnCharToolStripMenuItem,
            this.toolStripMenuItem3,
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(467, 370);
            // 
            // selectRig1ToolStripMenuItem
            // 
            this.selectRig1ToolStripMenuItem.CheckOnClick = true;
            this.selectRig1ToolStripMenuItem.Name = "selectRig1ToolStripMenuItem";
            this.selectRig1ToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.selectRig1ToolStripMenuItem.Text = "Select Rig 1";
            this.selectRig1ToolStripMenuItem.Click += new System.EventHandler(this.selectRig1ToolStripMenuItem_Click);
            // 
            // selectRig2ToolStripMenuItem
            // 
            this.selectRig2ToolStripMenuItem.CheckOnClick = true;
            this.selectRig2ToolStripMenuItem.Name = "selectRig2ToolStripMenuItem";
            this.selectRig2ToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.selectRig2ToolStripMenuItem.Text = "Select Rig 2";
            this.selectRig2ToolStripMenuItem.Click += new System.EventHandler(this.selectRig2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(463, 6);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.CheckOnClick = true;
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.displayToolStripMenuItem.Text = "Display with GHz";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // transponderModeToolStripMenuItem
            // 
            this.transponderModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.workWithTransponderToolStripMenuItem,
            this.transponderOfffsetToolStripMenuItem});
            this.transponderModeToolStripMenuItem.Name = "transponderModeToolStripMenuItem";
            this.transponderModeToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.transponderModeToolStripMenuItem.Text = "Transponder Mode";
            // 
            // workWithTransponderToolStripMenuItem
            // 
            this.workWithTransponderToolStripMenuItem.CheckOnClick = true;
            this.workWithTransponderToolStripMenuItem.Name = "workWithTransponderToolStripMenuItem";
            this.workWithTransponderToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.workWithTransponderToolStripMenuItem.Text = "Work With Transponder";
            // 
            // transponderOfffsetToolStripMenuItem
            // 
            this.transponderOfffsetToolStripMenuItem.Name = "transponderOfffsetToolStripMenuItem";
            this.transponderOfffsetToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.transponderOfffsetToolStripMenuItem.Text = "Transponder offset: 0 Hz";
            this.transponderOfffsetToolStripMenuItem.Click += new System.EventHandler(this.transponderOfffsetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(463, 6);
            // 
            // hideInTaskBarToolStripMenuItem
            // 
            this.hideInTaskBarToolStripMenuItem.CheckOnClick = true;
            this.hideInTaskBarToolStripMenuItem.Name = "hideInTaskBarToolStripMenuItem";
            this.hideInTaskBarToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.hideInTaskBarToolStripMenuItem.Text = "Hide in Task Bar";
            this.hideInTaskBarToolStripMenuItem.Click += new System.EventHandler(this.hideInTaskBarToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // hideWindowHeaderToolStripMenuItem
            // 
            this.hideWindowHeaderToolStripMenuItem.CheckOnClick = true;
            this.hideWindowHeaderToolStripMenuItem.Name = "hideWindowHeaderToolStripMenuItem";
            this.hideWindowHeaderToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.hideWindowHeaderToolStripMenuItem.Text = "Hide Window Header";
            this.hideWindowHeaderToolStripMenuItem.Click += new System.EventHandler(this.hideWindowHeaderToolStripMenuItem_Click);
            // 
            // cameraModuleToolStripMenuItem
            // 
            this.cameraModuleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runCameraModuleToolStripMenuItem,
            this.configureControlUDPPortToolStripMenuItem});
            this.cameraModuleToolStripMenuItem.Name = "cameraModuleToolStripMenuItem";
            this.cameraModuleToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.cameraModuleToolStripMenuItem.Text = "Camera module";
            // 
            // runCameraModuleToolStripMenuItem
            // 
            this.runCameraModuleToolStripMenuItem.CheckOnClick = true;
            this.runCameraModuleToolStripMenuItem.Name = "runCameraModuleToolStripMenuItem";
            this.runCameraModuleToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.runCameraModuleToolStripMenuItem.Text = "On start and exit run/close Camera module";
            // 
            // configureControlUDPPortToolStripMenuItem
            // 
            this.configureControlUDPPortToolStripMenuItem.Name = "configureControlUDPPortToolStripMenuItem";
            this.configureControlUDPPortToolStripMenuItem.Size = new System.Drawing.Size(386, 26);
            this.configureControlUDPPortToolStripMenuItem.Text = "Configure control UDP port (restart needed):";
            this.configureControlUDPPortToolStripMenuItem.Click += new System.EventHandler(this.configureControlUDPPortToolStripMenuItem_Click);
            // 
            // runNTPTimeSyncOnStartToolStripMenuItem
            // 
            this.runNTPTimeSyncOnStartToolStripMenuItem.CheckOnClick = true;
            this.runNTPTimeSyncOnStartToolStripMenuItem.Name = "runNTPTimeSyncOnStartToolStripMenuItem";
            this.runNTPTimeSyncOnStartToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.runNTPTimeSyncOnStartToolStripMenuItem.Text = "Run NTP Time sync on start (if was not sync in last 10hours)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(463, 6);
            // 
            // tXOnlyWhenPressedToolStripMenuItem
            // 
            this.tXOnlyWhenPressedToolStripMenuItem.CheckOnClick = true;
            this.tXOnlyWhenPressedToolStripMenuItem.Name = "tXOnlyWhenPressedToolStripMenuItem";
            this.tXOnlyWhenPressedToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.tXOnlyWhenPressedToolStripMenuItem.Text = "TX only when pressed";
            // 
            // tXOnCharToolStripMenuItem
            // 
            this.tXOnCharToolStripMenuItem.CheckOnClick = true;
            this.tXOnCharToolStripMenuItem.Name = "tXOnCharToolStripMenuItem";
            this.tXOnCharToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.tXOnCharToolStripMenuItem.Text = "TX on \"\\\" keyboard pressed";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(463, 6);
            // 
            // onBandChangedSlelectDefaultSSBModeToolStripMenuItem
            // 
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.CheckOnClick = true;
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Name = "onBandChangedSlelectDefaultSSBModeToolStripMenuItem";
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Text = "On User Band changed select default SSB Mode";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(463, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Items.AddRange(new object[] {
            "",
            "CW LSB",
            "CW USB",
            "SSB LSB",
            "SSB USB",
            "DIGI LSB",
            "DIGI USB",
            "AM",
            "FM"});
            this.comboBoxMode.Location = new System.Drawing.Point(562, 118);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(118, 28);
            this.comboBoxMode.TabIndex = 44;
            this.comboBoxMode.DropDown += new System.EventHandler(this.comboBoxMode_DropDown);
            this.comboBoxMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxMode_SelectedIndexChanged);
            this.comboBoxMode.DropDownClosed += new System.EventHandler(this.comboBoxMode_DropDownClosed);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(496, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "MODE:";
            // 
            // comboBoxBand
            // 
            this.comboBoxBand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBand.FormattingEnabled = true;
            this.comboBoxBand.Items.AddRange(new object[] {
            "",
            "160m",
            "80m",
            "60m",
            "40m",
            "30m",
            "20m",
            "17m",
            "15m",
            "12m",
            "10m",
            "6m",
            "4m",
            "2m",
            "70cm",
            ""});
            this.comboBoxBand.Location = new System.Drawing.Point(70, 118);
            this.comboBoxBand.Name = "comboBoxBand";
            this.comboBoxBand.Size = new System.Drawing.Size(118, 28);
            this.comboBoxBand.TabIndex = 42;
            this.comboBoxBand.DropDown += new System.EventHandler(this.comboBoxBand_DropDown);
            this.comboBoxBand.SelectedIndexChanged += new System.EventHandler(this.comboBoxBand_SelectedIndexChanged);
            this.comboBoxBand.DropDownClosed += new System.EventHandler(this.comboBoxBand_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(11, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "BAND:";
            // 
            // button500
            // 
            this.button500.Location = new System.Drawing.Point(686, 74);
            this.button500.Name = "button500";
            this.button500.Size = new System.Drawing.Size(53, 28);
            this.button500.TabIndex = 40;
            this.button500.Text = "500";
            this.button500.UseVisualStyleBackColor = true;
            this.button500.Click += new System.EventHandler(this.button500_Click);
            // 
            // button000
            // 
            this.button000.Location = new System.Drawing.Point(686, 38);
            this.button000.Name = "button000";
            this.button000.Size = new System.Drawing.Size(53, 28);
            this.button000.TabIndex = 39;
            this.button000.Text = "000";
            this.button000.UseVisualStyleBackColor = true;
            this.button000.Click += new System.EventHandler(this.button000_Click);
            // 
            // labelMode
            // 
            this.labelMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMode.ForeColor = System.Drawing.Color.Silver;
            this.labelMode.Location = new System.Drawing.Point(523, 4);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(159, 20);
            this.labelMode.TabIndex = 11;
            this.labelMode.Text = "***";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelErr
            // 
            this.labelErr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelErr.AutoSize = true;
            this.labelErr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.labelErr.Location = new System.Drawing.Point(728, 2);
            this.labelErr.Name = "labelErr";
            this.labelErr.Size = new System.Drawing.Size(92, 20);
            this.labelErr.TabIndex = 51;
            this.labelErr.Text = "Some ERR";
            this.labelErr.Visible = false;
            this.labelErr.Click += new System.EventHandler(this.labelErr_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 300000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timerNTP
            // 
            this.timerNTP.Interval = 500;
            this.timerNTP.Tick += new System.EventHandler(this.timerNTP_Tick);
            // 
            // panelDoppler
            // 
            this.panelDoppler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDoppler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelDoppler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDoppler.Controls.Add(this.labelDopplerFrequency);
            this.panelDoppler.Controls.Add(this.labelDopplerTime);
            this.panelDoppler.Controls.Add(this.buttonHide);
            this.panelDoppler.Controls.Add(this.buttonCalculate);
            this.panelDoppler.Controls.Add(this.buttonStopDoppler);
            this.panelDoppler.Controls.Add(this.buttonStartDoppler);
            this.panelDoppler.Controls.Add(this.label5);
            this.panelDoppler.Controls.Add(this.trackBarDopplerTime);
            this.panelDoppler.Controls.Add(this.label4);
            this.panelDoppler.Controls.Add(this.trackBarDopplerFrequency);
            this.panelDoppler.Controls.Add(this.label1);
            this.panelDoppler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelDoppler.Location = new System.Drawing.Point(11, 172);
            this.panelDoppler.Name = "panelDoppler";
            this.panelDoppler.Size = new System.Drawing.Size(803, 271);
            this.panelDoppler.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doppler Effect Module";
            // 
            // trackBarDopplerFrequency
            // 
            this.trackBarDopplerFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDopplerFrequency.Location = new System.Drawing.Point(14, 156);
            this.trackBarDopplerFrequency.Maximum = 100;
            this.trackBarDopplerFrequency.Minimum = -100;
            this.trackBarDopplerFrequency.Name = "trackBarDopplerFrequency";
            this.trackBarDopplerFrequency.Size = new System.Drawing.Size(768, 56);
            this.trackBarDopplerFrequency.TabIndex = 3;
            this.trackBarDopplerFrequency.Scroll += new System.EventHandler(this.trackBarDopplerTime_Scroll);
            this.trackBarDopplerFrequency.ValueChanged += new System.EventHandler(this.trackBarDopplerTime_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change Frequency:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Every Time:";
            // 
            // trackBarDopplerTime
            // 
            this.trackBarDopplerTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarDopplerTime.Location = new System.Drawing.Point(14, 71);
            this.trackBarDopplerTime.Maximum = 1000;
            this.trackBarDopplerTime.Minimum = 100;
            this.trackBarDopplerTime.Name = "trackBarDopplerTime";
            this.trackBarDopplerTime.Size = new System.Drawing.Size(768, 56);
            this.trackBarDopplerTime.TabIndex = 6;
            this.trackBarDopplerTime.Value = 100;
            this.trackBarDopplerTime.Scroll += new System.EventHandler(this.trackBarDopplerTime_Scroll);
            this.trackBarDopplerTime.ValueChanged += new System.EventHandler(this.trackBarDopplerTime_Scroll);
            // 
            // buttonStartDoppler
            // 
            this.buttonStartDoppler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStartDoppler.Location = new System.Drawing.Point(29, 217);
            this.buttonStartDoppler.Name = "buttonStartDoppler";
            this.buttonStartDoppler.Size = new System.Drawing.Size(98, 31);
            this.buttonStartDoppler.TabIndex = 50;
            this.buttonStartDoppler.Text = "Start";
            this.buttonStartDoppler.UseVisualStyleBackColor = true;
            this.buttonStartDoppler.Click += new System.EventHandler(this.buttonStartDoppler_Click);
            // 
            // buttonStopDoppler
            // 
            this.buttonStopDoppler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonStopDoppler.Location = new System.Drawing.Point(174, 217);
            this.buttonStopDoppler.Name = "buttonStopDoppler";
            this.buttonStopDoppler.Size = new System.Drawing.Size(98, 31);
            this.buttonStopDoppler.TabIndex = 51;
            this.buttonStopDoppler.Text = "Stop";
            this.buttonStopDoppler.UseVisualStyleBackColor = true;
            this.buttonStopDoppler.Click += new System.EventHandler(this.buttonStopDoppler_Click);
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCalculate.Location = new System.Drawing.Point(311, 217);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(98, 31);
            this.buttonCalculate.TabIndex = 52;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonHide.Location = new System.Drawing.Point(613, 217);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(158, 31);
            this.buttonHide.TabIndex = 53;
            this.buttonHide.Text = "Hide module";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // showDoplerEffectModuleToolStripMenuItem
            // 
            this.showDoplerEffectModuleToolStripMenuItem.CheckOnClick = true;
            this.showDoplerEffectModuleToolStripMenuItem.Name = "showDoplerEffectModuleToolStripMenuItem";
            this.showDoplerEffectModuleToolStripMenuItem.Size = new System.Drawing.Size(466, 24);
            this.showDoplerEffectModuleToolStripMenuItem.Text = "Show Doppler Effect Module";
            this.showDoplerEffectModuleToolStripMenuItem.Click += new System.EventHandler(this.showDoplerEffectModuleToolStripMenuItem_Click);
            // 
            // labelDopplerTime
            // 
            this.labelDopplerTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDopplerTime.Location = new System.Drawing.Point(595, 48);
            this.labelDopplerTime.Name = "labelDopplerTime";
            this.labelDopplerTime.Size = new System.Drawing.Size(176, 20);
            this.labelDopplerTime.TabIndex = 54;
            this.labelDopplerTime.Text = "label6";
            this.labelDopplerTime.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelDopplerFrequency
            // 
            this.labelDopplerFrequency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDopplerFrequency.Location = new System.Drawing.Point(595, 133);
            this.labelDopplerFrequency.Name = "labelDopplerFrequency";
            this.labelDopplerFrequency.Size = new System.Drawing.Size(176, 20);
            this.labelDopplerFrequency.TabIndex = 55;
            this.labelDopplerFrequency.Text = "label7";
            this.labelDopplerFrequency.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timerDoppler
            // 
            this.timerDoppler.Tick += new System.EventHandler(this.timerDoppler_Tick);
            // 
            // s11
            // 
            this.s11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s11.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s11.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s11.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.s11.CustomPattern = 0;
            this.s11.DecimalOn = false;
            this.s11.DecimalShow = false;
            this.s11.DoubleDot = false;
            this.s11.ElementWidth = 10;
            this.s11.ItalicFactor = 0F;
            this.s11.Location = new System.Drawing.Point(7, 9);
            this.s11.Name = "s11";
            this.s11.Padding = new System.Windows.Forms.Padding(4);
            this.s11.Size = new System.Drawing.Size(44, 64);
            this.s11.TabIndex = 11;
            this.s11.TabStop = false;
            this.s11.Tag = "100000000000";
            this.s11.Value = null;
            this.s11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s10
            // 
            this.s10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s10.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s10.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s10.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.s10.CustomPattern = 0;
            this.s10.DecimalOn = false;
            this.s10.DecimalShow = false;
            this.s10.DoubleDot = false;
            this.s10.ElementWidth = 10;
            this.s10.ItalicFactor = 0F;
            this.s10.Location = new System.Drawing.Point(57, 9);
            this.s10.Name = "s10";
            this.s10.Padding = new System.Windows.Forms.Padding(4);
            this.s10.Size = new System.Drawing.Size(44, 64);
            this.s10.TabIndex = 12;
            this.s10.TabStop = false;
            this.s10.Tag = "10000000000";
            this.s10.Value = null;
            this.s10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s9
            // 
            this.s9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s9.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s9.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s9.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.s9.CustomPattern = 0;
            this.s9.DecimalOn = false;
            this.s9.DecimalShow = false;
            this.s9.DoubleDot = false;
            this.s9.ElementWidth = 10;
            this.s9.ItalicFactor = 0F;
            this.s9.Location = new System.Drawing.Point(107, 9);
            this.s9.Name = "s9";
            this.s9.Padding = new System.Windows.Forms.Padding(4);
            this.s9.Size = new System.Drawing.Size(44, 64);
            this.s9.TabIndex = 13;
            this.s9.TabStop = false;
            this.s9.Tag = "1000000000";
            this.s9.Value = null;
            this.s9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s8
            // 
            this.s8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s8.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s8.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s8.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s8.CustomPattern = 0;
            this.s8.DecimalOn = false;
            this.s8.DecimalShow = false;
            this.s8.DoubleDot = false;
            this.s8.ElementWidth = 10;
            this.s8.ItalicFactor = 0F;
            this.s8.Location = new System.Drawing.Point(178, 9);
            this.s8.Name = "s8";
            this.s8.Padding = new System.Windows.Forms.Padding(4);
            this.s8.Size = new System.Drawing.Size(44, 64);
            this.s8.TabIndex = 1;
            this.s8.TabStop = false;
            this.s8.Tag = "100000000";
            this.s8.Value = null;
            this.s8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s7
            // 
            this.s7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s7.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s7.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s7.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s7.CustomPattern = 0;
            this.s7.DecimalOn = false;
            this.s7.DecimalShow = false;
            this.s7.DoubleDot = false;
            this.s7.ElementWidth = 10;
            this.s7.ItalicFactor = 0F;
            this.s7.Location = new System.Drawing.Point(228, 9);
            this.s7.Name = "s7";
            this.s7.Padding = new System.Windows.Forms.Padding(4);
            this.s7.Size = new System.Drawing.Size(44, 64);
            this.s7.TabIndex = 2;
            this.s7.TabStop = false;
            this.s7.Tag = "10000000";
            this.s7.Value = null;
            this.s7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s6
            // 
            this.s6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s6.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s6.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s6.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s6.CustomPattern = 0;
            this.s6.DecimalOn = false;
            this.s6.DecimalShow = false;
            this.s6.DoubleDot = false;
            this.s6.ElementWidth = 10;
            this.s6.ItalicFactor = 0F;
            this.s6.Location = new System.Drawing.Point(278, 9);
            this.s6.Name = "s6";
            this.s6.Padding = new System.Windows.Forms.Padding(4);
            this.s6.Size = new System.Drawing.Size(44, 64);
            this.s6.TabIndex = 3;
            this.s6.TabStop = false;
            this.s6.Tag = "1000000";
            this.s6.Value = null;
            this.s6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s5
            // 
            this.s5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s5.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s5.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s5.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.s5.CustomPattern = 0;
            this.s5.DecimalOn = false;
            this.s5.DecimalShow = false;
            this.s5.DoubleDot = false;
            this.s5.ElementWidth = 10;
            this.s5.ItalicFactor = 0F;
            this.s5.Location = new System.Drawing.Point(349, 9);
            this.s5.Name = "s5";
            this.s5.Padding = new System.Windows.Forms.Padding(4);
            this.s5.Size = new System.Drawing.Size(44, 64);
            this.s5.TabIndex = 4;
            this.s5.TabStop = false;
            this.s5.Tag = "100000";
            this.s5.Value = null;
            this.s5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s4
            // 
            this.s4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s4.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s4.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s4.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.s4.CustomPattern = 0;
            this.s4.DecimalOn = false;
            this.s4.DecimalShow = false;
            this.s4.DoubleDot = false;
            this.s4.ElementWidth = 10;
            this.s4.ItalicFactor = 0F;
            this.s4.Location = new System.Drawing.Point(399, 9);
            this.s4.Name = "s4";
            this.s4.Padding = new System.Windows.Forms.Padding(4);
            this.s4.Size = new System.Drawing.Size(44, 64);
            this.s4.TabIndex = 5;
            this.s4.TabStop = false;
            this.s4.Tag = "10000";
            this.s4.Value = null;
            this.s4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s3
            // 
            this.s3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s3.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s3.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s3.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.s3.CustomPattern = 0;
            this.s3.DecimalOn = false;
            this.s3.DecimalShow = false;
            this.s3.DoubleDot = false;
            this.s3.ElementWidth = 10;
            this.s3.ItalicFactor = 0F;
            this.s3.Location = new System.Drawing.Point(449, 9);
            this.s3.Name = "s3";
            this.s3.Padding = new System.Windows.Forms.Padding(4);
            this.s3.Size = new System.Drawing.Size(44, 64);
            this.s3.TabIndex = 6;
            this.s3.TabStop = false;
            this.s3.Tag = "1000";
            this.s3.Value = null;
            this.s3.Load += new System.EventHandler(this.s3_Load);
            this.s3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s2
            // 
            this.s2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s2.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s2.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s2.CustomPattern = 0;
            this.s2.DecimalOn = false;
            this.s2.DecimalShow = false;
            this.s2.DoubleDot = false;
            this.s2.ElementWidth = 10;
            this.s2.ItalicFactor = 0F;
            this.s2.Location = new System.Drawing.Point(513, 9);
            this.s2.Name = "s2";
            this.s2.Padding = new System.Windows.Forms.Padding(4);
            this.s2.Size = new System.Drawing.Size(44, 64);
            this.s2.TabIndex = 7;
            this.s2.TabStop = false;
            this.s2.Tag = "100";
            this.s2.Value = null;
            this.s2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s1
            // 
            this.s1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s1.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s1.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s1.CustomPattern = 0;
            this.s1.DecimalOn = false;
            this.s1.DecimalShow = false;
            this.s1.DoubleDot = false;
            this.s1.ElementWidth = 10;
            this.s1.ItalicFactor = 0F;
            this.s1.Location = new System.Drawing.Point(563, 9);
            this.s1.Name = "s1";
            this.s1.Padding = new System.Windows.Forms.Padding(4);
            this.s1.Size = new System.Drawing.Size(44, 64);
            this.s1.TabIndex = 8;
            this.s1.TabStop = false;
            this.s1.Tag = "10";
            this.s1.Value = null;
            this.s1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // s0
            // 
            this.s0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.s0.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s0.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s0.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s0.CustomPattern = 0;
            this.s0.DecimalOn = true;
            this.s0.DecimalShow = false;
            this.s0.DoubleDot = false;
            this.s0.ElementWidth = 10;
            this.s0.ItalicFactor = 0F;
            this.s0.Location = new System.Drawing.Point(613, 9);
            this.s0.Name = "s0";
            this.s0.Padding = new System.Windows.Forms.Padding(4);
            this.s0.Size = new System.Drawing.Size(44, 64);
            this.s0.TabIndex = 9;
            this.s0.TabStop = false;
            this.s0.Tag = "1";
            this.s0.Value = null;
            this.s0.MouseDown += new System.Windows.Forms.MouseEventHandler(this.s1_MouseDown);
            this.s0.MouseUp += new System.Windows.Forms.MouseEventHandler(this.s1_MouseUp);
            // 
            // sDot
            // 
            this.sDot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sDot.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sDot.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sDot.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sDot.CustomPattern = 0;
            this.sDot.DecimalOn = true;
            this.sDot.DecimalShow = true;
            this.sDot.DoubleDot = false;
            this.sDot.ElementWidth = 10;
            this.sDot.ItalicFactor = 0F;
            this.sDot.Location = new System.Drawing.Point(495, 9);
            this.sDot.Name = "sDot";
            this.sDot.Padding = new System.Windows.Forms.Padding(4);
            this.sDot.Size = new System.Drawing.Size(44, 64);
            this.sDot.TabIndex = 10;
            this.sDot.TabStop = false;
            this.sDot.Value = null;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(825, 459);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.Text = "Simple CAT controller (c)\'2023 Tomasz Fronczek SP4THK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelDoppler.ResumeLayout(false);
            this.panelDoppler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDopplerFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDopplerTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private SevenSegment s8;
        private System.Windows.Forms.Panel panel1;
        private SevenSegment s6;
        private SevenSegment s7;
        private SevenSegment s0;
        private SevenSegment s1;
        private SevenSegment s2;
        private SevenSegment s3;
        private SevenSegment s4;
        private SevenSegment s5;
        private SevenSegment sDot;
        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button button500;
        private System.Windows.Forms.Button button000;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ComboBox comboBoxBand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRig;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectRig1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectRig2ToolStripMenuItem;
        private System.Windows.Forms.Button buttonTX;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideInTaskBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tXOnlyWhenPressedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXOnCharToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem onBandChangedSlelectDefaultSSBModeToolStripMenuItem;
        private System.Windows.Forms.Label labelErr;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem hideWindowHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureControlUDPPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runCameraModuleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNTPTimeSyncOnStartToolStripMenuItem;
        private System.Windows.Forms.Timer timerNTP;
        private SevenSegment s11;
        private SevenSegment s10;
        private SevenSegment s9;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transponderModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workWithTransponderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transponderOfffsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.Panel panelDoppler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarDopplerFrequency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonStopDoppler;
        private System.Windows.Forms.Button buttonStartDoppler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarDopplerTime;
        private System.Windows.Forms.Button buttonHide;
        private System.Windows.Forms.ToolStripMenuItem showDoplerEffectModuleToolStripMenuItem;
        private System.Windows.Forms.Label labelDopplerFrequency;
        private System.Windows.Forms.Label labelDopplerTime;
        private System.Windows.Forms.Timer timerDoppler;
    }
}

