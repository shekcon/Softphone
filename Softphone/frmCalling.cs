using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.IO;
using Ozeki.VoIP;
using Ozeki.Media;

namespace Softphone
{
    public partial class frmCalling : Form
    {
        private Microphone _microphone = Microphone.GetDefaultDevice();
        private Speaker _speaker = Speaker.GetDefaultDevice();
        private MediaConnector _connector = new MediaConnector();
        private PhoneCallAudioSender _mediaSender = new PhoneCallAudioSender();
        private PhoneCallAudioReceiver _mediaReceiver = new PhoneCallAudioReceiver();

        private static SoundPlayer player;
        private static bool _inComingCall;
        public event EventHandler<CallStateChangedArgs> CallStateChanged;
        private bool isInComingCompleted = false;

        #region Sounds, Conecting devices
        private void StartDevices()
        {
            if (_microphone != null)
            {
                _microphone.Start();
                AsynThread(() => { lb_Log.Items.Add("Microphone Started."); });
            }

            if (_speaker != null)
            {
                _speaker.Start();
               AsynThread(() => { lb_Log.Items.Add("Speaker Started."); });
            }
        }
        private void StopDevices()
        {
            if (_microphone != null)
            {
                _microphone.Stop();
                AsynThread(() => { lb_Log.Items.Add("Microphone Stopped."); });
            }

            if (_speaker != null)
            {
                _speaker.Stop();
                AsynThread(() => { lb_Log.Items.Add("Speaker Stopped."); });
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
                //AsynThread(() => { lb_Log.Items.Add("Error: " + ex); });
            }

        }
        #endregion
        private void call_CallStateChanged(object sender, CallStateChangedArgs e)
        {
            if (e.State == CallState.Answered)
            {
                //player.Stop();
                StartDevices();

                _mediaReceiver.AttachToCall(frmSipAccount._call);
                _mediaSender.AttachToCall(frmSipAccount._call);


                AsynThread(() => { lb_Log.Items.Add("Call started."); });
            }
            if (e.State == CallState.InCall)
            {
                //isCalling = false;
                player.Stop();
                StartDevices();
            }
            if (e.State.IsCallEnded())
            {
                StopDevices();

                _mediaReceiver.Detach();
                _mediaSender.Detach();
                UnSubcribeCallEvents();
            }
            if (e.State == CallState.LocalHeld)
            {
                AsynThread(() => { lb_Log.Items.Add("Call Hold."); });
                StopDevices();
            }
            if (e.State == CallState.Ringing)
            {
                AsynThread(() => {
                    //if (isCalling)
                    //    playSound(calling);
                    //else
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

        private void DispatchAsync(Action action)
        {
            var task = new WaitCallback(o => action.Invoke());
            ThreadPool.QueueUserWorkItem(task);
        }
    #region Subcribe or Unsubcribe Events
    private void SubcribeCallEvents()
        {
            try
            {
                frmSipAccount._call.CallStateChanged += (call_CallStateChanged);
            }
            catch (Exception ex)
            {
                AsynThread(() => { lb_Log.Items.Add("Error: " + ex); });
            }
        }

        private void UnSubcribeCallEvents()
        {
            try
            {
                frmSipAccount._call.CallStateChanged -= (call_CallStateChanged);
            }
            catch (Exception ex)
            { 
                AsynThread(() => { lb_Log.Items.Add("Error: " + ex); });
            }
        }
        #endregion
        public void Answer()
        {

            frmSipAccount._call.Answer();
            AsynThread(() => {
                lb_Log.Items.Add("Call accepted.");
            });
        }
        private void AsynThread(Action action)
        {
            Invoke(action);
        }
        public frmCalling()
        {
            InitializeComponent();
        }

        private void frmCalling_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.WhiteSmoke;
            btnAccpect.Enabled = true;
            SubcribeCallEvents();
            btnHangup.Enabled = true;
        }

        private void btnAccpect_Click(object sender, EventArgs e)
        {
            Answer();
        }
    }
}
