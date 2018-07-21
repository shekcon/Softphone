using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Softphone
{
    public partial class ProccessMicroSound : Form
    {
        private MMDevice[] array = new MMDevice[3];
        public ProccessMicroSound()
        {
            InitializeComponent();
            MMDeviceEnumerator Devices = new MMDeviceEnumerator();
            var devices = Devices.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            comboBox1.Items.AddRange(devices.ToArray());

            array = devices.ToArray();
        }

        private void ProccessMicroSound_Load(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

            var device = array[0];
            progressBar1.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100 + 0.5));
            device = array[1];
            progressBar2.Value = (int)(Math.Round(device.AudioMeterInformation.MasterPeakValue * 100 + 0.5));
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
    }
}
