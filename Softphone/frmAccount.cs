using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Ozeki.VoIP;
namespace Softphone
{
    public partial class frmAccount : Form
    {
        
        #region Handling Threading
        public void AsynThread(Action action)
        {
            try
            {
                Invoke(action);
            }
            catch (Exception ex)
            {

            }
        }
        #endregion
        public frmAccount()
        {
            InitializeComponent();
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            frmDisplay renameDisplay = new frmDisplay();
            renameDisplay.ShowDialog();
        }
        private void btnDisplay_MouseHover(object sender, EventArgs e)
        {
            btnDisplay.BackColor = SystemColors.WindowFrame;
            btnDisplay.Image = Properties.Resources.change;
            btnDisplay.ForeColor = Color.WhiteSmoke;
        }
        private void btnDisplay_MouseLeave(object sender, EventArgs e)
        {
            btnDisplay.BackColor = SystemColors.ControlLight;
            btnDisplay.Image = null;
            btnDisplay.ForeColor = SystemColors.InfoText;
        }
        private void CheckStatus()
        {
            if (frmSoftphone._phoneLine.RegState == RegState.RegistrationSucceeded)
            {
                this.Text = "Online";
            }
            else
            {
                this.Text = "Offline";
            }
        }
        private void frmAccount_Load(object sender, EventArgs e)
        {
            CheckStatus();
            txtDomain.Text = frmSoftphone.infoAcc[1];
            btnDisplay.Text = frmSoftphone.infoAcc[0];
            txtUsername.Text = frmSoftphone.infoAcc[2];
            txtPassword.Text = frmSoftphone.infoAcc[3];
            refeshStatus.Start();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmSoftphone.infoAcc[1]= txtDomain.Text;
            frmSoftphone.infoAcc[2]= txtUsername.Text;
            frmSoftphone.infoAcc[3] = txtPassword.Text;
            refeshStatus.Stop();
            AsynThread(() => {
                frmSoftphone.SetInfoAcc();
                frmSoftphone.RefeshRegister();
            });
            CheckStatus();
            refeshStatus.Start();
            
        }
        private void refeshStatus_Tick(object sender, EventArgs e)
        {
            CheckStatus();
            if (btnDisplay.Text != frmSoftphone.infoAcc[0])
            {               
                btnDisplay.Text = frmSoftphone.infoAcc[0];
            }
        }
        private void cbxPort_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void txtPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtDomain.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
            txtPort.Text = "5060";

        }
    }
}
