﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace ChildSafe
{
    public partial class filterBrowsing : Form
    {
        Control newControl(string name, string descriptionText,string linkFile, string updateText, string licenceText)
        {
            // a custom panel to display filter and its descriptions.
            Panel newPanel = new Panel();
            CheckBox newCheckbox = new CheckBox();
            Label description = new Label();
            Label update = new Label();
            Label licence = new Label();
            Label updateContent = new Label();
            Label licenceContent = new Label();
            newPanel.Size = new Size(493, 88);
            newPanel.BackColor = Color.Gainsboro;
            newPanel.Controls.Add(newCheckbox);
            newPanel.Controls.Add(description);
            newPanel.Controls.Add(update);
            newPanel.Controls.Add(licence);
            newPanel.Controls.Add(updateContent);
            newPanel.Controls.Add(licenceContent);

            newCheckbox.Location = new Point(10, 8);
            newCheckbox.Text = name;
            // evenhandler for checking event of each checkbox in each created panel.
            newCheckbox.CheckedChanged += new EventHandler(checkOnFilter_Changed);
            newCheckbox.Tag = linkFile;

            description.Location = new Point(10, 30);
            description.Size = new Size(470, 35);
            description.Text = descriptionText;

            updateContent.Text = "Update:";
            licenceContent.Text = "Licence:";
            updateContent.Location = new Point(11, 65);
            licenceContent.Location = new Point(175, 65);

            update.Text = updateText;
            update.Location = new Point(60, 65);
            licence.Location = new Point(226, 65);
            licence.Text = licenceText;
            return newPanel;
        }
        
        private void checkOnFilter_Changed(object sender, EventArgs e)
        {
            btDownloadFilter.Enabled = true;
            if ((sender as CheckBox).Checked == true)
            {
                selectedFilterUrl.Items.Add((sender as CheckBox).Tag);
                selectedFilterName.Items.Add((sender as CheckBox).Text);
            }
            else
            {
                // remove filter out of selected list
                selectedFilterUrl.Items.Remove((sender as CheckBox).Tag);
                selectedFilterName.Items.Remove((sender as CheckBox).Text);
            }
        }
        private void NewCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public filterBrowsing()
        {
            InitializeComponent();
        }
        string fileFilterUpdate = "FilterBaseUpdate";
        private void filterBrowsing_Load(object sender, EventArgs e)
        {
            //download list filter
            using (var client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/zeroclubvn/ChildSafe_Project_X15/master/ChildSafe/filterListUpdate.txt", fileFilterUpdate);
            }
            // open file
            if (File.Exists(fileFilterUpdate))
            {
                // fomular of a custom panel

                // read from file the collection of all available filter
                string[] contents = File.ReadAllText(fileFilterUpdate).Split('@');
                foreach (string content in contents)
                {
                    if (content != "")
                    {
                        string[] filter = content.Split('>');
                        string name = filter[1];
                        string description = filter[2];
                        string linkFile = filter[3];
                        string update = filter[4];
                        string licence = filter[5];
                        // add filters and it's description in to flowlayout list
                        flowLayoutSet.Controls.Add(newControl(name, description,linkFile, update, licence));
                    }

                }
            }
        }
        // a really helpful function to get rid of special charactors in a string
        public static string RemoveSpecialCharacters(string str)
        {
            return Regex.Replace(str, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }
        private void btDownloadFilter_Click(object sender, EventArgs e)
        {
            string path = "FilterBase";
            if (!Directory.Exists(path))
            {
                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
            }
            
            if (selectedFilterUrl.Items.Count > 0)
            {
                // create a thread to download file, this practice will help program not being freeze while downloading file
                string url = selectedFilterUrl.Items[0].ToString();
                string fileName = RemoveSpecialCharacters(selectedFilterName.Items[0].ToString().Replace(' ', '_'));
                Thread thread = new Thread(() =>
                {
                    WebClient client = new WebClient();
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
                    client.DownloadFileAsync(new Uri(url), path+@"\"+fileName);
                });
                thread.Start();
            }
            else
            {
                btDownloadFilter.Enabled = false;
            }
        }
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;
                lbDownloadStatus.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive;
                progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate {
                lbDownloadStatus.Text = "Completed";
                selectedFilterUrl.Items.Remove(selectedFilterUrl.Items[0].ToString());
                selectedFilterName.Items.Remove(selectedFilterName.Items[0].ToString());
                // continue download other files by go back to the downloadfilter process
                btDownloadFilter_Click(null,null);
                if (selectedFilterName.Items.Count <= 0) btOk.Enabled = true;
                else btOk.Enabled = false;
            });
        }

        private void selectedFilterName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
