using ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnirig_CAT.POTA
{
    public partial class FormQRZ : Form
    {
        public FormQRZ()
        {
            InitializeComponent();
        }

        
        private void QRZ_Load(object sender, EventArgs e)
        {
            PROCKI.loadFormSizeAndLog(this);
            QRZ.LOAD();
            textBox1.Text = QRZ.userName;
            textBox2.Text = QRZ.password;
            checkBox1.Checked = QRZ.getExtendedInfo;

        }

        private void QRZ_FormClosing(object sender, FormClosingEventArgs e)
        {
            PROCKI.saveFormSizeAndLog(this);
            Config.WriteConfig();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
            if (textBox2.UseSystemPasswordChar)
                button1.Text = "Show";
            else
                button1.Text = "Hide";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "Reading Session KEY from: http://xml.qrz.com/bin/xml\r\n" ;



            if (QRZ.logIn())
            {
                textBox3.Text += "Logged in. User Key:" + QRZ.userKey+"\r\n";

                textBox3.Text += "User data:\r\n" + QRZ.getCallsignData(textBox1.Text,"");

            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
             ;
            QRZ.SAVE(textBox1.Text, textBox2.Text, checkBox1.Checked);
           
            Close();
        }
    }
}
