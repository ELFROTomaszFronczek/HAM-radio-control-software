using ADMIN;
using Omnirig_CAT;
using Omnirig_CAT.POTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace POTA_To_CAT
{
    public partial class FormPOTA : Form
    {
        public FormPOTA(Omnirig_CAT.Form1 form1)
        {
            _f = form1;
            InitializeComponent();
        }



        string sect = "pota";
        bool loading = true;

        public bool isClosed = false;

        private void Form1_Load(object sender, EventArgs e)
        {

            PROCKI.loadFormSizeAndLog(this);
            PROCKI.loadGridWidths(this, dataGridView1);


            radioButtonSPOTS.Checked = Config.ReadBoolValue(sect, "spots", true);
            radioButtonACTIVATIONS.Checked = !radioButtonSPOTS.Checked;

            radioButtonPOTA.Checked = Config.ReadBoolValue(sect, "POTA", true);
            radioButtonSOTA.Checked = !radioButtonPOTA.Checked;
            radioButtonSOTA_CheckedChanged(null, null);


            bool refr = Config.ReadBoolValue(sect, "autoRefresh", false);
            if (refr) buttonRefreshingMin_Click(null, null);






            timerStart.Start();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PROCKI.saveFormSizeAndLog(this);
            PROCKI.saveGridWidths(this, dataGridView1);
            Config.WriteValue(sect, "spots", radioButtonSPOTS.Checked);
            Config.WriteValue(sect, "autoRefresh", timerRefresh.Enabled);
            Config.WriteValue(sect, "POTA", radioButtonPOTA.Checked);

            isClosed = true;
            timerRefresh.Enabled = false;

            timerStart.Enabled = false;

        }




        private void timerStart_Tick(object sender, EventArgs e)
        {
            timerStart.Stop();
            loading = false;
            labelNotLoaded.Visible = false;

            radioButton1_CheckedChanged(null, null);
            //textBox1.Text =GetPageSource();
        }

        private void fillGrid()
        {
            labelNotLoaded.Visible = false;
            string s = html;
            if (!string.IsNullOrEmpty(s))
                try
                {



                    dataGridView1.Rows.Clear();
                    if (string.IsNullOrEmpty(html))
                    {
                        return;
                    }


                    // Application.DoEvents();
                    s = html.Replace("},", "},\r\n\r\n");
                    s = s.Replace("\",", "\",\r\n");
                    s = s.Replace(", \"", ", \r\n\"");
                    s = s.Trim();//.Replace(" "," ");

                    if (radioButtonPOTA.Checked)
                    {
                        //POTA
                       
                        if (radioButtonSPOTS.Checked)
                        {
                            if (SpotPOTA.DeserializeSPOT_JSON(s))
                            {

                                foreach (SpotPOTA.spotJson sj in SpotPOTA.spotList)
                                {

                                    bool add = true;
                                    if (filtered)
                                    {
                                        if (sj.activator.IndexOf(filter) < 0 && sj.reference.IndexOf(filter) < 0 && sj.name.IndexOf(filter) < 0 && sj.locationDesc.IndexOf(filter) < 0) add = false;
                                    }

                                    if (add) dataGridView1.Rows.Add(sj.activator, sj.reference, sj.name, sj.locationDesc, sj.frequency, sj.mode, SpotPOTA.getLocation(sj), sj.spotter, sj.comments, sj.spotTime);
                                }


                            }
                        }
                        else
                        {
                           

                            if (ActivationPOTA.DeserializeACTIVATION_JSON(s))
                            {
                                foreach (ActivationPOTA.activationJson sj in ActivationPOTA.activationList)
                                {

                                    bool add = true;
                                    if (filtered)
                                    {
                                        if (sj.activator.IndexOf(filter) < 0 && sj.reference.IndexOf(filter) < 0 && sj.name.IndexOf(filter) < 0 && sj.locationDesc.IndexOf(filter) < 0) add = false;
                                    }
                                    if (add) dataGridView1.Rows.Add(sj.activator, sj.reference, sj.name, sj.locationDesc, sj.frequencies, "", "", "", sj.comments,
                                        sj.startDate + " " + sj.startTime + " / " + sj.endDate + " " + sj.endTime);
                                }
                            }

                        }
                    }
                    else
                    {
                      
                        s = s.Replace(",\"", "\",\r\n");
                        //s = s.Replace(", \"", ", \r\n\"");
                        s = s.Trim();//.Replace(" "," ");

                        if (radioButtonSPOTS.Checked)
                        {
                            if (SpotSOTA.DeserializeSPOT_JSON(s))
                            {

                                foreach (SpotSOTA.spotJson sj in SpotSOTA.spotList)
                                {
                                    string refer = sj.associationCode + "/" + sj.summitCode;
                                    bool add = true;
                                    if (filtered)
                                    {
                                           if (sj.activatorCallsign.IndexOf(filter) < 0 && refer.IndexOf(filter) < 0 && sj.summitDetails.IndexOf(filter) < 0 && sj.callsign.IndexOf(filter) < 0) add = false;
                                    }

                                    if (add)

                                        //dataGridView1.Rows.Add(sj.activator, sj.reference, sj.name, sj.locationDesc, sj.frequency, sj.mode, SpotPOTA.getLocation(sj), sj.spotter, sj.comments, sj.spotTime);
                                        dataGridView1.Rows.Add(sj.activatorCallsign, refer, sj.summitDetails, "", sj.frequency, sj.mode, "", sj.callsign, sj.comments, sj.timeStamp);
                                }


                            }
                        }
                        else
                        {
                            if (AlertSOTA.DeserializeACTIVATION_JSON(s))
                            {
                                foreach (AlertSOTA.alertJson sj in AlertSOTA.alertList)
                                {
                                    string refer = sj.associationCode + "/" + sj.summitCode;
                                    bool add = true;
                                    if (filtered)
                                    {
                                        if (sj.activatingCallsign.IndexOf(filter) < 0 && refer.IndexOf(filter) < 0 && sj.summitDetails.IndexOf(filter) < 0 && sj.posterCallsign.IndexOf(filter) < 0 ) add = false;
                                    }
                                      if (add)
                                        dataGridView1.Rows.Add(sj.activatingCallsign, refer, sj.summitDetails, "", sj.frequency, "", "", sj.posterCallsign, sj.comments, sj.timeStamp);
                                }
                            }

                        }

                    }


                }
                catch (Exception ex)
                {
                    Log.AddException(ex);
                }
            // textBoxLog.Text= s;
            else
                labelNotLoaded.Visible = true;

        }

        bool firstNavi = true;


        volatile string html;
        //volatile string text;


        bool filtered = false;
        string filter = "";



        string listaDanych = "";
        private Form1 _f;

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            radioButton1_CheckedChanged(null, null);

            //K7GUD;K-10070;K-10070;K-10070 Menan Buttes (BLM) Natural Monument;US-ID;14061.5 kHz (CW);WA9VFD;No spot information;Last heard 9 sec ago at 19:39 UTC


        }





        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxFilter.Text) && !string.IsNullOrWhiteSpace(html))
            {
                filtered = true;
                filter = textBoxFilter.Text;
                fillGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            filtered = false;
            textBoxFilter.Text = "";
            filter = textBoxFilter.Text;
            fillGrid();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (radioButtonPOTA.Checked)
                {
                    _f.updateFrequency(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                }
                else
                    _f.updateFrequency(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()+"MHZ", dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());


            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!loading)

            {

                SOTAPOTAVisiblity();
                labelLoading.Visible = true;
                Application.DoEvents();
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    if (!backgroundWorker1.IsBusy)
                        backgroundWorker1.RunWorkerAsync();
                    else
                    {
                        System.Threading.Thread.Sleep(1000);
                        if (!backgroundWorker1.IsBusy)
                            backgroundWorker1.RunWorkerAsync();
                    }

                }


            }
        }

        private void SOTAPOTAVisiblity(bool hide=false)
        {
            panelSP.Enabled = hide;
            buttonRefresh.Visible = hide;
            buttonRefreshingMin.Visible = hide;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            buttonRefresh_Click(null, null);
        }

        private void buttonRefreshingMin_Click(object sender, EventArgs e)
        {

            timerRefresh.Enabled = !timerRefresh.Enabled;
            if (timerRefresh.Enabled)
                buttonRefreshingMin.Text = "Stop refreshing";
            else
                buttonRefreshingMin.Text = "Start refresh every 1 min.";

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (radioButtonPOTA.Checked)
                {
                    if (radioButtonSPOTS.Checked)
                        html = ADMIN.HTTP.GET("https://api.pota.app/spot/activator");

                    else
                        html = ADMIN.HTTP.GET("https://api.pota.app/activation");
                }
                else
                {
                    if (radioButtonSPOTS.Checked)
                        html = ADMIN.HTTP.GET("https://api2.sota.org.uk/api/spots/200/all%7Call?client=sotawatch&user=anon");

                    else
                        html = ADMIN.HTTP.GET("https://api2.sota.org.uk/api/alerts/12?client=sotawatch&user=anon");

                }
            }
            catch (Exception ex) { Log.AddException(ex); }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelLoading.Visible = false;
            SOTAPOTAVisiblity(true);
            fillGrid();
        }

        private void radioButtonSOTA_CheckedChanged(object sender, EventArgs e)
        {
            SOTAPOTAVisiblity();
            if (radioButtonPOTA.Checked) radioButtonACTIVATIONS.Text = "ACTIVATIONS";
            else
                radioButtonACTIVATIONS.Text = "ALERTS";
            radioButton1_CheckedChanged(null, null);
        }
    }
}
