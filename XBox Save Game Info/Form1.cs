using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XBox_Save_Game_Info
{
    public partial class Form1 : Form
    {
        string version = "1.0.0";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "XBox Save Game Info v" + version + "\n\nMade by ChrisderWahre 2018", "XBox Save Game Info");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            fbd.Description = "Select the Save Game Folder!";
            fbd.ShowDialog();

            string result = fbd.SelectedPath;

            string titleMetaRaw = System.IO.File.ReadAllText(result + "/TitleMeta.xbx");
            string titleMetaSub = titleMetaRaw.Split(new[] { "TitleName=" }, StringSplitOptions.None)[1];

            titleMetaLabel.Text = titleMetaSub;

            string[] subdirs = Directory.GetDirectories(result);

            if (subdirs.Length > 0)
            {
                // the subdir count is over one, so we are going to use the first subdir to search for the Save meta.

                string saveMetaRaw = File.ReadAllText(subdirs[0] + "/SaveMeta.xbx");
                string saveMetaSub = saveMetaRaw.Split(new[] { "Name=" }, StringSplitOptions.None)[1];

                saveMetaLabel.Text = saveMetaSub;

            } else if (subdirs.Length < 0)
            {
                saveMetaLabel.Text = "Unable to load Save meta.";
            }

            blockSizeLabel.Text = "This feature isn't available yet.";

            //MessageBox.Show(subdirs[0], "test");

            //string[] sizes = {"KB"};
            //double len = new FileInfo(result).Length;
            //int order = 0;
            //while (len >= 1024 && order < sizes.Length - 1)
            //{
              //  order++;
                //len = len / 1024;
            //}

            //string resultByte = String.Format("{0:0.##} {1}", len, sizes[order]);

            //blockSizeLabel.Text = resultByte;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Filter = "Text File|*.txt";
            sfd.Title = "Select a path to save the info!";
            sfd.ShowDialog();

            string result = sfd.FileName;
            string data = "Info dumped by XBox Save Gane Info v" + version + " by ChrisDerWahre\n\n\nTitle Meta: " + titleMetaLabel.Text + "\n\nSave Meta " + saveMetaLabel.Text + "\n\nBlock Size:" + blockSizeLabel.Text;
            using (StreamWriter outputFile = new StreamWriter(result))
            {
                outputFile.WriteLine(data);
            }
        }
    }
}
