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
using System.Media;
using System.Threading;
namespace cs_learning_app
{
    public partial class EnglishForm : Form
    {
        public EnglishForm()
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
        private void EnglishForm_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyValue == 36) {
                label1.Hide();
                Btn001.Show();
                Btn001.Text="A";
                SoundPlayer A = new SoundPlayer(cs_learning_app.Properties.Resources.A);
                A.Play();
                timerdef();
            }
            if (e.KeyCode == Keys.B)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "B";
                SoundPlayer B = new SoundPlayer(cs_learning_app.Properties.Resources.B);
                B.Play(); timerdef();
            }

            if (e.KeyCode == Keys.C)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "C";
                SoundPlayer C = new SoundPlayer(cs_learning_app.Properties.Resources.C);
                C.Play(); timerdef();
            }

            if (e.KeyCode == Keys.D)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "D";
                SoundPlayer D = new SoundPlayer(cs_learning_app.Properties.Resources.D);
                D.Play(); timerdef();
            }

            if (e.KeyCode == Keys.E)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "E";
                SoundPlayer E = new SoundPlayer(cs_learning_app.Properties.Resources.E);
                E.Play(); timerdef();
            }

            if (e.KeyCode == Keys.F)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "F";
                SoundPlayer F = new SoundPlayer(cs_learning_app.Properties.Resources.F);
                F.Play(); timerdef();
            }

            if (e.KeyCode == Keys.G)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "G";
                SoundPlayer G = new SoundPlayer(cs_learning_app.Properties.Resources.G);
                G.Play(); timerdef();
            }

            if (e.KeyCode == Keys.H)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "H";
                SoundPlayer H = new SoundPlayer(cs_learning_app.Properties.Resources.H);
                H.Play(); timerdef();
            }

            if (e.KeyCode == Keys.I)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "I";
                SoundPlayer I = new SoundPlayer(cs_learning_app.Properties.Resources.I);
                I.Play(); timerdef();
            }

            if (e.KeyCode == Keys.J)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "J";
                SoundPlayer J = new SoundPlayer(cs_learning_app.Properties.Resources.J);
                J.Play(); timerdef();
            }

            if (e.KeyCode == Keys.K)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "K";
                SoundPlayer K = new SoundPlayer(cs_learning_app.Properties.Resources.K);
                K.Play(); timerdef();
            }

            if (e.KeyCode == Keys.L)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "L";
                SoundPlayer L = new SoundPlayer(cs_learning_app.Properties.Resources.L);
                L.Play(); timerdef();
            }

            if (e.KeyCode == Keys.M)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "M";
                SoundPlayer M = new SoundPlayer(cs_learning_app.Properties.Resources.M);
                M.Play(); timerdef();
            }

            if (e.KeyCode == Keys.N)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "N";
                SoundPlayer N = new SoundPlayer(cs_learning_app.Properties.Resources.N);
                N.Play(); timerdef();
            }

            if (e.KeyCode == Keys.O)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "O";
                SoundPlayer O = new SoundPlayer(cs_learning_app.Properties.Resources.O);
                O.Play(); timerdef();
            }

            if (e.KeyCode == Keys.P)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "P";
                SoundPlayer P = new SoundPlayer(cs_learning_app.Properties.Resources.P);
                P.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Q)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "Q";
                SoundPlayer Q = new SoundPlayer(cs_learning_app.Properties.Resources.Q);
                Q.Play(); timerdef();
            }

            if (e.KeyCode == Keys.R)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "R";
                SoundPlayer R = new SoundPlayer(cs_learning_app.Properties.Resources.R);
                R.Play(); timerdef();
            }

            if (e.KeyCode == Keys.S)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "S";
                SoundPlayer S = new SoundPlayer(cs_learning_app.Properties.Resources.S);
                S.Play(); timerdef();
            }

            if (e.KeyCode == Keys.T)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "T";
                SoundPlayer T = new SoundPlayer(cs_learning_app.Properties.Resources.T);
                T.Play(); timerdef();
            }

            if (e.KeyCode == Keys.U)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "U";
                SoundPlayer U = new SoundPlayer(cs_learning_app.Properties.Resources.U);
                U.Play(); timerdef();
            }

            if (e.KeyCode == Keys.V)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "V";
                SoundPlayer V = new SoundPlayer(cs_learning_app.Properties.Resources.V);
                V.Play(); timerdef();
            }

            if (e.KeyCode == Keys.W)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "W";
                SoundPlayer W = new SoundPlayer(cs_learning_app.Properties.Resources.W);
                W.Play(); timerdef();
            }

            if (e.KeyCode == Keys.X)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "X";
                SoundPlayer X = new SoundPlayer(cs_learning_app.Properties.Resources.X);
                X.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Y)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "Y";
                SoundPlayer Y = new SoundPlayer(cs_learning_app.Properties.Resources.Y);
                Y.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Z)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "Z";
                SoundPlayer Z = new SoundPlayer(cs_learning_app.Properties.Resources.Z);
                Z.Play(); timerdef();
            }
        }
    }
}
