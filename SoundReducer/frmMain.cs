using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using NAudio.CoreAudioApi;

namespace SoundReducer
{
    public partial class frmMain : Form
    {
        Audio current = new Audio(0);
        struct Audio
        {
            public float Volume;

            public Audio(float Volume) : this()
            {
                this.Volume = Volume;
            }

            public override string ToString()
            {
                return (Volume * 100).ToString();
            }
        }

        float Step = 1;
        byte min = 10;

        bool Running = false;
        MMDevice defaultDevice = null;

        public static System.Windows.Threading.Dispatcher dispatcher;

        public frmMain()
        {
            InitializeComponent();
            dispatcher = System.Windows.Threading.Dispatcher.CurrentDispatcher;
            try
            {
                InitAudio();
            }
            catch (Exception)
            {
                MessageBox.Show("No audio output detected", "ERROR !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Initialisation
        private void InitAudio()
        {
            Running = false;
            timer1.Enabled = Running;
            MMDeviceEnumerator devEnum = new MMDeviceEnumerator();
            defaultDevice = devEnum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Multimedia);
            defaultDevice.AudioEndpointVolume.OnVolumeNotification += AudioEndpointVolume_OnVolumeNotification;
            Update(Running);
        }

        private void Update(bool Enabled)
        {
            current.Volume = (defaultDevice.AudioEndpointVolume.Mute) ? 0 : (float)Math.Round(defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar, 3);
            label1.Text = (!Enabled ? "Disabled - " : "") + $"{current.ToString()} %";
            checkBox1.Checked = Enabled;
        }

        // Changement du volume
        private void AudioEndpointVolume_OnVolumeNotification(AudioVolumeNotificationData data)
        {
            if (!data.Muted)
            {
                if ((float)Math.Round(data.MasterVolume, 3) > (float)Math.Round(current.Volume, 3))
                {
                    Running = false;
                }
                current.Volume = data.MasterVolume;
            }
            else
                current.Volume = 0;

            if (Running)
            {
                dispatcher.Invoke(() => { label1.Text = $"{current.ToString()} %"; });
            }
            else
            {
                dispatcher.Invoke((() =>
                {
                    this.Update(Running);
                }));
            }
        }

        // Clic sur le bouton
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.PerformClick();

            Running = checkBox1.Checked;
            panel1.BackColor = Running ? Color.LightGreen : Color.Crimson;
            timer1.Enabled = Running;
            Update(Running);
        }

        // A chaque intervalle
        private void timer1_Tick(object sender, EventArgs e)
        {
            DecreaseVolume();
        }

        private void DecreaseVolume()
        {
            if (Running)
            {
                if (((Math.Round((current.Volume * 100), 3)) >= (min + Step)))
                {
                    current.Volume -= (Step / 100);
                    current.Volume = (float)Math.Round(current.Volume, 3);
                    defaultDevice.AudioEndpointVolume.MasterVolumeLevelScalar = current.Volume;


                    Update(Running);
                    if (!((Math.Round((current.Volume * 100), 3)) >= (min + Step)))
                    {
                        Running = false;
                        Update(Running);
                    }
                }
                else
                {
                    Running = false;
                    Update(Running);
                }
            }
        }

        // Changement d'intervalle
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CheckText1();
                UpdateColorT1();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CheckText2();
                UpdateColorT2();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
                CheckText3();
                UpdateColorT3();
            }
        }

        private void CheckText1()
        {
            if (Regex.IsMatch(textBox1.Text, "^(([0-9]{2,})|([1-9]{1}))$"))
            {
                if (ushort.TryParse(textBox1.Text, out ushort Value))
                {
                    timer1.Interval = (Value * 1000);
                    textBox1.Text = (timer1.Interval / 1000).ToString();
                }
                else
                {
                    timer1.Interval = ushort.MaxValue;
                    MessageBox.Show("Error !\nThe value must be between 1 and 65535 seconds", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error !\nThe value must be between 1 and 65535 seconds", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckText2()
        {
            if (Regex.IsMatch(textBox2.Text, "^(([0]*[0-9]{1,2}?)([.]{1}[0-9]{1,3})?)$"))
            {
                if (float.TryParse(textBox2.Text, out float Value))
                {
                    if (Value == 0)
                        MessageBox.Show("Error !\nThe value must be between 0.001 and 99.999 %", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        Step = Value;
                        textBox2.Text = Step.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Error !\nThe value must be between 0.001 and 99.999 %", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error !\nThe value must be between 0.001 and 99.999 %", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckText3()
        {
            if (Regex.IsMatch(textBox3.Text, "^([1-9]{1})|([0-9]{2})$"))
            {
                if (byte.TryParse(textBox3.Text, out byte Value))
                {
                    if (Value < 100)
                    {
                        min = (byte)((Value < 100) ? Value : 99);
                        textBox3.Text = min.ToString();
                    }
                    else
                    {
                        Step = 1;
                        MessageBox.Show("Error !\nThe value must be between 0 and 99 %", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error !\nThe value must be between 0 and 99 %", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error !\nThe value must be between 0 and 99 %", "ERROR !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckText1();
            CheckText2();
            CheckText3();
            UpdateColorT1();
            UpdateColorT2();
            UpdateColorT3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Interval\t: {timer1.Interval / 1000}\t[seconds]\nStep\t: {Step}\t[%]\nMinimum\t: {min}\t[%]", "Settings", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateColorT1();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateColorT2();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateColorT3();
        }

        private void UpdateColorT1()
        {
            if (textBox1.Text == (timer1.Interval / 1000).ToString())
                textBox1.BackColor = Color.LightGreen;
            else
                textBox1.BackColor = SystemColors.ControlLightLight;
        }

        private void UpdateColorT2()
        {
            if (textBox2.Text == Step.ToString())
                textBox2.BackColor = Color.LightGreen;
            else
                textBox2.BackColor = SystemColors.ControlLightLight;
        }

        private void UpdateColorT3()
        {
            if (textBox3.Text == min.ToString())
                textBox3.BackColor = Color.LightGreen;
            else
                textBox3.BackColor = SystemColors.ControlLightLight;
        }
    }
}
