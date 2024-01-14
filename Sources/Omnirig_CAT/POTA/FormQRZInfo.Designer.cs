namespace Omnirig_CAT.POTA
{
    partial class FormQRZInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNotLoaded = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyAllRowsToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllRowsToClipboardcsvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQRZ = new System.Windows.Forms.TextBox();
            this.buttonMoreQrzInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonMoreQrzInfo);
            this.panel1.Controls.Add(this.textBoxQRZ);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelNotLoaded);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 784);
            this.panel1.TabIndex = 1;
            // 
            // labelNotLoaded
            // 
            this.labelNotLoaded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNotLoaded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNotLoaded.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNotLoaded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelNotLoaded.Location = new System.Drawing.Point(25, 109);
            this.labelNotLoaded.Name = "labelNotLoaded";
            this.labelNotLoaded.Size = new System.Drawing.Size(354, 47);
            this.labelNotLoaded.TabIndex = 64;
            this.labelNotLoaded.Text = "No data ...";
            this.labelNotLoaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNotLoaded.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(15, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
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
            this.dataGridView1.Size = new System.Drawing.Size(725, 716);
            this.dataGridView1.TabIndex = 54;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column Value";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 450;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyAllRowsToClipboardToolStripMenuItem,
            this.copyAllRowsToClipboardcsvToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(294, 52);
            // 
            // copyAllRowsToClipboardToolStripMenuItem
            // 
            this.copyAllRowsToClipboardToolStripMenuItem.Name = "copyAllRowsToClipboardToolStripMenuItem";
            this.copyAllRowsToClipboardToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.copyAllRowsToClipboardToolStripMenuItem.Text = "Copy all Rows to Clipboard";
            this.copyAllRowsToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyAllRowsToClipboardToolStripMenuItem_Click);
            // 
            // copyAllRowsToClipboardcsvToolStripMenuItem
            // 
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Name = "copyAllRowsToClipboardcsvToolStripMenuItem";
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Size = new System.Drawing.Size(293, 24);
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Text = "Copy all Rows to Clipboard (csv)";
            this.copyAllRowsToClipboardcsvToolStripMenuItem.Click += new System.EventHandler(this.copyAllRowsToClipboardcsvToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Info for:";
            // 
            // textBoxQRZ
            // 
            this.textBoxQRZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxQRZ.Location = new System.Drawing.Point(104, 12);
            this.textBoxQRZ.Name = "textBoxQRZ";
            this.textBoxQRZ.Size = new System.Drawing.Size(217, 27);
            this.textBoxQRZ.TabIndex = 66;
            // 
            // buttonMoreQrzInfo
            // 
            this.buttonMoreQrzInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonMoreQrzInfo.Location = new System.Drawing.Point(341, 10);
            this.buttonMoreQrzInfo.Name = "buttonMoreQrzInfo";
            this.buttonMoreQrzInfo.Size = new System.Drawing.Size(184, 29);
            this.buttonMoreQrzInfo.TabIndex = 68;
            this.buttonMoreQrzInfo.Text = "More info in QRZ.com";
            this.buttonMoreQrzInfo.UseVisualStyleBackColor = true;
            this.buttonMoreQrzInfo.Click += new System.EventHandler(this.buttonMoreQrzInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "... Bad Data ...";
            this.label2.Visible = false;
            // 
            // FormQRZInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(760, 788);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQRZInfo";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "QRZ Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQRZInfo_FormClosing);
            this.Load += new System.EventHandler(this.FormQRZInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelNotLoaded;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyAllRowsToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyAllRowsToClipboardcsvToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQRZ;
        private System.Windows.Forms.Button buttonMoreQrzInfo;
        private System.Windows.Forms.Label label2;
    }
}