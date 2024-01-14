using ADMIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnirig_CAT.POTA
{
    public partial class FormQRZInfo : Form
    {
       
        public FormQRZInfo(string callSign)
        {
            InitializeComponent();
            textBoxQRZ.Text = callSign;
        }

        private void FormQRZInfo_Load(object sender, EventArgs e)
        {
            PROCKI.loadFormSizeAndLog(this);
            PROCKI.loadGridWidths(this,dataGridView1);
            dataGridView1.Rows.Clear();
            if (QRZ.callSignData != null && QRZ.callSignData.Length > 0)
            {
                labelNotLoaded.Visible = false;
                foreach (string s in QRZ.callSignData)
                {
                    string s3 = s.Trim();
                    string q = "</"; int idx = s3.IndexOf(q, StringComparison.OrdinalIgnoreCase);
                    if (idx > -1)
                        s3 = s3.Substring(0, idx);
                    string[] el = PROCKI.Split(s3.Replace("<",""), ">");
                    if (el != null && el.Length > 1)
                    {
                        el[0] = QRZ.fieldToNiceName(el[0]);
                        dataGridView1.Rows.Add(el);
                    }
                }
            }
            if (dataGridView1.Rows.Count<1) labelNotLoaded.Visible = true;
        }

        private void FormQRZInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            PROCKI.saveFormSizeAndLog(this);
            PROCKI.saveGridWidths(this, dataGridView1);
        }

        private void copyAllRowsToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            PROCKI.CopyDataGridToClipboard(dataGridView1);
        }

        private void copyAllRowsToClipboardcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    string val = "";
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                            val += cell.Value.ToString() + ";";
                        if (val.EndsWith(";")) val = val.Substring(0, val.Length - 1);
                        val += "\r\n";

                    }
                    if (val.EndsWith("\r\n")) val = val.Substring(0, val.Length - 2);
                    Clipboard.SetText(val);
                }
            }
            catch { }
        }

        private void buttonMoreQrzInfo_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            try
            {
                if (!string.IsNullOrEmpty(textBoxQRZ.Text))
                {
                    string callSign = textBoxQRZ.Text;
                    string nq = Countries.clearCallSign(callSign);
                    if (!string.IsNullOrEmpty(nq))
                    {
                        string url = "https://www.qrz.com/db/" + nq;
                        System.Diagnostics.Process.Start(url);
                    }
                    else label2.Visible = true;
                }
            }
            catch { label2.Visible = true; }
        }
    }
}
