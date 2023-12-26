namespace CAT_CAMERA
{
    partial class Camera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelVideo = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.One = new System.Windows.Forms.ToolStripMenuItem();
            this.Half = new System.Windows.Forms.ToolStripMenuItem();
            this.Quarter = new System.Windows.Forms.ToolStripMenuItem();
            this.fitWidthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fitHeightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.hideInTaskBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideWindowHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDPStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VideoDevicesBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VideoCodecsBox = new System.Windows.Forms.ComboBox();
            this.VideoSizeBox = new System.Windows.Forms.ComboBox();
            this.FrameRateBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCFG = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panelCFG.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelVideo
            // 
            this.panelVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panelVideo.ContextMenuStrip = this.contextMenuStrip1;
            this.panelVideo.Location = new System.Drawing.Point(3, 12);
            this.panelVideo.Margin = new System.Windows.Forms.Padding(4);
            this.panelVideo.Name = "panelVideo";
            this.panelVideo.Size = new System.Drawing.Size(510, 336);
            this.panelVideo.TabIndex = 0;
            this.panelVideo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelVideo.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.panelVideo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelVideo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sizeToolStripMenuItem,
            this.One,
            this.Half,
            this.Quarter,
            this.fitWidthToolStripMenuItem,
            this.fitHeightToolStripMenuItem,
            this.toolStripMenuItem2,
            this.hideInTaskBarToolStripMenuItem,
            this.alwaysOnTopToolStripMenuItem,
            this.hideWindowHeaderToolStripMenuItem,
            this.uDPStatusToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(223, 310);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.configureToolStripMenuItem.Text = "Configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.Config_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(219, 6);
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.Enabled = false;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // One
            // 
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(222, 24);
            this.One.Text = "1:1";
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Half
            // 
            this.Half.Name = "Half";
            this.Half.Size = new System.Drawing.Size(222, 24);
            this.Half.Text = "1/2";
            this.Half.Click += new System.EventHandler(this.One_Click);
            // 
            // Quarter
            // 
            this.Quarter.Name = "Quarter";
            this.Quarter.Size = new System.Drawing.Size(222, 24);
            this.Quarter.Text = "1/4";
            this.Quarter.Click += new System.EventHandler(this.One_Click);
            // 
            // fitWidthToolStripMenuItem
            // 
            this.fitWidthToolStripMenuItem.Name = "fitWidthToolStripMenuItem";
            this.fitWidthToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.fitWidthToolStripMenuItem.Text = "Fit Width";
            this.fitWidthToolStripMenuItem.Click += new System.EventHandler(this.fitWidthToolStripMenuItem_Click);
            // 
            // fitHeightToolStripMenuItem
            // 
            this.fitHeightToolStripMenuItem.Name = "fitHeightToolStripMenuItem";
            this.fitHeightToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.fitHeightToolStripMenuItem.Text = "Fit Height";
            this.fitHeightToolStripMenuItem.Click += new System.EventHandler(this.fitHeightToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(219, 6);
            // 
            // hideInTaskBarToolStripMenuItem
            // 
            this.hideInTaskBarToolStripMenuItem.CheckOnClick = true;
            this.hideInTaskBarToolStripMenuItem.Name = "hideInTaskBarToolStripMenuItem";
            this.hideInTaskBarToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.hideInTaskBarToolStripMenuItem.Text = "Hide In Task Bar";
            this.hideInTaskBarToolStripMenuItem.Click += new System.EventHandler(this.hideInTaskBarToolStripMenuItem_Click);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // hideWindowHeaderToolStripMenuItem
            // 
            this.hideWindowHeaderToolStripMenuItem.CheckOnClick = true;
            this.hideWindowHeaderToolStripMenuItem.Name = "hideWindowHeaderToolStripMenuItem";
            this.hideWindowHeaderToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.hideWindowHeaderToolStripMenuItem.Text = "Hide Window Header";
            this.hideWindowHeaderToolStripMenuItem.Click += new System.EventHandler(this.hideWindowHeaderToolStripMenuItem_Click);
            // 
            // uDPStatusToolStripMenuItem
            // 
            this.uDPStatusToolStripMenuItem.Enabled = false;
            this.uDPStatusToolStripMenuItem.Name = "uDPStatusToolStripMenuItem";
            this.uDPStatusToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.uDPStatusToolStripMenuItem.Text = "UDP status:";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(219, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(222, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // VideoDevicesBox
            // 
            this.VideoDevicesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VideoDevicesBox.FormattingEnabled = true;
            this.VideoDevicesBox.Location = new System.Drawing.Point(19, 28);
            this.VideoDevicesBox.Margin = new System.Windows.Forms.Padding(4);
            this.VideoDevicesBox.Name = "VideoDevicesBox";
            this.VideoDevicesBox.Size = new System.Drawing.Size(427, 28);
            this.VideoDevicesBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Video Device";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Video Codec";
            // 
            // VideoCodecsBox
            // 
            this.VideoCodecsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VideoCodecsBox.FormattingEnabled = true;
            this.VideoCodecsBox.Location = new System.Drawing.Point(19, 219);
            this.VideoCodecsBox.Margin = new System.Windows.Forms.Padding(4);
            this.VideoCodecsBox.Name = "VideoCodecsBox";
            this.VideoCodecsBox.Size = new System.Drawing.Size(427, 28);
            this.VideoCodecsBox.TabIndex = 8;
            this.VideoCodecsBox.SelectedIndexChanged += new System.EventHandler(this.VideoCodecsBox_SelectedIndexChanged);
            // 
            // VideoSizeBox
            // 
            this.VideoSizeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VideoSizeBox.FormattingEnabled = true;
            this.VideoSizeBox.Items.AddRange(new object[] {
            "320x240",
            "352x288",
            "640x480",
            "704x576",
            "720x576",
            "764x576",
            "800x400",
            "800x600",
            "1024x768",
            "1280x720",
            "1920x1080",
            "2560x1440",
            "3840x2160"});
            this.VideoSizeBox.Location = new System.Drawing.Point(142, 88);
            this.VideoSizeBox.Margin = new System.Windows.Forms.Padding(4);
            this.VideoSizeBox.Name = "VideoSizeBox";
            this.VideoSizeBox.Size = new System.Drawing.Size(144, 28);
            this.VideoSizeBox.TabIndex = 21;
            // 
            // FrameRateBox
            // 
            this.FrameRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FrameRateBox.FormattingEnabled = true;
            this.FrameRateBox.Items.AddRange(new object[] {
            "5 (DVR)",
            "15 (econo)",
            "24 (film)",
            "25 (PAL)",
            "29.997 (NTSC)",
            "30 (~NTSC)"});
            this.FrameRateBox.Location = new System.Drawing.Point(142, 136);
            this.FrameRateBox.Margin = new System.Windows.Forms.Padding(4);
            this.FrameRateBox.Name = "FrameRateBox";
            this.FrameRateBox.Size = new System.Drawing.Size(144, 28);
            this.FrameRateBox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 91);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Video size";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 26;
            this.label10.Text = "Framerate";
            // 
            // panelCFG
            // 
            this.panelCFG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelCFG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCFG.Controls.Add(this.buttonBack);
            this.panelCFG.Controls.Add(this.VideoCodecsBox);
            this.panelCFG.Controls.Add(this.VideoDevicesBox);
            this.panelCFG.Controls.Add(this.label1);
            this.panelCFG.Controls.Add(this.label4);
            this.panelCFG.Controls.Add(this.label10);
            this.panelCFG.Controls.Add(this.label9);
            this.panelCFG.Controls.Add(this.FrameRateBox);
            this.panelCFG.Controls.Add(this.VideoSizeBox);
            this.panelCFG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCFG.Location = new System.Drawing.Point(542, 12);
            this.panelCFG.Margin = new System.Windows.Forms.Padding(4);
            this.panelCFG.Name = "panelCFG";
            this.panelCFG.Size = new System.Drawing.Size(542, 323);
            this.panelCFG.TabIndex = 38;
            this.panelCFG.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panelCFG.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.panelCFG.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panelCFG.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Silver;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.Location = new System.Drawing.Point(19, 271);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(94, 36);
            this.buttonBack.TabIndex = 53;
            this.buttonBack.Text = "< Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.Back_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelCFG);
            this.panel1.Controls.Add(this.panelVideo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(1103, 669);
            this.panel1.TabIndex = 42;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.ContextMenuStrip = this.contextMenuStrip1;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(507, 404);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(323, 85);
            this.label14.TabIndex = 0;
            this.label14.Text = "NO VIDEO !!!\r\nOR VIDEO PROPETERIES ARE BAD !!!\r\nRight mouse click -> menu";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label14.Visible = false;
            // 
            // Camera
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1107, 673);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Camera";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CAT Camera Copyright © ELFRO Tomasz Fronczek SP4THK";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Camera_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Camera_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelCFG.ResumeLayout(false);
            this.panelCFG.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelVideo;
        private System.Windows.Forms.ComboBox VideoDevicesBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VideoCodecsBox;
        private System.Windows.Forms.ComboBox VideoSizeBox;
        private System.Windows.Forms.ComboBox FrameRateBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelCFG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem One;
        private System.Windows.Forms.ToolStripMenuItem Half;
        private System.Windows.Forms.ToolStripMenuItem Quarter;
        private System.Windows.Forms.ToolStripMenuItem fitWidthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fitHeightToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hideWindowHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideInTaskBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uDPStatusToolStripMenuItem;
    }
}

