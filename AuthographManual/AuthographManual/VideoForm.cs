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

namespace AuthographManual
{
    public partial class VideoForm : ParentForm
    {
        private string path = Environment.CurrentDirectory + "/manualvideo.mp4";

        public VideoForm()
        {
            InitializeComponent();
        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeVideo();
                PlayVideo(path);
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void InitializeVideo()
        {
            if(!File.Exists(path))
            {
                File.WriteAllBytes(path, Properties.Resources.manualvideo);
            }
        }

        private void PlayVideo(string url)
        {
            axWindowsMediaPlayer.URL = url;
        }
    }
}
