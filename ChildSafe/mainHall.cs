﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChildSafe
{
    public partial class mainHall : Form
    {
        public mainHall()
        {

            InitializeComponent();

        }
        string host = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\drivers\etc\hosts";
        string onDutyFilters = "OnDuty";
        string defaultChildSafeBaseFilter = "ChildSafeBaseFilter";
        string defaultChildSafeBaseFilter_Url = "https://raw.githubusercontent.com/zeroclubvn/ChildSafe_Project_X15/master/ChildSafe/defaultChildSafeFilter.txt";
        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Enabled = false;
            if (Properties.Settings.Default["protectEnable"].ToString() == "True")
            {

                // safely clear the block list without delete the file
                FileStream fileStream = File.Open(host, FileMode.Open); fileStream.SetLength(0);
                fileStream.Close();
                // change visual
                btStart.Text = "START";
                pictureMainHall.Image = Properties.Resources.danger_256;
                // change protected state
                Properties.Settings.Default["protectEnable"] = false;
                btStart.Enabled = true;
            }
            else
            {
                panelLoading.Visible = true;
                // in options we have the oppotunity to add more filter to the block list, all fillter with be combined in OnDuty file. 
                // if user don't use option feature, application will look for ChildSafeBaseFilter which is the default filter of this program.
                // ChildSafeBaseFilter is downloaded when the app is openning and connecting to internet.
                if (File.Exists(onDutyFilters))
                {
                    string[] list2Block = File.ReadAllText(onDutyFilters).Split('\n');
                    progressBar1.Maximum = list2Block.Length;
                    progressBar1.Value = 0;
                    using (StreamWriter writetext = new StreamWriter(host))
                    {
                        foreach (string line in list2Block)
                        {
                            if (line.StartsWith("#") || line.StartsWith("::") || line.StartsWith("fe80") || line == "")
                            {

                            }
                            else if (line.StartsWith("0.0.0.0") || line.StartsWith("127.0.0.1"))
                            {
                                writetext.WriteLine(line);
                            }
                            else
                            {
                                writetext.WriteLine("127.0.0.1 " + line);

                            }
                            progressBar1.Value++;
                        }
                        writetext.Close();
                    }

                    lbLoadingStatus.Text = "Completed";
                    panelLoading.Visible = false;
                    btStart.Enabled = true;
                }
                // we use default filter instead in case no option filter is added
                else if (File.Exists(defaultChildSafeBaseFilter))
                {
                    string[] list2Block = File.ReadAllText(defaultChildSafeBaseFilter).Split('\n');
                    progressBar1.Maximum = list2Block.Length;
                    progressBar1.Value = 0;

                    using (StreamWriter writetext = new StreamWriter(host))
                    {
                        foreach (string line in list2Block)
                        {
                            writetext.WriteLine("127.0.0.0 " + line);
                            progressBar1.Value++;
                        }
                        writetext.Close();

                    }
                    lbLoadingStatus.Text = "Completed";
                    panelLoading.Visible = false;
                    btStart.Enabled = true;
                }
                // change the visual
                btStart.Text = "STOP";
                pictureMainHall.Image = Properties.Resources.check_blue_256;
                // change protected state
                Properties.Settings.Default["protectEnable"] = true;
            }
            Properties.Settings.Default.Save();
        }

        private void options_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            blockOptions optionsForm = new blockOptions();
            optionsForm.ShowDialog();
        }

        private void btMenu_Click(object sender, EventArgs e)
        {
            contextMenu.Show(Cursor.Position.X - 150, Cursor.Position.Y);
        }

        private void timerQuote_Tick(object sender, EventArgs e)
        {
            // Generate new text quote for every 5 seconds.
            promoteQuote newQuote = new promoteQuote();
            lbPromote.Text = newQuote.getRandomQuote();

        }

        private void mainHall_Load(object sender, EventArgs e)
        {
            // load current settings of the app
            // load language
            switch (Properties.Settings.Default["language"].ToString())
            {
                case "English":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                    Properties.Settings.Default["Language"] = "English";
                    break;
                case "Tiếng Việt":
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                    Properties.Settings.Default["Language"] = "Tiếng Việt";
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();
            // load protection state
            if (Properties.Settings.Default["protectEnable"].ToString() == "True")
            {
                pictureMainHall.Image = Properties.Resources.check_blue_256;
                btStart.Text = "STOP";
            }
            else
            {
                pictureMainHall.Image = Properties.Resources.danger_256;
                btStart.Text = "START";
            }
            // download default filter for child safe
            Thread downloadDefaultFilter = new Thread(() =>
            {
                WebClient client = new WebClient();
                client.DownloadFileAsync(new Uri(defaultChildSafeBaseFilter_Url), defaultChildSafeBaseFilter);
            }
            );
            downloadDefaultFilter.Start();
        }


        private void filtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blockOptions blockOptionForm = new blockOptions();
            blockOptionForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutForm = new about();
            aboutForm.ShowDialog();
        }

        private void githubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/zeroclubvn/ChildSafe_Project_X15");
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/zeroclubvn/ChildSafe_Project_X15/issues");
        }

        private void whitelistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            whiteList whiteListForm = new whiteList();
            whiteListForm.ShowDialog();
        }

        private void autoupdateFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            Properties.Settings.Default["Language"] = "English";
            Properties.Settings.Default.Save();
            this.Controls.Clear();
            InitializeComponent();
        }

        private void vietnamseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VI");
            Properties.Settings.Default["Language"] = "Tiếng Việt";
            Properties.Settings.Default.Save();
            this.Controls.Clear();
            InitializeComponent();
        }
    }
}
