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
    public partial class FranchForm : Form
    {
        public FranchForm()
        {
            InitializeComponent();
            Btn001.Hide();
        }
        public void timerdef() {
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
        public void showimage(string A) {

        }
        private void TryForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "A";
                SoundPlayer A = new SoundPlayer(cs_learning_app.Properties.Resources.A1);
                A.Play();
                timerdef();
            }
            if (e.KeyCode == Keys.B)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "B";
                SoundPlayer B = new SoundPlayer(cs_learning_app.Properties.Resources.B1);
                B.Play(); timerdef();
            }

            if (e.KeyCode == Keys.C)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "C";
                SoundPlayer C = new SoundPlayer(cs_learning_app.Properties.Resources.C1);
                C.Play(); timerdef();
            }

            if (e.KeyCode == Keys.D)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "D";
                SoundPlayer D = new SoundPlayer(cs_learning_app.Properties.Resources.D1);
                D.Play(); timerdef();
            }

            if (e.KeyCode == Keys.E)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "E";
                SoundPlayer E = new SoundPlayer(cs_learning_app.Properties.Resources.E1);
                E.Play(); timerdef();
            }

            if (e.KeyCode == Keys.F)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "F";
                SoundPlayer F = new SoundPlayer(cs_learning_app.Properties.Resources.F1);
                F.Play(); timerdef();
            }

            if (e.KeyCode == Keys.G)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "G";
                SoundPlayer G = new SoundPlayer(cs_learning_app.Properties.Resources.G1);
                G.Play(); timerdef();
            }

            if (e.KeyCode == Keys.H)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "H";
                SoundPlayer H = new SoundPlayer(cs_learning_app.Properties.Resources.H1);
                H.Play(); timerdef();
            }

            if (e.KeyCode == Keys.I)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "I";
                SoundPlayer I = new SoundPlayer(cs_learning_app.Properties.Resources.I1);
                I.Play(); timerdef();
            }

            if (e.KeyCode == Keys.J)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "J";
                SoundPlayer J = new SoundPlayer(cs_learning_app.Properties.Resources.J1);
                J.Play(); timerdef();
            }

            if (e.KeyCode == Keys.K)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "K";
                SoundPlayer K = new SoundPlayer(cs_learning_app.Properties.Resources.K1);
                K.Play(); timerdef();
            }

            if (e.KeyCode == Keys.L)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "L";
                SoundPlayer L = new SoundPlayer(cs_learning_app.Properties.Resources.L1);
                L.Play(); timerdef();
            }

            if (e.KeyCode == Keys.M)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "M";
                SoundPlayer M = new SoundPlayer(cs_learning_app.Properties.Resources.M1);
                M.Play(); timerdef();
            }

            if (e.KeyCode == Keys.N)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "N";
                SoundPlayer N = new SoundPlayer(cs_learning_app.Properties.Resources.N1);
                N.Play(); timerdef();
            }

            if (e.KeyCode == Keys.O)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "O";
                SoundPlayer O = new SoundPlayer(cs_learning_app.Properties.Resources.O1);
                O.Play(); timerdef();
            }

            if (e.KeyCode == Keys.P)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "P";
                SoundPlayer P = new SoundPlayer(cs_learning_app.Properties.Resources.P1);
                P.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Q)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "Q";
                SoundPlayer Q = new SoundPlayer(cs_learning_app.Properties.Resources.Q1);
                Q.Play(); timerdef();
            }

            if (e.KeyCode == Keys.R)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "R";
                SoundPlayer R = new SoundPlayer(cs_learning_app.Properties.Resources.R1);
                R.Play(); timerdef();
            }

            if (e.KeyCode == Keys.S)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "S";
                SoundPlayer S = new SoundPlayer(cs_learning_app.Properties.Resources.S1);
                S.Play(); timerdef();
            }

            if (e.KeyCode == Keys.T)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "T";
                SoundPlayer T = new SoundPlayer(cs_learning_app.Properties.Resources.T1);
                T.Play(); timerdef();
            }

            if (e.KeyCode == Keys.U)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "U";
                SoundPlayer U = new SoundPlayer(cs_learning_app.Properties.Resources.U1);
                U.Play(); timerdef();
            }

            if (e.KeyCode == Keys.V)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "V";
                SoundPlayer V = new SoundPlayer(cs_learning_app.Properties.Resources.V1);
                V.Play(); timerdef();
            }

            if (e.KeyCode == Keys.W)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "W";
                SoundPlayer W = new SoundPlayer(cs_learning_app.Properties.Resources.W1);
                W.Play(); timerdef();
            }

            if (e.KeyCode == Keys.X)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "X";
                SoundPlayer X = new SoundPlayer(cs_learning_app.Properties.Resources.X1);
                X.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Y)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "Y";
                SoundPlayer Y = new SoundPlayer(cs_learning_app.Properties.Resources.Y1);
                Y.Play(); timerdef();
            }

            if (e.KeyCode == Keys.Z)
            {
                label1.Hide();
                Btn001.Show();
                Btn001.Text = "Z";
                SoundPlayer Z = new SoundPlayer(cs_learning_app.Properties.Resources.Z1);
                Z.Play(); timerdef();
            }
        }


    }
}
