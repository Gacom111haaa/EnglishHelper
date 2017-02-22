using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EnglishSTT;
using System.Threading;
using System.IO;

namespace EnglishHelper
{
    public partial class MainPage : Form
    {
        private bool _isRecording;
        private SoundIO _soundIO;

        public MainPage()
        {
            InitializeComponent();

            FillDevices();
            FillFreqs();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonRec_Click(object sender, EventArgs e)
        {
            if (_isRecording)
            {
                //buttonRec.Content = "Rec";
                labelRec.Visible = false;
                _isRecording = false;
                buttonRec.Enabled = false;
                Stop();
            }
            else
            {
                //buttonRec.Content = "Stop";
                _isRecording = true;
                //micImage.Visibility = Visibility.Visible;
                labelRec.Visible = true;
                Start();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            txtResponses.Text = "";
        }


        void Start()
        {
            _soundIO = SoundIO.getSoundIO(cmbDevices.SelectedValue.ToString(), "wav", cmbFreq.SelectedValue.ToString());
            //new SoundIO(cmbDevices.SelectedItem.ToString(), "wav", cmbFreq.SelectedItem.ToString());
            _soundIO.OutputStream = new MemoryStream();
            _soundIO.StartRecording();
        }

        void Stop()
        {
            _soundIO.StopRecording();
            txtProcessing.Visible = true;
            Thread requestThread = new Thread(SendRequest);
            requestThread.Start();
        }

        void UpdateText(string txt)
        {
            txtResponses.BeginInvoke(new Action<string>(t => txtResponses.Text += txt + "\n"), txt);
            labelRec.BeginInvoke(new Action(() => labelRec.Visible = false));
            txtProcessing.BeginInvoke(new Action(() => txtProcessing.Visible = false));
            buttonRec.BeginInvoke(new Action(() => buttonRec.Enabled = true));
        }

        void SendRequest()
        {
            string str = "";
            try
            {
                str = SoundRecognition.WavStreamToGoogle(_soundIO.OutputStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                _soundIO.OutputStream.Close();
                UpdateText(str);
            }
        }

        void FillDevices()
        {
            IEnumerable<string> divides = SoundIO.AvailableDevicesDescriptions;
            foreach (var divide in divides)
            {
                cmbDevices.Items.Add(divide);
            }
            cmbDevices.SelectedIndex = 0;
        }

        void FillFreqs()
        {
            IEnumerable<string> formats = SoundIO.StandartSoundFormatsDescriptions;
            foreach (string format in formats)
            {
                cmbFreq.Items.Add(format);
            }
            cmbFreq.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
