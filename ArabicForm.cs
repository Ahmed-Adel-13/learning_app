
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

namespace cs_learning_app
{
  
    public partial class ArabicForm : Form
    {
        public ArabicForm()
        {
            InitializeComponent();
            Btn001.Hide();
        }
        public void timerdef()
        {
            Task.Run(() =>
            {
                Thread.Sleep(2000);
                this.Invoke(new Action(() =>
                {
                    Btn001.Hide();
                    label1.Show();
                }));
            });
        }

        private void ArabicForm_Load(object sender, EventArgs e)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               

        }
   

        private void Btn005_Click(object sender, EventArgs e)
        {
            SoundPlayer jeem = new SoundPlayer(cs_learning_app.Properties.Resources._005_jeem);
            jeem.Play();
        }


        private void Btn008_Click(object sender, EventArgs e)
        {
            SoundPlayer dal = new SoundPlayer(cs_learning_app.Properties.Resources._008_dal);
            dal.Play();
        }

        private void Btn009_Click(object sender, EventArgs e)
        {
            SoundPlayer dhal = new SoundPlayer(cs_learning_app.Properties.Resources._009_dhal);
            dhal.Play();
        }

        private void Btn011_Click(object sender, EventArgs e)
        {
            SoundPlayer jaa = new SoundPlayer(cs_learning_app.Properties.Resources._011_jaa);
            jaa.Play();
        }
        private void Btn016_Click(object sender, EventArgs e)
        {
            SoundPlayer toa = new SoundPlayer(cs_learning_app.Properties.Resources._016_toa);
            toa.Play();
        }
        private void button17_Click(object sender, EventArgs e)
        {
            SoundPlayer dhaa = new SoundPlayer(cs_learning_app.Properties.Resources._017_dhaa);
            dhaa.Play();
        }


        private void Btn026_Click(object sender, EventArgs e)
        {
            SoundPlayer waw = new SoundPlayer(cs_learning_app.Properties.Resources._026_waw);
            waw.Play();
        }

        private void ArabicForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ض";
                SoundPlayer dhaad = new SoundPlayer(cs_learning_app.Properties.Resources._015_dhaad);
                dhaad.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.D)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ي";
                SoundPlayer yaa = new SoundPlayer(cs_learning_app.Properties.Resources._029_yaa);
                yaa.Play(); timerdef();
            }

            if (e.KeyCode == Keys.E)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ث";
                SoundPlayer thaa = new SoundPlayer(cs_learning_app.Properties.Resources._004_tha);
                thaa.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.F)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ب";
                SoundPlayer baa = new SoundPlayer(cs_learning_app.Properties.Resources._002_ba);
                baa.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.G)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ل";
                SoundPlayer laam = new SoundPlayer(cs_learning_app.Properties.Resources._023_laam);
                laam.Play(); timerdef();
            }

            if (e.KeyCode == Keys.H)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "أ";
                SoundPlayer alif = new SoundPlayer(cs_learning_app.Properties.Resources._001_alif);
                alif.Play(); timerdef();
            }

            if (e.KeyCode == Keys.I)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ه";
                SoundPlayer ha = new SoundPlayer(cs_learning_app.Properties.Resources._027_ha);
                ha.Play(); timerdef();
            }

            if (e.KeyCode == Keys.J)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ت";
                SoundPlayer taa = new SoundPlayer(cs_learning_app.Properties.Resources._003_taa);
                taa.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.K)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ن";
                SoundPlayer noon = new SoundPlayer(cs_learning_app.Properties.Resources._025_noon);
                noon.Play(); timerdef();
            }

            if (e.KeyCode == Keys.L)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "م";
                SoundPlayer meem = new SoundPlayer(cs_learning_app.Properties.Resources._024_meem);
                meem.Play(); timerdef();
            }

            if (e.KeyCode == Keys.M)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ك";
                SoundPlayer kaaf = new SoundPlayer(cs_learning_app.Properties.Resources._022_kaaf);
                kaaf.Play(); timerdef();
            }

            if (e.KeyCode == Keys.O)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "خ";
                SoundPlayer khaa = new SoundPlayer(cs_learning_app.Properties.Resources._007_khaa);
                khaa.Play(); timerdef();
            }

            if (e.KeyCode == Keys.P)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ح";
                SoundPlayer haa = new SoundPlayer(cs_learning_app.Properties.Resources._006_haa);
                haa.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.Q)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ش";
                SoundPlayer sheen = new SoundPlayer(cs_learning_app.Properties.Resources._013_sheen);
                sheen.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.R)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ق";
                SoundPlayer qaaf = new SoundPlayer(cs_learning_app.Properties.Resources._021_qaaf);
                qaaf.Play(); timerdef();
            }

            if (e.KeyCode == Keys.S)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "س";
                SoundPlayer seen = new SoundPlayer(cs_learning_app.Properties.Resources._012_seen);
                seen.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.T)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ف";
                SoundPlayer faa = new SoundPlayer(cs_learning_app.Properties.Resources._020_faa);
                faa.Play(); timerdef();
            }

            if (e.KeyCode == Keys.U)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ع";
                SoundPlayer ain = new SoundPlayer(cs_learning_app.Properties.Resources._018_ain);
                ain.Play(); timerdef();
            }

            if (e.KeyCode == Keys.V)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ر";
                SoundPlayer raa = new SoundPlayer(cs_learning_app.Properties.Resources._010_raa);
                raa.Play();
                timerdef();
            }

            if (e.KeyCode == Keys.X)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ء";
                SoundPlayer hamza = new SoundPlayer(cs_learning_app.Properties.Resources._028_hamza);
                hamza.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Y)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "غ";
                SoundPlayer ghain = new SoundPlayer(cs_learning_app.Properties.Resources._019_ghain);
                ghain.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Z)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "ص";
                SoundPlayer saad = new SoundPlayer(cs_learning_app.Properties.Resources._014_saad);
                saad.Play(); timerdef();
            }
            //if (e.KeyCode == Keys)
        }    
    }
}
