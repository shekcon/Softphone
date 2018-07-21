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
    public partial class statusAccount : Form
    {
        public statusAccount()
        {
            InitializeComponent();
        }

        private void statusAccount_Load(object sender, EventArgs e)
        {
           
        }

        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxStatus.SelectedIndex)
            {
                case 0: {
                        pbxStatus.Image = Properties.Resources.presenceAvailable;
                    } break;

                case 1: {
                        pbxStatus.Image = Properties.Resources.presenceOffline;
                    } break;

                case 2: { } break;

                case 3: { } break;
            }
        }
    }
}
