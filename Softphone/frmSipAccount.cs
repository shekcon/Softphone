using System;
using System.IO;
using System.Media;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.VoIP;


namespace Softphone
{
    public partial class frmSipAccount : Form
    {
        #region Softphone Method, Properties
        
        #region Properties 
        public static ISoftPhone _softPhone;
        public static IPhoneLine _phoneLine;
        public static RegState _phoneLineInformation;
        public static IPhoneCall _call;
        private Microphone _microphone = Microphone.GetDefaultDevice();
        private Speaker _speaker = Speaker.GetDefaultDevice();
        private MediaConnector _connector = new MediaConnector();
        private PhoneCallAudioSender _mediaSender = new PhoneCallAudioSender();
        private PhoneCallAudioReceiver _mediaReceiver = new PhoneCallAudioReceiver();
       
        private static SoundPlayer player;
        private static bool _inComingCall;
        public event EventHandler<CallStateChangedArgs> CallStateChanged;
        private bool isInComingCompleted = false;
        #endregion

        #region Initializes Sip, Register, Subcribe events 
        /// <summary>
        /// Initializes the softphone logic
        /// Subscribes change events to get notifications.
        /// Register info event
        /// Incoming call event
        /// </summary>
        private void InitializeSoftPhone()
        {
            try
            {
                var displayName = txtDisplayName.Text;
                string userName = txtUsername.Text;
                string authenticationId = userName;
                string password = txtPassword.Text;
                string domain = txtDomain.Text;
                int port = int.Parse(txtPort.Text);
                var userAgent = "Snowday";
                _softPhone = SoftPhoneFactory.CreateSoftPhone(
                    SoftPhoneFactory.GetLocalIP(), 
                    7000, 9000, userAgent);
               
                InvokeGUIThread(() => {
                    lb_Log.Items.Add("Softphone created!");
                });

                _softPhone.IncomingCall += softPhone_inComingCall;

                SIPAccount account_S = new SIPAccount(true,
                          displayName, 
                          userName, 
                          authenticationId, 
                          password, 
                          domain, 
                          port);
                InvokeGUIThread(() => {
                    lb_Log.Items.Add("SIP account created!");
                });

                _phoneLine = _softPhone.CreatePhoneLine(account_S);
                _phoneLine.RegistrationStateChanged += phoneLine_PhoneLineInformation;
                InvokeGUIThread(() => {
                    lb_Log.Items.Add("Phoneline created.");
                });
                _softPhone.RegisterPhoneLine(_phoneLine);

                _inComingCall = false;

                ConnectMedia();
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => {
                    lb_Log.Items.Add("Local IP error! " + ex);
                });
            }
        }
        #endregion

        #region Sounds, Conecting devices
        private void StartDevices()
        {
            if (_microphone != null)
            {
                _microphone.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Started."); });
            }

            if (_speaker != null)
            {
                _speaker.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Started."); });
            }
        }
        private void StopDevices()
        {
            if (_microphone != null)
            {
                _microphone.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Stopped."); });
            }

            if (_speaker != null)
            {
                _speaker.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Stopped."); });
            }
        }
        private void ConnectMedia()
        {
            if (_microphone != null)
            {
                _connector.Connect(_microphone, _mediaSender);
            }

            if (_speaker != null)
            {
                _connector.Connect(_mediaReceiver, _speaker);
            }
        }
        private void DisconnectMedia()
        {
            if (_microphone != null)
            {
                _connector.Disconnect(_microphone, _mediaSender);
            }

            if (_speaker != null)
            {
                _connector.Disconnect(_mediaReceiver, _speaker);
            }
        }

        #region Sound Style
        private const int ringing = 0;
        private const int hangup = 1;
        private const int holding = 2;
        private const int calling = 3;
        #endregion
        /// <summary>
        /// Calling
        /// Ringing
        /// Hangup
        /// Holding
        /// </summary>
        /// <param name="namefile"></param>
        private void playSound(int nameSound)
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            player = new SoundPlayer();
            try
            {
                switch (nameSound)
                {
                    case ringing:
                        {
                            player.SoundLocation = di.Parent.Parent.FullName + @"\Resource\sounds\ring.wav";
                            player.Load();
                            player.PlayLooping();
                        }
                        break;

                    case hangup:
                        {
                            player.SoundLocation = di.Parent.Parent.FullName + @"\Resource\sounds\hangup.wav";
                            player.Load();
                            player.PlaySync();
                        }
                        break;

                    case holding:
                        {
                            player.SoundLocation = di.Parent.Parent.FullName + @"\Resource\sounds\hold_music.wav";
                            player.Load();
                            player.PlayLooping();
                        }
                        break;
                    case calling:
                        {
                            player.SoundLocation = di.Parent.Parent.FullName + @"\Resource\sounds\calling.wav";
                            player.Load();
                            player.PlayLooping();
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Error: " + ex); });
            }

        }
        #endregion

        #region Handing Events
        private void softPhone_inComingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Incoming call from: " + e.Item.DialInfo.ToString());  }); //tb_Display.Text = "Ringing (" + e.Item.DialInfo.Dialed + ")";

            
            _call = e.Item;
            WireUpCallEvents();
            _inComingCall = true;
            InvokeGUIThread(() =>
            {
                btnAccpect.Enabled = true;
                btnAccpect.BackColor = Color.Red;
                btnAccpect.ForeColor = Color.Snow;
            });
            isInComingCompleted = true;
            isCalling = false;
            //frmCalling Call_Event = new frmCalling();
            //Call_Event.ShowDialog();

        }
        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {
            _phoneLineInformation = e.State;

            InvokeGUIThread(() =>
            {
                if (_phoneLineInformation == RegState.RegistrationSucceeded)
                {
                    lb_Log.Items.Add("Registration succeeded - Online");
                    btnRegister.Text = "UnRegister";
                    pbxStatus.Image = Properties.Resources.presenceAvailable;
                    cbxStatus.SelectedIndex = 1;
                    //cbxStatus.ForeColor = Color.LightGreen;
                }
                else
                {
                    lb_Log.Items.Add("Not registered - Offline: " + _phoneLineInformation.ToString());
                    //btnRegister.Text = "Error";
                }

            });
        }
        public void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Callstate changed." + e.State.ToString());  });// tb_Display.Text = e.State.ToString();

            if (e.State == CallState.Answered)
            {
                player.Stop(); 
                StartDevices();

                _mediaReceiver.AttachToCall(_call);
                _mediaSender.AttachToCall(_call);


                InvokeGUIThread(() => { lb_Log.Items.Add("Call started."); });
            }

            if (e.State == CallState.InCall)
            {
                isCalling = false;
                player.Stop();
                StartDevices();
                InvokeGUIThread(() => {
                    btnHangup.Enabled = true;
                    btnHold.Enabled = true;
                    btnHangup.BackColor = Color.Red;
                    btnHangup.ForeColor = Color.Snow;
                    btnHold.BackColor = Color.Red;
                    btnHold.ForeColor = Color.Snow;
                });
            }

            if (e.State.IsCallEnded())
            {
                StopDevices();

                _mediaReceiver.Detach();
                _mediaSender.Detach();

                WireDownCallEvents();
                if (isInComingCompleted)
                {
                    isInComingCompleted = false;
                    InvokeGUIThread(() => 
                    {
                        btnAccpect.Enabled = false;
                        btnAccpect.BackColor = Color.Teal;
                        btnAccpect.ForeColor = Color.DimGray;
                        btnHold.Enabled = false;
                        btnHangup.Enabled = false;
                        btnHold.BackColor = Color.Teal;
                        btnHold.ForeColor = Color.DimGray;
                        btnHangup.BackColor = Color.Teal;
                        btnHangup.ForeColor = Color.DimGray;
                    });
                }
                InvokeGUIThread(() =>
                {
                    btnHold.Enabled = false;
                    btnHangup.Enabled = false;
                    btnHold.BackColor = Color.Teal;
                    btnHold.ForeColor = Color.DimGray;
                    btnHangup.BackColor = Color.Teal;
                    btnHangup.ForeColor = Color.DimGray;
                });
                _call = null;

                InvokeGUIThread(() => {
                    lb_Log.Items.Add("Call ended.");
                    playSound(hangup);
                });

            }

            if (e.State == CallState.LocalHeld)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Call Hold."); });
                StopDevices();
            }
            if(e.State == CallState.RemoteHeld)
            {
                InvokeGUIThread(() => { playSound(holding); });
            }
            if(e.State == CallState.Ringing)
            {
                InvokeGUIThread(() => {
                    if (isCalling)
                        playSound(calling);
                    else
                    playSound(ringing); });
                
            }

            DispatchAsync(() =>
            {
                var handler = CallStateChanged;
                if (handler != null)
                    handler(this, e);
            });

        }
        private void DispatchAsync(Action action)
        {
            var task = new WaitCallback(o => action.Invoke());
            ThreadPool.QueueUserWorkItem(task);
        }
        #endregion

        #region Handling Threading
        public void InvokeGUIThread(Action action)
        {
            Invoke(action);
        }
        #endregion

        #region Subcribe, Unsubcribe Calling events
        private void WireUpCallEvents()
        {
            try
            {
                _call.CallStateChanged += (call_CallStateChanged);
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Error: " + ex); });
            }
        }
        private void WireDownCallEvents()
        {
            try
            {
                _call.CallStateChanged -= (call_CallStateChanged);
            }catch(Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Error: " + ex); });
            }
        }

        #endregion

        #region Check Status Variable 
        public static bool isRegister = false;
        public static bool isHold = false;
        public static bool isCalling = false;
        #endregion

        #region Handling Calling Answer Hangup Hold
        public void Calling()
        {
            if (_call != null  || !(_phoneLineInformation.IsRegistered()) )
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Call error: "+_phoneLineInformation.ToString()); });
                return;
            }
            _call = _softPhone.CreateCallObject(_phoneLine, txtNumber.Text);
            WireUpCallEvents();
            _call.Start();
            
            

        }
        public void Answering()
        {
            _inComingCall = false;
            _call.Answer();
            InvokeGUIThread(() => { lb_Log.Items.Add("Call accepted."); });
        }
        public void Hang_Up()
        {
            if (_call != null)
            {
                if (_inComingCall && _call.CallState == CallState.Ringing)
                {
                    _call.Reject();
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call rejected."); });
                }
                else
                {
                    _call.HangUp();
                    _inComingCall = false;
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call hanged up."); });
                }

                _call = null;
            }

            //txtNumber.Text = string.Empty;
        }
        public void Hold()
        {
            if (_call == null)
                return;

            if (!isHold)
            {
                _call.Hold();
                //btnHold.Text = "Unhold";
                isHold = true;
                InvokeGUIThread(() => { playSound(holding); });

            }
            else
            {
                btnHold.Text = "Hold";
                isHold = false;
                _call.Unhold();
                player.Stop();
            }
        }
        #endregion

        #endregion

        #region Handling Setup , Load Info-default for Softphone
        public frmSipAccount()
        {
            InitializeComponent();
        }
        private void frmSipAccount_Load(object sender, EventArgs e)
        {
            btnAccpect.Enabled = false;
            txtPort.SelectedText = "5060";
            txtPassword.SelectedText = "123456";
            txtDomain.SelectedText = "192.168.1.5";
            txtDisplayName.SelectedText = "Snowday";
            txtUsername.SelectedText = "100";
            txtNumber.SelectedText = "101";
            txtPort.Enabled = false;
            pbxStatus.Image = Properties.Resources.presenceOffline;
            cbxStatus.SelectedIndex = 0;
            btnHangup.Enabled = false;
            btnAccpect.Enabled = false;
            btnHold.Enabled = false;
        }
        #endregion

        #region Handling Control Interface User
        private void btnAccpect_Click(object sender, EventArgs e)
        {
            Answering();
        }
        private void btnResisger_Click(object sender, EventArgs e)
        {
            if (!isRegister)
            {
                InitializeSoftPhone();
                btnRegister.Text = "Registering";
                isRegister = true;
            }else
            {
                isRegister = false;
                btnRegister.Text = "Register";
                if(_phoneLineInformation.IsRegistered())
                   _softPhone.UnregisterPhoneLine(_phoneLine);
                cbxStatus.SelectedIndex = 0;
                pbxStatus.Image = Properties.Resources.presenceOffline;
            }
            
        }
        private void btnDial_Click(object sender, EventArgs e)
        {
            isCalling = true;
            Calling();    
            
        }
        private void btnHold_Click(object sender, EventArgs e)
        {
            Hold();
        }
        private void btnHangup_Click(object sender, EventArgs e)
        {
            Hang_Up();
        }
        private void cbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Calling();
            }
        }
        #endregion
    }
}
