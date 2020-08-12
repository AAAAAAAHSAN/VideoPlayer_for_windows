using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoPlayer
{
    public partial class Form1 : Form
    {
        string videoPath, videoTitle;
        public Form1()
        {
            InitializeComponent();
           // wmpVideo.uiMode = "none"; // This will remove the seeking bar ans all the default buttons.
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void BtnOpenVideo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect=false, Filter="MP4 file | *.mp4|All File|*.*"};
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                videoPath = openFileDialog.FileName;
                videoTitle = openFileDialog.SafeFileName;
                wmpVideo.URL = videoPath;
                lblTitle.Text = videoTitle;
            }
        }
    }
}
