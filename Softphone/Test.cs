using System;
using System.Windows.Forms;
using Ozeki.Media;
using Ozeki.VoIP;

namespace Softphone
{
    public partial class Test : Form
    {

        private ISoftPhone _softPhone;
        private IPhoneLine _phoneLine;
        private RegState _phoneLineInformation;
        private IPhoneCall _call;
        private Microphone _microphone = Microphone.GetDefaultDevice();
        private Speaker _speaker = Speaker.GetDefaultDevice();
        MediaConnector _connector = new MediaConnector();
        PhoneCallAudioSender _mediaSender = new PhoneCallAudioSender();
        PhoneCallAudioReceiver _mediaReceiver = new PhoneCallAudioReceiver();

        private bool _inComingCall;

        private string _reDialNumber;

        private bool _localHeld;

        public Test()
        {
            InitializeComponent();
            
        }


        private void InitializeSoftPhone()
        {
            try
            {
                var userAgent = "MyFirstSoftPhone-3-example";
                _softPhone = SoftPhoneFactory.CreateSoftPhone(SoftPhoneFactory.GetLocalIP(), 5700, 5750, userAgent);
                InvokeGUIThread(() => { lb_Log.Items.Add("Softphone created!"); });

                _softPhone.IncomingCall += softPhone_inComingCall;

                SIPAccount sa = new SIPAccount(true, "100", "100", "100", "123456", "192.168.1.6", 5060);
                InvokeGUIThread(() => { lb_Log.Items.Add("SIP account created!"); });

                _phoneLine = _softPhone.CreatePhoneLine(sa);
                _phoneLine.RegistrationStateChanged += phoneLine_PhoneLineInformation;
                InvokeGUIThread(() => { lb_Log.Items.Add("Phoneline created."); });
                _softPhone.RegisterPhoneLine(_phoneLine);

                tb_Display.Text = string.Empty;
                lbl_NumberToDial.Text = sa.RegisterName;
                
                _inComingCall = false;
                _reDialNumber = string.Empty;
                _localHeld = false;

                ConnectMedia();
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Local IP error! " + ex); });
            }
        }


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


        private void InvokeGUIThread(Action action)
        {
            Invoke(action);
        }


        private void softPhone_inComingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Incoming call from: " + e.Item.DialInfo.ToString()); tb_Display.Text = "Ringing (" + e.Item.DialInfo.Dialed + ")"; });

            _reDialNumber = e.Item.DialInfo.Dialed;
            _call = e.Item;
            WireUpCallEvents();
            _inComingCall = true;
        }



        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {
            _phoneLineInformation = e.State;

            InvokeGUIThread(() =>
                {
                    if (_phoneLineInformation == RegState.RegistrationSucceeded)
                    {
                        lb_Log.Items.Add("Registration succeeded - Online");
                    }
                    else
                    {
                        lb_Log.Items.Add("Not registered - Offline: " + _phoneLineInformation.ToString());
                    }

                });
        }


        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            InvokeGUIThread(() => { lb_Log.Items.Add("Callstate changed." + e.State.ToString()); tb_Display.Text = e.State.ToString(); });

            if (e.State == CallState.Answered)
            {
                btn_Hold.Enabled = true;
                btn_Hold.Text = "Hold";

                StartDevices();

                _mediaReceiver.AttachToCall(_call);
                _mediaSender.AttachToCall(_call);


                InvokeGUIThread(() => { lb_Log.Items.Add("Call started."); });
            }

            if (e.State == CallState.InCall)
            {
                btn_Hold.Enabled = true;
                btn_Hold.Text = "Hold";
                StartDevices();
            }

            if (e.State.IsCallEnded())
            {
                _localHeld = false;

                StopDevices();

                _mediaReceiver.Detach();
                _mediaSender.Detach();

                WireDownCallEvents();

                _call = null;

                InvokeGUIThread(() => { lb_Log.Items.Add("Call ended."); tb_Display.Text = string.Empty; });
                
            }

            if (e.State == CallState.LocalHeld)
            {
                StopDevices();
            }

        }


        private void WireUpCallEvents()
        {
            _call.CallStateChanged += (call_CallStateChanged);
        }

        private void WireDownCallEvents()
        {
            _call.CallStateChanged -= (call_CallStateChanged);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeSoftPhone();
        }


        private void buttonKeyPadButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;

            if (_call != null) { return; }

            if (btn == null) return;

            tb_Display.Text += btn.Text.Trim();
        }


        private void btn_PickUp_Click(object sender, EventArgs e)
        {
            if (_inComingCall)
            {
                _inComingCall = false;
                _call.Answer();

                InvokeGUIThread(() => { lb_Log.Items.Add("Call accepted."); });
                return;
            }

            if (_call != null)
            {
                return;
            }

            if (_phoneLineInformation != RegState.RegistrationSucceeded)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Registratin Failed!"); tb_Display.Text = "OFFLINE";});
                return;
            }

            _reDialNumber = tb_Display.Text;
            _call = _softPhone.CreateCallObject(_phoneLine, tb_Display.Text);
            WireUpCallEvents();
            _call.Start();   
        }

        private void btn_HangUp_Click(object sender, EventArgs e)
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

            tb_Display.Text = string.Empty;
        }

        private void btn_Redial_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_reDialNumber))
                return;

            if (_call != null)
                return;

            _call = _softPhone.CreateCallObject(_phoneLine, _reDialNumber);
            WireUpCallEvents();
            _call.Start();
        }

        private void btn_Hold_Click(object sender, EventArgs e)
        {
            if (_call == null)
                return;

            if (!_localHeld)
            {
                _call.Hold();
                btn_Hold.Text = "Unhold";
                _localHeld = true;
            }
            else
            {
                btn_Hold.Text = "Hold";
                _localHeld = false;
                _call.Unhold();
            }
        }

        private void btn_Transfer_Click(object sender, EventArgs e)
        {
            string transferTo = "1001";

            if (_call == null)
                return;

            if (string.IsNullOrEmpty(transferTo))
                return;

            _call.BlindTransfer(transferTo);
            lb_Log.Items.Add("Transfering to:" + transferTo);
        }

        private void lbl_NumberToDial_Click(object sender, EventArgs e)
        {

        }
    }
}
