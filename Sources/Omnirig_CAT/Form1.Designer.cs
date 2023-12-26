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
            this.hideInTaskBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWindowHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runCameraModuleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureControlUDPPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.runNTPTimeSyncOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerNTP = new System.Windows.Forms.Timer(this.components);
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
            this.panel1.Size = new System.Drawing.Size(629, 151);
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
            this.panel2.Size = new System.Drawing.Size(486, 86);
            this.panel2.TabIndex = 50;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMenu.Location = new System.Drawing.Point(554, 114);
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
            this.buttonTX.Location = new System.Drawing.Point(573, 38);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(395, 320);
            // 
            // selectRig1ToolStripMenuItem
            // 
            this.selectRig1ToolStripMenuItem.CheckOnClick = true;
            this.selectRig1ToolStripMenuItem.Name = "selectRig1ToolStripMenuItem";
            this.selectRig1ToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.selectRig1ToolStripMenuItem.Text = "Select Rig 1";
            this.selectRig1ToolStripMenuItem.Click += new System.EventHandler(this.selectRig1ToolStripMenuItem_Click);
            // 
            // selectRig2ToolStripMenuItem
            // 
            this.selectRig2ToolStripMenuItem.CheckOnClick = true;
            this.selectRig2ToolStripMenuItem.Name = "selectRig2ToolStripMenuItem";
            this.selectRig2ToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.selectRig2ToolStripMenuItem.Text = "Select Rig 2";
            this.selectRig2ToolStripMenuItem.Click += new System.EventHandler(this.selectRig2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(391, 6);
            // 
            // hideInTaskBarToolStripMenuItem
            // 
            this.hideInTaskBarToolStripMenuItem.CheckOnClick = true;
            this.hideInTaskBarToolStripMenuItem.Name = "hideInTaskBarToolStripMenuItem";
            this.hideInTaskBarToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.hideInTaskBarToolStripMenuItem.Text = "Hide in Task Bar";
            this.hideInTaskBarToolStripMenuItem.Click += new System.EventHandler(this.hideInTaskBarToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // hideWindowHeaderToolStripMenuItem
            // 
            this.hideWindowHeaderToolStripMenuItem.CheckOnClick = true;
            this.hideWindowHeaderToolStripMenuItem.Name = "hideWindowHeaderToolStripMenuItem";
            this.hideWindowHeaderToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.hideWindowHeaderToolStripMenuItem.Text = "Hide Window Header";
            this.hideWindowHeaderToolStripMenuItem.Click += new System.EventHandler(this.hideWindowHeaderToolStripMenuItem_Click);
            // 
            // cameraModuleToolStripMenuItem
            // 
            this.cameraModuleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runCameraModuleToolStripMenuItem,
            this.configureControlUDPPortToolStripMenuItem});
            this.cameraModuleToolStripMenuItem.Name = "cameraModuleToolStripMenuItem";
            this.cameraModuleToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
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
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(391, 6);
            // 
            // tXOnlyWhenPressedToolStripMenuItem
            // 
            this.tXOnlyWhenPressedToolStripMenuItem.CheckOnClick = true;
            this.tXOnlyWhenPressedToolStripMenuItem.Name = "tXOnlyWhenPressedToolStripMenuItem";
            this.tXOnlyWhenPressedToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.tXOnlyWhenPressedToolStripMenuItem.Text = "TX only when pressed";
            // 
            // tXOnCharToolStripMenuItem
            // 
            this.tXOnCharToolStripMenuItem.CheckOnClick = true;
            this.tXOnCharToolStripMenuItem.Name = "tXOnCharToolStripMenuItem";
            this.tXOnCharToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.tXOnCharToolStripMenuItem.Text = "TX on \"\\\" keyboard pressed";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(391, 6);
            // 
            // onBandChangedSlelectDefaultSSBModeToolStripMenuItem
            // 
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.CheckOnClick = true;
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Name = "onBandChangedSlelectDefaultSSBModeToolStripMenuItem";
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.onBandChangedSlelectDefaultSSBModeToolStripMenuItem.Text = "On User Band changed select default SSB Mode";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(391, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
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
            this.comboBoxMode.Location = new System.Drawing.Point(380, 118);
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
            this.label3.Location = new System.Drawing.Point(319, 129);
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
            this.button500.Location = new System.Drawing.Point(503, 74);
            this.button500.Name = "button500";
            this.button500.Size = new System.Drawing.Size(53, 28);
            this.button500.TabIndex = 40;
            this.button500.Text = "500";
            this.button500.UseVisualStyleBackColor = true;
            this.button500.Click += new System.EventHandler(this.button500_Click);
            // 
            // button000
            // 
            this.button000.Location = new System.Drawing.Point(503, 38);
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
            this.labelMode.Location = new System.Drawing.Point(338, 3);
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
            this.labelErr.Location = new System.Drawing.Point(534, 2);
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
            // runNTPTimeSyncOnStartToolStripMenuItem
            // 
            this.runNTPTimeSyncOnStartToolStripMenuItem.CheckOnClick = true;
            this.runNTPTimeSyncOnStartToolStripMenuItem.Name = "runNTPTimeSyncOnStartToolStripMenuItem";
            this.runNTPTimeSyncOnStartToolStripMenuItem.Size = new System.Drawing.Size(394, 24);
            this.runNTPTimeSyncOnStartToolStripMenuItem.Text = "Run NTP Time sync on start";
            // 
            // timerNTP
            // 
            this.timerNTP.Interval = 500;
            this.timerNTP.Tick += new System.EventHandler(this.timerNTP_Tick);
            // 
            // s8
            // 
            this.s8.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s8.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s8.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s8.CustomPattern = 0;
            this.s8.DecimalOn = false;
            this.s8.DecimalShow = false;
            this.s8.DoubleDot = false;
            this.s8.ElementWidth = 10;
            this.s8.ItalicFactor = 0F;
            this.s8.Location = new System.Drawing.Point(7, 9);
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
            this.s7.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s7.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s7.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s7.CustomPattern = 0;
            this.s7.DecimalOn = false;
            this.s7.DecimalShow = false;
            this.s7.DoubleDot = false;
            this.s7.ElementWidth = 10;
            this.s7.ItalicFactor = 0F;
            this.s7.Location = new System.Drawing.Point(57, 9);
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
            this.s6.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s6.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s6.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s6.CustomPattern = 0;
            this.s6.DecimalOn = false;
            this.s6.DecimalShow = false;
            this.s6.DoubleDot = false;
            this.s6.ElementWidth = 10;
            this.s6.ItalicFactor = 0F;
            this.s6.Location = new System.Drawing.Point(107, 9);
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
            this.s5.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s5.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s5.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s5.CustomPattern = 0;
            this.s5.DecimalOn = false;
            this.s5.DecimalShow = false;
            this.s5.DoubleDot = false;
            this.s5.ElementWidth = 10;
            this.s5.ItalicFactor = 0F;
            this.s5.Location = new System.Drawing.Point(166, 9);
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
            this.s4.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s4.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s4.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s4.CustomPattern = 0;
            this.s4.DecimalOn = false;
            this.s4.DecimalShow = false;
            this.s4.DoubleDot = false;
            this.s4.ElementWidth = 10;
            this.s4.ItalicFactor = 0F;
            this.s4.Location = new System.Drawing.Point(216, 9);
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
            this.s3.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s3.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s3.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.s3.CustomPattern = 0;
            this.s3.DecimalOn = false;
            this.s3.DecimalShow = false;
            this.s3.DoubleDot = false;
            this.s3.ElementWidth = 10;
            this.s3.ItalicFactor = 0F;
            this.s3.Location = new System.Drawing.Point(266, 9);
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
            this.s2.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s2.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s2.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s2.CustomPattern = 0;
            this.s2.DecimalOn = false;
            this.s2.DecimalShow = false;
            this.s2.DoubleDot = false;
            this.s2.ElementWidth = 10;
            this.s2.ItalicFactor = 0F;
            this.s2.Location = new System.Drawing.Point(325, 9);
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
            this.s1.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s1.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s1.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s1.CustomPattern = 0;
            this.s1.DecimalOn = false;
            this.s1.DecimalShow = false;
            this.s1.DoubleDot = false;
            this.s1.ElementWidth = 10;
            this.s1.ItalicFactor = 0F;
            this.s1.Location = new System.Drawing.Point(375, 9);
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
            this.s0.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.s0.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.s0.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.s0.CustomPattern = 0;
            this.s0.DecimalOn = true;
            this.s0.DecimalShow = false;
            this.s0.DoubleDot = false;
            this.s0.ElementWidth = 10;
            this.s0.ItalicFactor = 0F;
            this.s0.Location = new System.Drawing.Point(425, 9);
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
            this.sDot.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.sDot.ColorDark = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.sDot.ColorLight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sDot.CustomPattern = 0;
            this.sDot.DecimalOn = true;
            this.sDot.DecimalShow = true;
            this.sDot.DoubleDot = false;
            this.sDot.ElementWidth = 10;
            this.sDot.ItalicFactor = 0F;
            this.sDot.Location = new System.Drawing.Point(307, 9);
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
            this.ClientSize = new System.Drawing.Size(631, 153);
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
    }
}

