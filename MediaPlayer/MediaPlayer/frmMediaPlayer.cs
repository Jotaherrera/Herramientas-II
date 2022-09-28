using AxWMPLib;
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

namespace MediaPlayer
{
    public partial class frmMediaPlayer : Form
    {
        string[] files, paths;
        public frmMediaPlayer()
        {
            InitializeComponent();
            wmpPlayer.uiMode = "None";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "MP4|*.MP4|All files|*.*";
            openFileDialog.DefaultExt = "MP4";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lstList.Items.Clear();
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;
                wmpPlayer.URL = openFileDialog.FileName;

                for (int i = 0; i < files.Length; i++)
                {
                    lstList.Items.Add(files[i]);
                }

                lstList.SelectedIndex = 0;
                trbVolume.Value = 30;
                lblVolume.Text = trbVolume.Value.ToString();
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpPlayer.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpPlayer.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpPlayer.Ctlcontrols.stop();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex > 0)
            {
                lstList.SelectedIndex = lstList.SelectedIndex - 1;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex < lstList.Items.Count - 1)
            {
                lstList.SelectedIndex = lstList.SelectedIndex + 1;
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (wmpPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                prgbr1.Maximum = (int)wmpPlayer.Ctlcontrols.currentItem.duration;
                prgbr1.Value = (int)wmpPlayer.Ctlcontrols.currentPosition;
            }
            lblTrackStart.Text = wmpPlayer.Ctlcontrols.currentPositionString;
            lblTrackEnd.Text = wmpPlayer.Ctlcontrols.currentItem.durationString.ToString();
        }

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            wmpPlayer.settings.volume = trbVolume.Value;
            lblVolume.Text = trbVolume.Value.ToString();
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmpPlayer.URL = paths[lstList.SelectedIndex];
            wmpPlayer.Ctlcontrols.play();
            tmr1.Start();
        }
    }
}
