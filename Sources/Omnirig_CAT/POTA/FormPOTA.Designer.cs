namespace POTA_To_CAT
{
    partial class FormPOTA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelQRZNowFlag = new System.Windows.Forms.Panel();
            this.buttonMoreQrzInfo = new System.Windows.Forms.Button();
            this.panelCFG = new System.Windows.Forms.Panel();
            this.panelCFGImg = new System.Windows.Forms.Panel();
            this.labelQRZLoading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelQRZflag = new System.Windows.Forms.Panel();
            this.textBoxQRZCountry = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQRZName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonQueryQRZ = new System.Windows.Forms.Button();
            this.textBoxQRZ = new System.Windows.Forms.TextBox();
            this.checkBoxAutoQRZ = new System.Windows.Forms.CheckBox();
            this.labelHelp = new System.Windows.Forms.Label();
            this.panelSP = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRefreshingMin = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelPOTA = new System.Windows.Forms.Panel();
            this.radioButtonSPOTS = new System.Windows.Forms.RadioButton();
            this.radioButtonACTIVATIONS = new System.Windows.Forms.RadioButton();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLoading = new System.Windows.Forms.Label();
            this.labelNotLoaded = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyCallSignToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyFrequencyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.copyCellcurrentValueToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyRowToClipboardcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllRowsToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllRowsToClipboardcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.showInQRZcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.timerHideHelp = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spotName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spotter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCFG.SuspendLayout();
            this.panelSP.SuspendLayout();
            this.panelPOTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.labelHelp);
            this.panel1.Controls.Add(this.panelSP);
            this.panel1.Controls.Add(this.labelLoading);
            this.panel1.Controls.Add(this.labelNotLoaded);
            this.panel1.Controls.Add(this.textBoxLog);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1766, 656);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelQRZNowFlag);
            this.panel2.Controls.Add(this.buttonMoreQrzInfo);
            this.panel2.Controls.Add(this.panelCFG);
            this.panel2.Controls.Add(this.labelQRZLoading);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panelQRZflag);
            this.panel2.Controls.Add(this.textBoxQRZCountry);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxQRZName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.buttonQueryQRZ);
            this.panel2.Controls.Add(this.textBoxQRZ);
            this.panel2.Controls.Add(this.checkBoxAutoQRZ);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel2.Location = new System.Drawing.Point(0, 617);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1766, 39);
            this.panel2.TabIndex = 70;
            // 
            // panelQRZNowFlag
            // 
            this.panelQRZNowFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelQRZNowFlag.Location = new System.Drawing.Point(1515, 3);
            this.panelQRZNowFlag.Name = "panelQRZNowFlag";
            this.panelQRZNowFlag.Size = new System.Drawing.Size(32, 32);
            this.panelQRZNowFlag.TabIndex = 71;
            // 
            // buttonMoreQrzInfo
            // 
            this.buttonMoreQrzInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoreQrzInfo.Location = new System.Drawing.Point(1591, 4);
            this.buttonMoreQrzInfo.Name = "buttonMoreQrzInfo";
            this.buttonMoreQrzInfo.Size = new System.Drawing.Size(96, 29);
            this.buttonMoreQrzInfo.TabIndex = 67;
            this.buttonMoreQrzInfo.Text = "More info";
            this.buttonMoreQrzInfo.UseVisualStyleBackColor = true;
            this.buttonMoreQrzInfo.Click += new System.EventHandler(this.buttonMoreQrzInfo_Click);
            // 
            // panelCFG
            // 
            this.panelCFG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCFG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCFG.Controls.Add(this.panelCFGImg);
            this.panelCFG.Location = new System.Drawing.Point(1693, 3);
            this.panelCFG.Name = "panelCFG";
            this.panelCFG.Padding = new System.Windows.Forms.Padding(2);
            this.panelCFG.Size = new System.Drawing.Size(32, 32);
            this.panelCFG.TabIndex = 66;
            this.panelCFG.Click += new System.EventHandler(this.panelCFG_Click);
            // 
            // panelCFGImg
            // 
            this.panelCFGImg.BackgroundImage = global::Omnirig_CAT.Properties.Resources.settings_icon_14970;
            this.panelCFGImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelCFGImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCFGImg.Location = new System.Drawing.Point(2, 2);
            this.panelCFGImg.Name = "panelCFGImg";
            this.panelCFGImg.Size = new System.Drawing.Size(26, 26);
            this.panelCFGImg.TabIndex = 66;
            this.panelCFGImg.Click += new System.EventHandler(this.panelCFG_Click);
            // 
            // labelQRZLoading
            // 
            this.labelQRZLoading.BackColor = System.Drawing.Color.Olive;
            this.labelQRZLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQRZLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelQRZLoading.Location = new System.Drawing.Point(943, 9);
            this.labelQRZLoading.Name = "labelQRZLoading";
            this.labelQRZLoading.Size = new System.Drawing.Size(98, 23);
            this.labelQRZLoading.TabIndex = 65;
            this.labelQRZLoading.Text = "Loading ...";
            this.labelQRZLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQRZLoading.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "Callsign:";
            // 
            // panelQRZflag
            // 
            this.panelQRZflag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelQRZflag.Location = new System.Drawing.Point(1553, 3);
            this.panelQRZflag.Name = "panelQRZflag";
            this.panelQRZflag.Size = new System.Drawing.Size(32, 32);
            this.panelQRZflag.TabIndex = 62;
            // 
            // textBoxQRZCountry
            // 
            this.textBoxQRZCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxQRZCountry.Location = new System.Drawing.Point(1125, 5);
            this.textBoxQRZCountry.Name = "textBoxQRZCountry";
            this.textBoxQRZCountry.Size = new System.Drawing.Size(385, 27);
            this.textBoxQRZCountry.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1047, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Country:";
            // 
            // textBoxQRZName
            // 
            this.textBoxQRZName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxQRZName.Location = new System.Drawing.Point(760, 5);
            this.textBoxQRZName.Name = "textBoxQRZName";
            this.textBoxQRZName.Size = new System.Drawing.Size(281, 27);
            this.textBoxQRZName.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(696, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Name:";
            // 
            // buttonQueryQRZ
            // 
            this.buttonQueryQRZ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonQueryQRZ.Location = new System.Drawing.Point(593, 5);
            this.buttonQueryQRZ.Name = "buttonQueryQRZ";
            this.buttonQueryQRZ.Size = new System.Drawing.Size(75, 29);
            this.buttonQueryQRZ.TabIndex = 57;
            this.buttonQueryQRZ.Text = "Query";
            this.buttonQueryQRZ.UseVisualStyleBackColor = true;
            this.buttonQueryQRZ.Click += new System.EventHandler(this.buttonQueryQRZ_Click);
            // 
            // textBoxQRZ
            // 
            this.textBoxQRZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxQRZ.Location = new System.Drawing.Point(353, 5);
            this.textBoxQRZ.Name = "textBoxQRZ";
            this.textBoxQRZ.Size = new System.Drawing.Size(217, 27);
            this.textBoxQRZ.TabIndex = 56;
            // 
            // checkBoxAutoQRZ
            // 
            this.checkBoxAutoQRZ.AutoSize = true;
            this.checkBoxAutoQRZ.Location = new System.Drawing.Point(14, 6);
            this.checkBoxAutoQRZ.Name = "checkBoxAutoQRZ";
            this.checkBoxAutoQRZ.Size = new System.Drawing.Size(181, 24);
            this.checkBoxAutoQRZ.TabIndex = 0;
            this.checkBoxAutoQRZ.Text = "Automatic QRZ info.";
            this.checkBoxAutoQRZ.UseVisualStyleBackColor = true;
            // 
            // labelHelp
            // 
            this.labelHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHelp.Location = new System.Drawing.Point(1011, 93);
            this.labelHelp.Name = "labelHelp";
            this.labelHelp.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.labelHelp.Size = new System.Drawing.Size(734, 40);
            this.labelHelp.TabIndex = 69;
            this.labelHelp.Text = "Double click on row change Frequency and copy CallSign to clipboard";
            this.labelHelp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelHelp.Visible = false;
            this.labelHelp.Click += new System.EventHandler(this.timerHideHelp_Tick);
            // 
            // panelSP
            // 
            this.panelSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSP.Controls.Add(this.comboBox1);
            this.panelSP.Controls.Add(this.buttonRefreshingMin);
            this.panelSP.Controls.Add(this.buttonRefresh);
            this.panelSP.Controls.Add(this.button3);
            this.panelSP.Controls.Add(this.button2);
            this.panelSP.Controls.Add(this.panelPOTA);
            this.panelSP.Controls.Add(this.textBoxFilter);
            this.panelSP.Controls.Add(this.label1);
            this.panelSP.Location = new System.Drawing.Point(3, 1);
            this.panelSP.Name = "panelSP";
            this.panelSP.Size = new System.Drawing.Size(1751, 50);
            this.panelSP.TabIndex = 68;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Select service:",
            "POTA",
            "SOTA",
            "WWFF",
            "DX Cluster"});
            this.comboBox1.Location = new System.Drawing.Point(821, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(207, 28);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonRefreshingMin
            // 
            this.buttonRefreshingMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshingMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefreshingMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefreshingMin.Location = new System.Drawing.Point(1378, 11);
            this.buttonRefreshingMin.Name = "buttonRefreshingMin";
            this.buttonRefreshingMin.Size = new System.Drawing.Size(243, 31);
            this.buttonRefreshingMin.TabIndex = 49;
            this.buttonRefreshingMin.Text = "Start refresh every 2 min.";
            this.buttonRefreshingMin.UseVisualStyleBackColor = true;
            this.buttonRefreshingMin.Click += new System.EventHandler(this.buttonRefreshingMin_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.Location = new System.Drawing.Point(1637, 11);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(106, 31);
            this.buttonRefresh.TabIndex = 52;
            this.buttonRefresh.Text = "Refresh now";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Location = new System.Drawing.Point(656, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 31);
            this.button3.TabIndex = 57;
            this.button3.Text = "Clear Filter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.Location = new System.Drawing.Point(530, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 31);
            this.button2.TabIndex = 56;
            this.button2.Text = "Filter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelPOTA
            // 
            this.panelPOTA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelPOTA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPOTA.Controls.Add(this.radioButtonSPOTS);
            this.panelPOTA.Controls.Add(this.radioButtonACTIVATIONS);
            this.panelPOTA.Location = new System.Drawing.Point(1058, 9);
            this.panelPOTA.Name = "panelPOTA";
            this.panelPOTA.Size = new System.Drawing.Size(285, 34);
            this.panelPOTA.TabIndex = 65;
            // 
            // radioButtonSPOTS
            // 
            this.radioButtonSPOTS.AutoSize = true;
            this.radioButtonSPOTS.Checked = true;
            this.radioButtonSPOTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSPOTS.Location = new System.Drawing.Point(13, 5);
            this.radioButtonSPOTS.Name = "radioButtonSPOTS";
            this.radioButtonSPOTS.Size = new System.Drawing.Size(86, 24);
            this.radioButtonSPOTS.TabIndex = 58;
            this.radioButtonSPOTS.TabStop = true;
            this.radioButtonSPOTS.Text = "SPOTS";
            this.radioButtonSPOTS.UseVisualStyleBackColor = true;
            this.radioButtonSPOTS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonACTIVATIONS
            // 
            this.radioButtonACTIVATIONS.AutoSize = true;
            this.radioButtonACTIVATIONS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonACTIVATIONS.Location = new System.Drawing.Point(131, 5);
            this.radioButtonACTIVATIONS.Name = "radioButtonACTIVATIONS";
            this.radioButtonACTIVATIONS.Size = new System.Drawing.Size(139, 24);
            this.radioButtonACTIVATIONS.TabIndex = 59;
            this.radioButtonACTIVATIONS.Text = "ACTIVATIONS";
            this.radioButtonACTIVATIONS.UseVisualStyleBackColor = true;
            this.radioButtonACTIVATIONS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFilter.Location = new System.Drawing.Point(298, 13);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(217, 27);
            this.textBoxFilter.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Filter (OR funct. in some columns):";
            // 
            // labelLoading
            // 
            this.labelLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLoading.BackColor = System.Drawing.Color.Olive;
            this.labelLoading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelLoading.Location = new System.Drawing.Point(1648, 52);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(98, 23);
            this.labelLoading.TabIndex = 64;
            this.labelLoading.Text = "Loading ...";
            this.labelLoading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelLoading.Visible = false;
            // 
            // labelNotLoaded
            // 
            this.labelNotLoaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNotLoaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNotLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNotLoaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelNotLoaded.Location = new System.Drawing.Point(24, 100);
            this.labelNotLoaded.Name = "labelNotLoaded";
            this.labelNotLoaded.Size = new System.Drawing.Size(354, 47);
            this.labelNotLoaded.TabIndex = 63;
            this.labelNotLoaded.Text = "No data ...";
            this.labelNotLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNotLoaded.Visible = false;
            this.labelNotLoaded.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(1478, 134);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(220, 284);
            this.textBoxLog.TabIndex = 62;
            this.textBoxLog.Visible = false;
            this.textBoxLog.WordWrap = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Reference,
            this.spotName,
            this.Loc2,
            this.Country,
            this.Frequency,
            this.Mode,
            this.Grid,
            this.Spotter,
            this.Comments,
            this.Time});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(15, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1731, 559);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseUp);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyCallSignToClipboardToolStripMenuItem,
            this.copyFrequencyToClipboardToolStripMenuItem,
            this.toolStripMenuItem1,
            this.copyCellcurrentValueToClipboardToolStripMenuItem,
            this.copyRowToClipboardcsvToolStripMenuItem,
            this.copyAllRowsToClipboardToolStripMenuItem,
            this.copyAllRowsToClipboardcsvToolStripMenuItem,
            this.toolStripMenuItem2,
            this.showInQRZcomToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(319, 212);
            // 
            // copyCallSignToClipboardToolStripMenuItem
            // 
            this.copyCallSignToClipboardToolStripMenuItem.Name = "copyCallSignToClipboardToolStripMenuItem";
            this.copyCallSignToClipboardToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.copyCallSignToClipboardToolStripMenuItem.Text = "Copy CallSign to Clipboard";
            this.copyCallSignToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyCallSignToClipboardToolStripMenuItem_Click);
            // 
            // copyFrequencyToClipboardToolStripMenuItem
            // 
            this.copyFrequencyToClipboardToolStripMenuItem.Name = "copyFrequencyToClipboardToolStripMenuItem";
            this.copyFrequencyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.copyFrequencyToClipboardToolStripMenuItem.Text = "Copy Frequency to Clipboard";
            this.copyFrequencyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyFrequencyToClipboardToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(315, 6);
            // 
            // copyCellcurrentValueToClipboardToolStripMenuItem
            // 
            this.copyCellcurrentValueToClipboardToolStripMenuItem.Name = "copyCellcurrentValueToClipboardToolStripMenuItem";
            this.copyCellcurrentValueToClipboardToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.copyCellcurrentValueToClipboardToolStripMenuItem.Text = "Copy current Cell value to Clipboard";
            this.copyCellcurrentValueToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyCellcurrentValueToClipboardToolStripMenuItem_Click);
            // 
            // copyRowToClipboardcsvToolStripMenuItem
            // 
            this.copyRowToClipboardcsvToolStripMenuItem.Name = "copyRowToClipboardcsvToolStripMenuItem";
            this.copyRowToClipboardcsvToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.copyRowToClipboardcsvToolStripMenuItem.Text = "Copy Row to Clipboard (csv)";
            this.copyRowToClipboardcsvToolStripMenuItem.Click += new System.EventHandler(this.copyRowToClipboardcsvToolStripMenuItem_Click);
            // 
            // copyAllRowsToClipboardToolStripMenuItem
            // 
            this.copyAllRowsToClipboardToolStripMenuItem.Name = "copyAllRowsToClipboardToolStripMenuItem";
            this.copyAllRowsToClipboardToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.copyAllRowsToClipboardToolStripMenuItem.Text = "Copy all Rows to Clipboard";
            this.copyAllRowsToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyAllRowsToClipboardToolStripMenuItem_Click);
            // 
            // copyAllRowsToClipboardcsvToolStripMenuItem
            // 
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Name = "copyAllRowsToClipboardcsvToolStripMenuItem";
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Text = "Copy all Rows to Clipboard (csv)";
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Click += new System.EventHandler(this.copyAllRowsToClipboardcsvToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(315, 6);
            // 
            // showInQRZcomToolStripMenuItem
            // 
            this.showInQRZcomToolStripMenuItem.Name = "showInQRZcomToolStripMenuItem";
            this.showInQRZcomToolStripMenuItem.Size = new System.Drawing.Size(318, 24);
            this.showInQRZcomToolStripMenuItem.Text = "Show in QRZ.com";
            this.showInQRZcomToolStripMenuItem.Click += new System.EventHandler(this.showInQRZcomToolStripMenuItem_Click);
            // 
            // timerStart
            // 
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 120000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // timerHideHelp
            // 
            this.timerHideHelp.Interval = 5000;
            this.timerHideHelp.Tick += new System.EventHandler(this.timerHideHelp_Tick);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Activator";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 95;
            // 
            // Reference
            // 
            this.Reference.HeaderText = "Reference";
            this.Reference.MinimumWidth = 6;
            this.Reference.Name = "Reference";
            this.Reference.ReadOnly = true;
            this.Reference.Width = 90;
            // 
            // spotName
            // 
            this.spotName.HeaderText = "Name";
            this.spotName.MinimumWidth = 6;
            this.spotName.Name = "spotName";
            this.spotName.ReadOnly = true;
            this.spotName.Width = 280;
            // 
            // Loc2
            // 
            this.Loc2.HeaderText = "Location Decription";
            this.Loc2.MinimumWidth = 6;
            this.Loc2.Name = "Loc2";
            this.Loc2.ReadOnly = true;
            this.Loc2.Width = 125;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.ReadOnly = true;
            this.Country.Width = 165;
            // 
            // Frequency
            // 
            this.Frequency.HeaderText = "Frequency";
            this.Frequency.MinimumWidth = 6;
            this.Frequency.Name = "Frequency";
            this.Frequency.ReadOnly = true;
            this.Frequency.Width = 120;
            // 
            // Mode
            // 
            this.Mode.HeaderText = "Mode";
            this.Mode.MinimumWidth = 6;
            this.Mode.Name = "Mode";
            this.Mode.ReadOnly = true;
            this.Mode.Width = 80;
            // 
            // Grid
            // 
            this.Grid.HeaderText = "Grid";
            this.Grid.MinimumWidth = 6;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            // 
            // Spotter
            // 
            this.Spotter.HeaderText = "Spotter";
            this.Spotter.MinimumWidth = 6;
            this.Spotter.Name = "Spotter";
            this.Spotter.ReadOnly = true;
            // 
            // Comments
            // 
            this.Comments.HeaderText = "Comments";
            this.Comments.MinimumWidth = 6;
            this.Comments.Name = "Comments";
            this.Comments.ReadOnly = true;
            this.Comments.Width = 280;
            // 
            // Time
            // 
            this.Time.HeaderText = "Date time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 260;
            // 
            // FormPOTA
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1770, 660);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "FormPOTA";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.Text = "SOTA/POTA/WWFF To CAT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCFG.ResumeLayout(false);
            this.panelSP.ResumeLayout(false);
            this.panelSP.PerformLayout();
            this.panelPOTA.ResumeLayout(false);
            this.panelPOTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefreshingMin;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonACTIVATIONS;
        private System.Windows.Forms.RadioButton radioButtonSPOTS;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Label labelLoading;
        private System.Windows.Forms.Label labelNotLoaded;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelPOTA;
        private System.Windows.Forms.Panel panelSP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelHelp;
        private System.Windows.Forms.Timer timerHideHelp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyCellcurrentValueToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyRowToClipboardcsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllRowsToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllRowsToClipboardcsvToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyCallSignToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem copyFrequencyToClipboardToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelQRZflag;
        private System.Windows.Forms.TextBox textBoxQRZCountry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQRZName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonQueryQRZ;
        private System.Windows.Forms.TextBox textBoxQRZ;
        private System.Windows.Forms.CheckBox checkBoxAutoQRZ;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelQRZLoading;
        private System.Windows.Forms.Panel panelCFG;
        private System.Windows.Forms.Panel panelCFGImg;
        private System.Windows.Forms.Button buttonMoreQrzInfo;
        private System.Windows.Forms.Panel panelQRZNowFlag;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem showInQRZcomToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn spotName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frequency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spotter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
    }
}

