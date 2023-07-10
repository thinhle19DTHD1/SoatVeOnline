using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;


namespace CheckQRCode
{
    public partial class CheckQRCode : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public CheckQRCode()
        {
            InitializeComponent();
        }

        private void CheckQRCode_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                cbbTpyeDevice.Items.Add(Device.Name);

            cbbTpyeDevice.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void tbnStart_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cbbTpyeDevice.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbQRCode.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CheckQRCode_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pbQRCode.Image); 
            try
            {
                string decoded = result.ToString().Trim();
                if(decoded != "")
                {
                    txtDecoded.Text = decoded;
                }
            }catch(Exception ex) { }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
