using ADMIN;
using Omnirig_CAT;
using Omnirig_CAT.POTA;
using System;
using System.ComponentModel;
using System.Windows.Forms;


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


            comboBox1.SelectedIndex = Config.ReadIntValue(sect, "POTA_SOTA_WWFF", 0);



            comboBox1_SelectedIndexChanged(null, null);


            bool refr = Config.ReadBoolValue(sect, "autoRefresh", false);
            if (refr) buttonRefreshingMin_Click(null, null);






            timerStart.Start();

            if (!Config.ReadBoolValue(sect, "helpShown", false))
            {
                labelHelp.Visible = true;
                Config.WriteValue(sect, "helpShown", true);
                timerHideHelp.Start();
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            PROCKI.saveFormSizeAndLog(this);
            PROCKI.saveGridWidths(this, dataGridView1);
            SAVE();


            isClosed = true;
            timerRefresh.Enabled = false;

            timerStart.Enabled = false;

        }

        private void SAVE()
        {
            if (loading) return;
            Config.WriteValue(sect, "spots", radioButtonSPOTS.Checked);
            Config.WriteValue(sect, "autoRefresh", timerRefresh.Enabled);

            Config.WriteValue(sect, "POTA_SOTA_WWFF", comboBox1.SelectedIndex);
        }

        private void timerStart_Tick(object sender, EventArgs e)
        {
            timerStart.Stop();
            loading = false;
            labelNotLoaded.Visible = false;

            GetData();
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

                    //POTA  -1
                    //SOTA  -2
                    //WWFF  -3
                    //DX Cluster -4

                    if (comboBox1.SelectedIndex != 3)
                    {
                        s = html.Replace("},", "},\r\n\r\n");
                        s = s.Replace("\",", "\",\r\n");
                        s = s.Replace(", \"", ", \r\n\"");
                        s = s.Trim();//.Replace(" "," ");
                    }

                    switch (comboBox1.SelectedIndex)
                    {
                        //POTA
                        case 1:

                            //POTA
                            if (radioButtonSPOTS.Checked)
                            {
                                if (SpotPOTA.DeserializeSPOT_JSON(s))
                                {
                                    setColumnsNames("Callsign", "Refference", "Name", "Location Decription", "Frequency", "Mode", "Locator", "Spotter", "Comments", "Date Time");
                                    foreach (SpotPOTA.spotJson sj in SpotPOTA.spotList)
                                    {

                                        bool add = true;
                                        if (filtered)
                                        {
                                            if (sj.activator.IndexOf(filter) < 0 && sj.reference.IndexOf(filter) < 0 && sj.name.IndexOf(filter) < 0 && sj.locationDesc.IndexOf(filter) < 0 && sj.spotter.IndexOf(filter) < 0) add = false;
                                        }

                                        if (add) dataGridView1.Rows.Add(sj.activator, sj.reference, sj.name, sj.locationDesc, sj.frequency, sj.mode, SpotPOTA.getLocation(sj), sj.spotter, sj.comments, sj.spotTime);
                                    }


                                }
                            }
                            else
                            {


                                if (ActivationPOTA.DeserializeACTIVATION_JSON(s))
                                {
                                    setColumnsNames("Callsign", "Refference", "Name", "Location Decription", "Frequency", "", "", "", "Comments", "Date Time");
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
                            break;

                        //SOTA
                        case 2:
                            s = s.Replace(",\"", "\",\r\n");
                            //s = s.Replace(", \"", ", \r\n\"");
                            s = s.Trim();//.Replace(" "," ");

                            if (radioButtonSPOTS.Checked)
                            {
                                if (SpotSOTA.DeserializeSPOT_JSON(s))
                                {
                                    setColumnsNames("Callsign", "Refferer", "Summit", "", "Frequency", "Mode",  "", "Spotter", "Comments", "Date Time");
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
                                    setColumnsNames("Callsign", "Refferer", "Summit", "", "Frequency", "", "", "Spotter", "Comments", "Date Time");
                                    foreach (AlertSOTA.alertJson sj in AlertSOTA.alertList)
                                    {
                                        string refer = sj.associationCode + "/" + sj.summitCode;
                                        bool add = true;
                                        if (filtered)
                                        {
                                            if (sj.activatingCallsign.IndexOf(filter) < 0 && refer.IndexOf(filter) < 0 && sj.summitDetails.IndexOf(filter) < 0 && sj.posterCallsign.IndexOf(filter) < 0) add = false;
                                        }
                                        if (add)
                                            dataGridView1.Rows.Add(sj.activatingCallsign, refer, sj.summitDetails, "", sj.frequency, "", "", sj.posterCallsign, sj.comments, sj.timeStamp);
                                    }
                                }

                            }


                            break;


                        //WWFF
                        case 3:

                            s = html.Substring(html.IndexOf("<td class=spot_lt"));
                            s = s.Substring(0, s.IndexOf("</body>")).Replace("<", "\r\n<").Replace("\r\n\r\n", "\r\n").Replace("\r\n\r\n", "\r\n").Replace("\r\n\r\n", "\r\n");


                            if (WWFF.DeserializeWWFF_html(s))
                            {
                                setColumnsNames("Callsign", "X",  "WWFF", "Notes", "Frequency", "", "Locator", "Spotter", "Comments", "Date Time");
                                foreach (WWFF.spotWWFF sj in WWFF.spotList)
                                {
                                    bool add = true;
                                    if (filtered)
                                    {
                                        if (sj.callSign.IndexOf(filter) < 0 && sj.TITLE.IndexOf(filter) < 0 && sj.Notes.IndexOf(filter) < 0 && sj.WWFF.IndexOf(filter) < 0 && sj.spotter.IndexOf(filter) < 0) add = false;
                                    }

                                    if (add)

                                        //dataGridView1.Rows.Add(sj.activator, sj.reference, sj.name, sj.locationDesc, sj.frequency, sj.mode, SpotPOTA.getLocation(sj), sj.spotter, sj.comments, sj.spotTime);
                                        dataGridView1.Rows.Add(sj.callSign, sj.Notes, sj.TITLE, sj.WWFF, sj.frequency, "", sj.Locator, sj.spotter, sj.comments, sj.dateTime);
                                }

                            }
                            break;

                        //DX CLUSTER
                        case 4:
                            setColumnsNames("Callsign", "", "Country", "Callsign Location", "Frequency", "", "Spotter Location", "Spotter", "Info", "Date Time");

                            if (dxCluster.DeserializeSPOT_JSON(s))
                            {

                                foreach (dxCluster.dxJson sj in dxCluster.dxList)
                                {

                                    bool add = true;
                                    if (filtered)
                                    {
                                         if (sj.dx_call.IndexOf(filter) < 0 && sj.dx_country.IndexOf(filter) < 0 && sj.de_call.IndexOf(filter) < 0 ) add = false;
                                    }

                                    if (add) dataGridView1.Rows.Add(sj.dx_call, "", sj.dx_country, sj.dx_longitude + "/" + sj.dx_latitude, sj.frequency, "", sj.de_longitude + "/" + sj.de_latitude, sj.de_call, sj.info, sj.time);
                                }


                            }

                            break;

                    } // end switch

                }
                catch (Exception ex)
                {
                    Log.AddException(ex);
                }
            // textBoxLog.Text= s;
            else
                labelNotLoaded.Visible = true;

        }

        private void setColumnsNames(string v1, string v2, string v3, string v4, string v5, string v6, string v7, string v8, string v9, string v10)
        {

            dataGridView1.Columns[0].HeaderText = v1;
            dataGridView1.Columns[1].HeaderText = v2;
            dataGridView1.Columns[2].HeaderText = v3;
            dataGridView1.Columns[3].HeaderText = v4;
            dataGridView1.Columns[4].HeaderText = v5;
            dataGridView1.Columns[5].HeaderText = v6;
            dataGridView1.Columns[6].HeaderText = v7;
            dataGridView1.Columns[7].HeaderText = v8;
            dataGridView1.Columns[8].HeaderText = v9;
            dataGridView1.Columns[9].HeaderText = v10;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.Visible = !(string.IsNullOrEmpty(column.HeaderText));
            }

        }

        bool firstNavi = true;


        volatile string html;
        //volatile string text;


        bool filtered = false;
        string filter = "";



        string listaDanych = "";
        private Form1 _f;
        volatile int workingIndex;

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            GetData();

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

                switch (comboBox1.SelectedIndex)
                {

                    //POTA
                    case 1:
                        _f.updateFrequency(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                        break;
                    //SOTA
                    case 2:
                        _f.updateFrequency(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() /*+ "MHZ"*/, dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
                        break;
                    //WWFF
                    case 3:

                        _f.updateFrequency(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() , "");
                        break;
                    //DX CLUSTER
                    case 4:
                        _f.updateFrequency(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString() , "");
                        break;
                }

                Clipboard.SetText(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == null || (sender is RadioButton && ((RadioButton)sender).Checked)) GetData();
        }

        private void GetData()
        {
            if (!loading)

            {
                SOTAPOTAVisiblity();
                dataGridView1.Rows.Clear();
                labelLoading.Visible = true;
                Application.DoEvents();
                SAVE();
                workingIndex = comboBox1.SelectedIndex;

                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
            }
            /*else
            {
                System.Threading.Thread.Sleep(1000);
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
                else
                {
                    System.Threading.Thread.Sleep(1000);
                    if (!backgroundWorker1.IsBusy)
                    {
                        backgroundWorker1.CancelAsync();
                        SOTAPOTAVisiblity(true);
                    }
                }



            }*/

        }

        private void SOTAPOTAVisiblity(bool hide = false)
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
                switch (workingIndex)
                {
                    //POTA
                    case 1:
                        if (radioButtonSPOTS.Checked)
                            html = ADMIN.HTTP.GET("https://api.pota.app/spot/activator");

                        else
                            html = ADMIN.HTTP.GET("https://api.pota.app/activation");
                        break;

                    //SOTA
                    case 2:
                        if (radioButtonSPOTS.Checked)
                            html = ADMIN.HTTP.GET("https://api2.sota.org.uk/api/spots/200/all%7Call?client=sotawatch&user=anon");

                        else
                            html = ADMIN.HTTP.GET("https://api2.sota.org.uk/api/alerts/12?client=sotawatch&user=anon");
                        break;
                    case 3:
                        html = ADMIN.HTTP.GET("https://www.cqgma.org/wwff/ww1011.php");
                        break;
                    case 4:

                        html = ADMIN.HTTP.GET("http://www.dxsummit.fi/api/v1/spots?limit_time=true&refresh=1704733618888");
                        break;
                }
            }
            catch (Exception ex)
            {
                Log.AddException(ex);
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            labelLoading.Visible = false;

            fillGrid();
            SOTAPOTAVisiblity(true);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 1) return;
            switch (comboBox1.SelectedIndex)
            {
                case 1: panelPOTA.Visible = true; radioButtonACTIVATIONS.Text = "ACTIVATIONS"; break;
                case 2: panelPOTA.Visible = true; radioButtonACTIVATIONS.Text = "ALERTS"; break;
                default: panelPOTA.Visible = false; break;
            }
            if (!loading)
            {
                GetData();
                SAVE();
            }
        }

        private void timerHideHelp_Tick(object sender, EventArgs e)
        {
            timerHideHelp.Stop();
            labelHelp.Visible = false;
        }
    }
}
