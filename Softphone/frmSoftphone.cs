using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;
using Ozeki.Media;
using Ozeki.VoIP;
using NAudio.CoreAudioApi;
namespace Softphone
{
    public partial class frmSoftphone : Form
    {
        #region Softphone Method, Properties

        #region Properties 
        private NAudio.CoreAudioApi.MMDevice[] arrayDevices = new NAudio.CoreAudioApi.MMDevice[3];
        NAudio.CoreAudioApi.MMDeviceEnumerator Devices = new NAudio.CoreAudioApi.MMDeviceEnumerator();
        internal static bool isDisplayNameChange = false;
        List<TimeCall> HistoryCall = new List<TimeCall>();
        private DateTime Today = new DateTime();
        List<string> InfoHistory = new List<string>();
        private int minuteCall;
        private int secondCall;

        public static string[] infoAcc = new string[6];
        public static SIPAccount accountSipInfo = new SIPAccount();
        public static ISoftPhone _softPhone;
        public static IPhoneLine _phoneLine;
        //public static RegState _phoneLineInformation;
        private IPhoneCall _call;
        private Microphone _microphone = Microphone.GetDefaultDevice();
        private Speaker _speaker = Speaker.GetDefaultDevice();
        private MediaConnector _connector = new MediaConnector();
        private PhoneCallAudioSender _mediaSender = new PhoneCallAudioSender();
        private PhoneCallAudioReceiver _mediaReceiver = new PhoneCallAudioReceiver();
        public static AccountInfo SipAccount = new AccountInfo();
        private CallerInfo Caller = new CallerInfo();

        private SoundPlayer player;
        private bool _inComingCall;
        private EventHandler<CallStateChangedArgs> CallStateChanged;
        private bool isInComingCompleted = false;
        #endregion

        #region Initializes Sip, Register, Subcribe events ,Refesh Register


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
                var devices = Devices.EnumerateAudioEndPoints(DataFlow.All, 
                    NAudio.CoreAudioApi.DeviceState.Active);
                arrayDevices = devices.ToArray();
                string userAgent = "Snow";
                _softPhone = SoftPhoneFactory.CreateSoftPhone(
                    SoftPhoneFactory.GetLocalIP(),
                    7000, 9000, userAgent);

                InvokeGUIThread(() =>
                {
                    lb_Log.Items.Add("Softphone created!");
                });

                _softPhone.IncomingCall += softPhone_inComingCall;


                InvokeGUIThread(() =>
                {
                    lb_Log.Items.Add("SIP account created!");
                });
                _phoneLine = _softPhone.CreatePhoneLine(accountSipInfo);

                _phoneLine.RegistrationStateChanged += phoneLine_PhoneLineInformation;
                InvokeGUIThread(() =>
                {
                    lb_Log.Items.Add("Phoneline created.");
                });
                _softPhone.RegisterPhoneLine(_phoneLine);

                _inComingCall = false;

                ConnectMedia();
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() =>
                {
                    lb_Log.Items.Add("Local IP error! " + ex);
                });
            }
        }
        public static void RefeshRegister()
        {
            _softPhone.UnregisterPhoneLine(_phoneLine);
            _phoneLine = _softPhone.CreatePhoneLine(accountSipInfo);
            _softPhone.RegisterPhoneLine(_phoneLine);

        }
        #endregion

        #region Sounds, Setup and Conect devices
        private void StartDevices()
        {
            StartSpeaker();
            StartMicro();
        }
        private void StopDevices()
        {
            StopMicro();
            StopSpeaker();
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
        private void StopMicro()
        {
            if (_microphone != null)
            {
                _microphone.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Stopped."); });
            }
        }
        private void StartMicro()
        {
            _microphone = Microphone.GetDefaultDevice();
            if (_microphone != null)
            {
                _microphone.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Microphone Started."); });
            }
        }
        private void StopSpeaker()
        {
            if (_speaker != null)
            {
                _speaker.Stop();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Stopped."); });
            }
        }
        private void StartSpeaker()
        {
            _speaker = Speaker.GetDefaultDevice();
            if (_speaker != null)
            {
                _speaker.Start();
                InvokeGUIThread(() => { lb_Log.Items.Add("Speaker Started."); });
            }
        }

        #region Sound Style
        private const int ringing = 0;
        private const int hangup = 1;
        private const int holding = 2;
        private const int calling = 3;
        private const int buttonpress = 4;
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
                    case buttonpress:
                        {
                            player.SoundLocation = di.Parent.Parent.FullName + @"\Resource\sounds\cell-phone-1-nr9.wav";
                            player.Load();
                            player.Play();
                        }
                        break;

                }

            }
            catch (Exception ex)
            {
                InvokeGUIThread(() =>
                {
                    lb_Log.Items.Add("Error: " + ex);
                    lb_Log.Items.Add(di.Parent.Parent.FullName);

                });
            }

        }
        #endregion

        #region Handing Events

        private void softPhone_inComingCall(object sender, VoIPEventArgs<IPhoneCall> e)
        {
            InvokeGUIThread(() =>
            {
                lb_Log.Items.Add("Incoming call from: " + e.Item.DialInfo.ToString());
            }); //tb_Display.Text = "Ringing (" + e.Item.DialInfo.Dialed + ")";
            Caller.Id = e.Item.DialInfo.CallerID;
            Caller.Name = e.Item.DialInfo.CallerDisplay;
            _call = e.Item;
            SubcribedCallEvents();
            _inComingCall = true;
            InvokeGUIThread(() =>
            {

            });
            isInComingCompleted = true;
            isCalling = false;
            SetupIncomingCall();

        }
        private void phoneLine_PhoneLineInformation(object sender, RegistrationStateChangedArgs e)
        {

            InvokeGUIThread(() =>
            {
                //dont do anything
            });
        }
        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            try
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Callstate changed." + e.State.ToString()); });// tb_Display.Text = e.State.ToString();

                if (e.State == CallState.Answered)
                {
                    player.Stop();
                    StartDevices();

                    _mediaReceiver.AttachToCall(_call);
                    _mediaSender.AttachToCall(_call);

                    SetupAnswered();
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call started."); });
                }

                if (e.State == CallState.InCall)
                {
                    player.Stop();
                    StartDevices();
                    InvokeGUIThread(() =>
                    {

                    });
                }

                if (e.State.IsCallEnded() || e.State == CallState.Rejected)
                {
                    StopDevices();

                    _mediaReceiver.Detach();
                    _mediaSender.Detach();

                    UnSubcribedCallEvents();
                    if (isInComingCompleted)
                    {
                        isInComingCompleted = false;
                        InvokeGUIThread(() =>
                        {

                        });
                    }
                    InvokeGUIThread(() =>
                    {

                    });
                    _call = null;
                    EndCalling();
                    InvokeGUIThread(() =>
                    {
                        lb_Log.Items.Add("Call ended.");
                        playSound(hangup);
                    });

                }

                if (e.State == CallState.LocalHeld)
                {
                    InvokeGUIThread(() => { lb_Log.Items.Add("Call Holding."); });
                    StopDevices();
                }
                if (e.State == CallState.RemoteHeld)
                {
                    InvokeGUIThread(() => { lb_Log.Items.Add("Callee Holding."); });
                    InvokeGUIThread(() => { playSound(holding); });
                }
                if (e.State == CallState.Ringing)
                {
                    InvokeGUIThread(() =>
                    {
                        if (isCalling)
                            playSound(calling);
                        else
                            playSound(ringing);
                    });

                }

                DispatchAsync(() =>
                {
                    var handler = CallStateChanged;
                    if (handler != null)
                        handler(this, e);
                });
            }
            catch (Exception ex)
            {

            }
        }
        private void DispatchAsync(Action action)
        {
            var task = new WaitCallback(o => action.Invoke());
            ThreadPool.QueueUserWorkItem(task);
        }
        #endregion

        #region Handling Threading
        private void InvokeGUIThread(Action action)
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

        #region Subcribe, Unsubcribe Calling events
        private void SubcribedCallEvents()
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
        private void UnSubcribedCallEvents()
        {
            try
            {
                _call.CallStateChanged -= (call_CallStateChanged);
            }
            catch (Exception ex)
            {
                InvokeGUIThread(() => { lb_Log.Items.Add("Error: " + ex); });
            }
        }

        #endregion

        #region Check Status Variable 
        public static bool isRegister = false;
        public static bool isHold = false;
        public static bool isCalling = false;
        public static bool isComing = false;
        public static bool isRejecting = false;
        public static bool isMissing = true;
        #endregion

        #region Information CallerId, CallerDisplay
        private string GetCallerID()
        {
            return Caller.Id;
        }
        private string GetCallerDisplay()
        {
            return Caller.Name;
        }
        #endregion

        #region Information Issues registering Sip Account
        private string GetInfoError()
        {
            return SipAccount.StatusInfor();

        }
        #endregion

        #region Setup When CallEvent Change
        private void SetupIncomingCall()
        {
            InvokeGUIThread(() =>
            {
                this.Width = 767;
                lblInfoCall.Text = "InComing";
                lblName.Text = GetCallerDisplay();
                lblNumberCaller.Text = GetCallerID();
                isComing = true;
                pnlControlIncoming.Visible = true;
                RefeshControlCall();
            });
        }
        private void SetupAnswered()
        {
            InvokeGUIThread(() =>
            {
                pnlControlIncoming.Visible = false;
                isMissing = false;
                pnlControl.Enabled = true;
                btnHangup.Visible = true;
                lblInfoCall.Text = "InCall";
                RefeshTimerCall();
                timerCall.Start();
                meterSoundMicro.Start();
            });
        }
        private void SetupHolding()
        {
            if (isActiveHold)
            {
                lblInfoCall.Text = "Holding";
            }
            else
            {
                lblInfoCall.Text = "Incall";
            }

        }
        private void EndCalling()
        {

            InvokeGUIThread(() =>
            {
                pnlControl.Enabled = false;
                pnlControlIncoming.Visible = false;
                btnHangup.Visible = false;
                lblInfoCall.Text = "Call Ended";
                this.Width = 302;
                timerCall.Stop();
                lblTimerCall.Visible = false;
                GetInforIDCall();
                meterSoundMicro.Stop();
            });
        }
        //working on
        private void GetInforIDCall()
        {
            TimeCall infoCallId = new TimeCall();
            infoCallId.timeCall = lblTimerCall.Text;
            if (isCalling)
            {
                infoCallId.idCall = ListIDCall.calling;
                infoCallId.name = txtNumber.Text;
                infoCallId.number = txtNumber.Text;
            }
            else if (isComing)
            {
                if (isRejecting || isMissing) infoCallId.idCall = ListIDCall.missing;
                else infoCallId.idCall = ListIDCall.inComing;
                infoCallId.name = GetCallerDisplay();
                infoCallId.number = GetCallerID();
            }
            Today = DateTime.Now;
            infoCallId.dateCall = Today.ToShortDateString();
            infoCallId.timeDateCall = Today.ToShortTimeString();
            lb_Log.Items.Add(infoCallId.getData());
            HistoryCall.Add(infoCallId);
            InfoHistory.Add(infoCallId.getData());
            txtNumber.Text = string.Empty;
            txtNumber.Focus();
        }
        private void SetupCalling()
        {
            btnHangup.Visible = true;
            isCalling = true;
            lblInfoCall.Text = "Calling";
            lblName.Text = txtNumber.Text;
            lblNumberCaller.Text = txtNumber.Text;
            //isMissing = false;
        }
        private void RefeshIdCall()
        {
            isCalling = false;
            isComing = false;
            isRejecting = false;
            isMissing = true;
        }
        private void RefeshTimerCall()
        {
            lblTimerCall.Text = "00:00";
            lblTimerCall.Visible = true;
            minuteCall = 0;
            secondCall = 0;

        }
        private void RefeshControlCall()
        {
            isActiveHold = false;
            isActiveMute = false;
            isActiveNosound = false;
            isActiveRecord = false;
            btnHold.BackColor = SystemColors.InfoText;
            btnSpeaker.BackColor = SystemColors.InfoText;
            btnMute.BackColor = SystemColors.InfoText;
            btnRecord.BackColor = SystemColors.InfoText;
        }
        #endregion

        #region Call, Calling Answer Reject Hangup Hold Ignore

        private void Calling()
        {
            if (_call != null || !(_phoneLine.RegState == RegState.RegistrationSucceeded))
            {
                InvokeGUIThread(() =>
                {
                    lb_Log.Items.Add("Call error: " +
                    _phoneLine.RegistrationInfo.StatusCode.ToString());
                });
                return;
            }
            SetupCalling();
            _call = _softPhone.CreateCallObject(_phoneLine, txtNumber.Text);
            SubcribedCallEvents();
            _call.Start();
            RefeshControlCall();



        }
        private void Answering()
        {
            if (_call != null)
            {
                _inComingCall = false;
                _call.Answer();
                InvokeGUIThread(() => { lb_Log.Items.Add("Call accepted."); });
            }
        }
        private void Hanguping()
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


        }
        private void Holding()
        {
            if (_call == null)
                return;

            if (!isHold)
            {
                _call.Hold();
                isHold = true;
                InvokeGUIThread(() => { playSound(holding); });

            }
            else
            {
                isHold = false;
                _call.Unhold();
                player.Stop();
            }
            SetupHolding();
        }
        private void Rejecting()
        {
            if (_call != null) _call.Reject();
        }
        private void Ignoring()
        {

        }
        #endregion

        #endregion

        #region Handling File ,Setup information Account

        public static void SetInfoAcc()
        {
            accountSipInfo.DisplayName = infoAcc[0];
            accountSipInfo.DomainServerHost = infoAcc[1];
            accountSipInfo.UserName = infoAcc[2];
            accountSipInfo.RegisterName = infoAcc[2];
            accountSipInfo.RegisterPassword = infoAcc[3];
            if (infoAcc[4] != "") accountSipInfo.DomainServerPort = Convert.ToInt32(infoAcc[4]);
            else accountSipInfo.DomainServerPort = 5060;
            accountSipInfo.RegistrationRequired = true;

        }
        private string CreatFile(string fileName)
        {
            //create path file
            string file = Environment.CurrentDirectory + @"\" + fileName;

            if (!File.Exists(file))
            {
                File.CreateText(file);
            }
            return file;
        }
        private string WriteFile(string fileName, string[] info, int numberLine)
        {
            //writing information into file
            try
            {
                //if (!File.Exists(fileName)) return "Error";
                using (StreamWriter accountConfig = new StreamWriter(fileName))
                {
                    //writing    
                    for (int i = 0; i < numberLine; ++i)
                    {
                        accountConfig.WriteLine(info[i]);
                    }

                }
                return "Succecced";
            }
            catch (Exception ex)
            {
                return "Error" + ex;
            }
        }
        private string ReadFile(string fileName, string[] info, int numberLine)
        {
            //if (!File.Exists(fileName)) return "Error";
            try
            {
                using (StreamReader accountConfig = new StreamReader(fileName))
                {
                    //reading 
                    for (int i = 0; i < numberLine; ++i)
                    {
                        info[i] = accountConfig.ReadLine();
                    }
                }
                return "Succecced";
            }
            catch (Exception ex)
            {
                return "Error" + ex;
            }
        }
        private void DeleteFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
        }

        #endregion

        #region Setup, Loading information account
        public frmSoftphone()
        {
            InitializeComponent();
            FormClosing += FrmSoftphone_FormClosing;
        }
        private void FrmSoftphone_FormClosing(object sender, FormClosingEventArgs e)
        {
            string file = CreatFile("cfgacc.ino");
            WriteFile(file, infoAcc, 5);
            _softPhone.IncomingCall -= softPhone_inComingCall;
            _phoneLine.RegistrationStateChanged -= phoneLine_PhoneLineInformation;
            _softPhone.UnregisterPhoneLine(_phoneLine);
            _softPhone.Close();
        }
        private void frmSoftphone_Load(object sender, EventArgs e)
        {
            try
            {
                cbxStatus.SelectedIndexChanged += CbxStatus_SelectedIndexChanged;
                this.Text = "Snow";
                this.Width = 302;
                pcSpeaker.BackColor = Color.DarkSlateGray;
                pcMicro.BackColor = Color.DarkSlateGray;
                AsynThread(() =>
                {
                    string file = CreatFile("cfgacc.ino");
                    lb_Log.Items.Add("Reading file - " + ReadFile(file, infoAcc, 5));
                    lb_Log.Items.Add("Setting information Account... ");
                    SetInfoAcc();
                    InitializeSoftPhone();
                    txtNumber.Enabled = false;

                });
                TimerRegister.Start();
                timeCheckStatus.Start();
                this.Text = "Snow-" + infoAcc[0];
            }
            catch (Exception ex)
            {
                lb_Log.Items.Add("Loading error... " + ex);
            }
        }
        private void AsynThread(Action action)
        {
            Invoke(action);
        }

        #endregion

        #region Menu control
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Width = 302;
        }
        private void menuSubVdailpad_Click(object sender, EventArgs e)
        {
            if (menuSubVdailpad.Checked)
            {
                menuSubVdailpad.Checked = false;
            }
            else
            {
                menuSubVdailpad.Checked = true;
            }
        }
        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount sipAccount = new frmAccount();
            sipAccount.Show();
            this.Width = 302;
        }
        private void menuParentabout_Click(object sender, EventArgs e)
        {
            this.Width = 826;

        }
        #endregion

        #region Control Incoming
        private void btnAccpect_Click(object sender, EventArgs e)
        {
            Answering();
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            Rejecting();
        }
        private void btnIgnore_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
        #endregion        

        #region Control Incall (Calling TimeCall)

        #region Status Incall Boolean Variable
        private bool isActiveMute = false;
        private bool isActiveNosound = false;
        private bool isActiveHold = false;
        private bool isActiveRecord = false;
        #endregion
        private void btnSpeaker_Click(object sender, EventArgs e)
        {
            if (!isActiveNosound)
            {
                isActiveNosound = true;
                btnSpeaker.BackColor = Color.DarkOrange;
                StartSpeaker();
            }
            else
            {
                isActiveNosound = false;
                btnSpeaker.BackColor = SystemColors.InfoText;
                StopSpeaker();
            }
        }
        private void btnHold_Click(object sender, EventArgs e)
        {
            if (!isActiveHold)
            {
                isActiveHold = true;
                btnHold.BackColor = Color.DarkOrange;
            }
            else
            {
                isActiveHold = false;
                btnHold.BackColor = SystemColors.InfoText;
            }
            Holding();
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!isActiveRecord)
            {
                isActiveRecord = true;
                btnRecord.BackColor = Color.DarkOrange;

            }
            else
            {
                isActiveRecord = false;
                btnRecord.BackColor = SystemColors.InfoText;
            }
        }
        private void btnMute_Click(object sender, EventArgs e)
        {
            if (!isActiveMute)
            {
                isActiveMute = true;
                btnMute.BackColor = Color.DarkOrange;
                StopMicro();
            }
            else
            {
                isActiveMute = false;
                btnMute.BackColor = SystemColors.InfoText;
                StartMicro();
            }
        }
        private void meterSoundMicro_Tick(object sender, EventArgs e)
        {
            int valueSpeakerMeter = (int)
                (Math.Round(arrayDevices[0].AudioMeterInformation.MasterPeakValue
                * 100 + 0.5));
            int valueMicroMeter = (int)
                (Math.Round(arrayDevices[1].AudioMeterInformation.MasterPeakValue
                * 100 + 0.5));
            
            int xspeaker = (int)(Math.Round((valueSpeakerMeter / 100.0) * 72 +0.5));
            int xmicro = (int)(Math.Round((valueMicroMeter / 100.0) * 72 + 0.5));

            lblHideMicro.Location = new System.Drawing.Point(10 + xmicro, 88);
            lblHide.Location = new System.Drawing.Point(158 + xspeaker, 88);
            pcSpeaker.Value = valueSpeakerMeter;
            pcMicro.Value = valueMicroMeter;
            
            
        }

        #region Control time call
        private void timerCall_Tick(object sender, EventArgs e)
        {
            secondCall++;
            if (secondCall == 60)
            {
                ++minuteCall;
                secondCall = 0;
            }
            string second = secondCall < 10 ? "0" + Convert.ToString(secondCall)
                                                : Convert.ToString(secondCall);
            string minute = minuteCall < 10 ? "0" + Convert.ToString(minuteCall)
                                                : Convert.ToString(minuteCall);
            lblTimerCall.Text = minute + ":" + second;
        }
        #endregion

        #region Control Calling
        private void btnHangup_Click(object sender, EventArgs e)
        {
            Hanguping();
        }
        #endregion

        #endregion

        #region Status account, Register again, Show error

        #region Registering each 5 seconds (Success => Stop ; Fail more 3 => Stop)
        private void TimerRegister_Tick(object sender, EventArgs e)
        {
            if (!(_phoneLine.RegState == RegState.RegistrationSucceeded))
            {
                if (_phoneLine.RegState == RegState.Error)
                {
                    SipAccount.StatusCode_ = _phoneLine.RegistrationInfo.StatusCode;
                    lb_Log.Items.Add("Registration error ");
                    bool result = SipAccount.Checking();
                    if (!result)
                    {
                        lb_Log.Items.Add(SipAccount.StatusInfor());
                        llblRetry.Visible = true;
                        llblAccount.Visible = true;
                        TimerRegister.Stop();
                    }
                    else if (SipAccount.allowRegister_)
                    {
                        _softPhone.RegisterPhoneLine(_phoneLine);
                    }


                }
            }
        }
        #endregion

        #region Status => Fail => Registering run again
        private void CbxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxStatus.SelectedIndex == 0)
            {
                TimerRegister.Start();
            }
        }
        #endregion

        #region Register again
        private void btnRetry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llblRetry.Visible = false;
            SipAccount.RefeshRegister();
            AsynThread(() =>
            {
                _softPhone.RegisterPhoneLine(_phoneLine);
            });
            TimerRegister.Start();

        }
        private void llblAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAccount sipAccount = new frmAccount();
            sipAccount.Show();
            this.Width = 302;
        }
        #endregion

        #region Check Status each 2 seconds
        private void timeCheckStatus_Tick(object sender, EventArgs e)
        {
            if (_phoneLine.RegState == RegState.RegistrationSucceeded)
            {
                cbxStatus.SelectedIndex = 1;
                pbxStatus.Image = Properties.Resources.presenceAvailable;
                txtNumber.Enabled = true;
                pnlDialPad.Enabled = true;
                btnDial.Enabled = true;
            }
            else
            {
                cbxStatus.SelectedIndex = 0;
                pbxStatus.Image = Properties.Resources.offline;
                txtNumber.Enabled = false;
                pnlDialPad.Enabled = false;
                btnDial.Enabled = false;
            }
            lb_Log.TopIndex = lb_Log.Items.Count - 1;
            if (isDisplayNameChange)
            {
                this.Text = "Snow-" + infoAcc[0];
                isDisplayNameChange = false;
            }
        }
        #endregion

        #endregion

        #region Checking isCalling
        private void btnDial_Click(object sender, EventArgs e)
        {
            if (txtNumber.Text != string.Empty)
            {
                Calling();
                this.Width = 767;
            }
        }
        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNumber.Text != "")
                {
                    Calling();
                    this.Width = 767;
                }
            }
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }
        #endregion

        #region Handle show DialPad Contact History LogStatus
        private void btnShowcontact_Click(object sender, EventArgs e)
        {
            tvHistory.Visible = false;
            pnlDialPad.Visible = false;
            lb_Log.Visible = false;
            btnShowcontact.BackColor = Color.DarkOrange;
            btnShowHistory.BackColor = SystemColors.InactiveCaption;
            btnShowdialpad.BackColor = SystemColors.InactiveCaption;
            btnShowLog.BackColor = SystemColors.InactiveCaption;
        }
        private void btnShowlog_Click(object sender, EventArgs e)
        {
            tvHistory.Visible = false;
            lb_Log.Visible = true;
            pnlDialPad.Visible = false;
            btnShowLog.BackColor = Color.DarkOrange;
            btnShowcontact.BackColor = SystemColors.InactiveCaption;
            btnShowHistory.BackColor = SystemColors.InactiveCaption;
            btnShowdialpad.BackColor = SystemColors.InactiveCaption;

        }
        private void btnShowdialpad_Click(object sender, EventArgs e)
        {
            tvHistory.Visible = false;
            pnlDialPad.Visible = true;
            lb_Log.Visible = false;
            btnShowdialpad.BackColor = Color.DarkOrange;
            btnShowcontact.BackColor = SystemColors.InactiveCaption;
            btnShowHistory.BackColor = SystemColors.InactiveCaption;
            btnShowLog.BackColor = SystemColors.InactiveCaption;
        }
        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            tvHistory.Visible = true;
            pnlDialPad.Visible = false;
            lb_Log.Visible = false;
            btnShowHistory.BackColor = Color.DarkOrange;
            btnShowcontact.BackColor = SystemColors.InactiveCaption;
            btnShowdialpad.BackColor = SystemColors.InactiveCaption;
            btnShowLog.BackColor = SystemColors.InactiveCaption;
        }

        #endregion

        #region Input DialPad
        private void btn1_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "1";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "2";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "3";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "4";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "5";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "6";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "7";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "8";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "9";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btnAsterisk_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "*";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "0";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        private void btnHashtag_Click(object sender, EventArgs e)
        {
            txtNumber.SelectedText += "#";
            InvokeGUIThread(() =>
            {
                playSound(buttonpress);
            });
        }

        #endregion

<<<<<<< HEAD
=======


>>>>>>> e74f86a5b436776b7edf81c21cade8a538250bb3
    }
}
