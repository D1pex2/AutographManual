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
        private string path = Environment.CurrentDirectory + "/Videos/manualvideo.mp4";

        public VideoForm()
        {
            InitializeComponent();
        }

        private void VideoForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(path))
                {
                    axWindowsMediaPlayer.URL = path;
                }
                else
                {
                    throw new Exception("Видеоролик отсутствует.");
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
    }
}
