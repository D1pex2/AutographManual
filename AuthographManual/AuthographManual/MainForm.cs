using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthographManual
{
    public partial class MainForm : ParentForm
    {
        private ManualForm manualForm;
        private VideoForm videoForm;
        private TestForm testForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ManualButton_Click(object sender, EventArgs e)
        {
            if (manualForm == null)
            {
                manualForm = new ManualForm();
                manualForm.FormClosing += ManualForm_FormClosing;
            }
            manualForm.Show();
            manualForm.Activate();
        }

        private void ManualForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            manualForm = null;
        }

        private void VideoButton_Click(object sender, EventArgs e)
        {
            if (videoForm == null)
            {
                videoForm = new VideoForm();
                videoForm.FormClosing += VideoForm_FormClosing;
            }
            videoForm.Show();
            videoForm.Activate();
        }

        private void VideoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            videoForm = null;
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            if (testForm == null)
            {
                testForm = new TestForm();
                testForm.FormClosing += TestForm_FormClosing;
            }
            testForm.Show();
            testForm.Activate();
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            testForm = null;
        }
    }
}
