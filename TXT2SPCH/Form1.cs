using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
namespace TXT2SPCH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SpeechSynthesizer speech;

        private void Form1_Load(object sender, EventArgs e)
        {
            speech = new SpeechSynthesizer();
            speech.Volume = 100;
            speech.Rate = -2;
            btnresume.Enabled = false;
            btnpause.Enabled = false;
            btnstop.Enabled = false;
        }

        private void btnspeak_Click(object sender, EventArgs e)
        {
            speech.Dispose();
            if (richTextBox1.Text != "")
            {
                speech = new SpeechSynthesizer();  
                speech.SpeakAsync(richTextBox1.Text);
                btnpause.Enabled = true;
                btnstop.Enabled = true;
            }
        }

        private void btnresume_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                if (speech.State == SynthesizerState.Paused)
                {   
                    speech.Resume();
                    btnresume.Enabled = false;
                    btnspeak.Enabled = true;
                }
            }
        }

        private void btnpause_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                if (speech.State == SynthesizerState.Speaking)
                {
                    speech.Pause();
                    btnresume.Enabled = true;
                    btnspeak.Enabled = false;
                }
            }
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            if (speech != null)
            {
                speech.Dispose();
                btnspeak.Enabled = true;
                btnresume.Enabled = false;
                btnpause.Enabled = false;
                btnstop.Enabled = false;
            }
        }
    }
}