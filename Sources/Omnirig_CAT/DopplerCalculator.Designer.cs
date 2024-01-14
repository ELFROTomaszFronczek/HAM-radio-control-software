namespace Omnirig_CAT
{
    partial class DopplerCalculator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCalculateDoppler = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonApply);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonCalculateDoppler);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 503);
            this.panel1.TabIndex = 3;
            // 
            // buttonApply
            // 
            this.buttonApply.Enabled = false;
            this.buttonApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonApply.Location = new System.Drawing.Point(626, 242);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(98, 70);
            this.buttonApply.TabIndex = 64;
            this.buttonApply.Text = "Apply values";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Info:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(221, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 30);
            this.label6.TabIndex = 62;
            this.label6.Text = "Time period value: --";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(221, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 30);
            this.label5.TabIndex = 61;
            this.label5.Text = "Change frequency value: --";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(54, 340);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(670, 136);
            this.textBox3.TabIndex = 60;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButton3);
            this.panel3.Controls.Add(this.radioButton4);
            this.panel3.Location = new System.Drawing.Point(351, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 53);
            this.panel3.TabIndex = 59;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(14, 14);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 24);
            this.radioButton3.TabIndex = 54;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "seconds";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(131, 14);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(89, 24);
            this.radioButton4.TabIndex = 55;
            this.radioButton4.Text = "minutes";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Location = new System.Drawing.Point(351, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 53);
            this.panel2.TabIndex = 58;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 14);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 24);
            this.radioButton1.TabIndex = 54;
            this.radioButton1.Text = "Hz";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(131, 15);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 24);
            this.radioButton2.TabIndex = 55;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "kHz";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 56;
            this.label4.Text = "Total Time :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(110, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "If delta is +/-10 kHz enter 20";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Delta Freuency:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Doppler Effect Module Calculator";
            // 
            // buttonCalculateDoppler
            // 
            this.buttonCalculateDoppler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCalculateDoppler.Location = new System.Drawing.Point(54, 241);
            this.buttonCalculateDoppler.Name = "buttonCalculateDoppler";
            this.buttonCalculateDoppler.Size = new System.Drawing.Size(98, 31);
            this.buttonCalculateDoppler.TabIndex = 50;
            this.buttonCalculateDoppler.Text = "Calculate";
            this.buttonCalculateDoppler.UseVisualStyleBackColor = true;
            this.buttonCalculateDoppler.Click += new System.EventHandler(this.buttonCalculateDoppler_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(509, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(274, 40);
            this.label8.TabIndex = 65;
            this.label8.Text = "results may be approximate\r\nsome data can get wrong result";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // DopplerCalculator
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "DopplerCalculator";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.Text = "DopplerCalculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DopplerCalculator_FormClosing);
            this.Load += new System.EventHandler(this.DopplerCalculator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCalculateDoppler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label8;
    }
}