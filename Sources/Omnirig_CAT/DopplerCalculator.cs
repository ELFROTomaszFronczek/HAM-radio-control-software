using ADMIN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omnirig_CAT
{
    public partial class DopplerCalculator : Form
    {
        public DopplerCalculator()
        {
            InitializeComponent();
            //textBox1.Text=f.ToString();
            //textBox2.Text=t.ToString();
        }

        public int cT = -1;
        public int cF = -1;

        private void buttonCalculateDoppler_Click(object sender, EventArgs e)
        {
            buttonApply.Enabled = false;
            errorProvider1.Clear();
            textBox3.Text = string.Empty;
            bool ok = checkEmpty(textBox1, "Error Enter Frequency");
            ok &= checkEmpty(textBox2, "Error Enter Time");
            if (ok)
            {
                ok &= checkEmpty(textBox1, "Error Enter Valid Frequency");
                ok &= checkEmpty(textBox2, "Error Enter Valid Time");
                if (ok)
                {
                   
                    int freq = int.Parse(textBox1.Text);
                    int time = int.Parse(textBox2.Text);

                    if (radioButton2.Checked) freq = freq * 1000;
                    if (radioButton4.Checked) time = time * 60;

                    Add("Delta Frequency: " + freq);
                    Add("Period Time: " + time);
                    double hz = (freq * 1.0) / (time * 1.0);
                 

                    double hz100ms = hz / 10;

                    Add("Hz per 100 miliseconds " + hz100ms.ToString("0.000"));

                    if (hz100ms >= 1)
                    {


                        if (Math.Floor(hz100ms) == hz100ms)
                        {
                            cT = 100;
                            cF = (int)hz100ms;
                            buttonApply.Enabled = true;
                        }
                        else
                        {
                            double nHz100 = Math.Floor(hz100ms) + 1.0;

                            double nt = 100 * nHz100 / hz100ms;

                            if (nt <= 1000)
                            {
                                cT = (int)nt;
                                cF = (int)nHz100;


                                buttonApply.Enabled = true;
                            }

                        }


                    }
                    else
                    {
                        Add("Hz per seconds " + hz.ToString("0.000"));
                        if (hz >= 1.0)
                        {
                            if (hz == 1.0)
                            {
                                cT = 1000;
                                cF = 1; 
                                buttonApply.Enabled = true;
                            }
                            else
                            {
                                double nHz = Math.Floor(hz) + 1.0;

                                double nt = 1000* nHz / hz;
                                if (nt <= 1000)
                                {
                                    cT = (int)nt;
                                    cF = (int)nHz;


                                    buttonApply.Enabled = true;
                                }
                                else
                                {
                                    if (nHz > 1)
                                    {
                                         nHz = (Math.Floor(hz) + 1.0)/2;

                                         nt = (1000 * nHz / hz)/2;
                                        if (nt <= 1000)
                                        {
                                            cT = (int)nt;
                                            cF = (int)nHz;


                                            buttonApply.Enabled = true;
                                        }
                                        else
                                        {
                                            if (nHz > 1)
                                            {
                                                nHz = (Math.Floor(hz) + 1.0) / 2;

                                                nt = (1000 * nHz / hz) / 2;
                                                if (nt <= 1000)
                                                {
                                                    cT = (int)nt;
                                                    cF = (int)nHz;


                                                    buttonApply.Enabled = true;
                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }

                    }




                }
            } 
            
            if (!ok) buttonApply.Enabled = false;

            if (!buttonApply.Enabled)
            {
                Add("Calculation not possible");
                cT = -1;
                cF = -1;
                label5.Text = "Change frequency value: --";
                label6.Text = "Time period value: --";
            }
            else
            {
                Add("Calculated");

                label5.Text = "Change frequency value: "+cF+" Hz";
                label6.Text = "Time period value: "+cT+" msec";

            }


        }

        double zaokr(double x)
        {
            return (Math.Round(x * 10.0)) / 10.0;
        
        }


        private bool checkInt(TextBox t, string v)
        {
            int i;
            if (!int.TryParse(t.Text, out i))
            {
                errorProvider1.SetError(t, v);
                Add(v);
                return false;
            }
            return true;
        }

        private bool checkEmpty(TextBox t, string v)
        {
            if (string.IsNullOrEmpty(t.Text))
            {
                errorProvider1.SetError(t, v);
                Add(v);
                return false;
            }
            return true;
        }

        private void Add(string v)
        {
            textBox3.Text += v + "\r\n";
            textBox3.SelectionStart = textBox3.Text.Length;
            textBox3.ScrollToCaret();
        }

        private void DopplerCalculator_Load(object sender, EventArgs e)
        {
            PROCKI.loadFormSizeAndLog(this);
        }

        private void DopplerCalculator_FormClosing(object sender, FormClosingEventArgs e)
        {
            PROCKI.saveFormSizeAndLog(this);

        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
