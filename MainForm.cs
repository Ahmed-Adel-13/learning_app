using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs_learning_app
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Englishbtn_Click(object sender, EventArgs e)
        {
            var EnglishForm = new EnglishForm();
            EnglishForm.Show();

        }

        private void Arbicbtn_Click(object sender, EventArgs e)
        {
            var ArabicForm = new ArabicForm();
            ArabicForm.Show();
        }

        private void Franchbtn_Click(object sender, EventArgs e)
        {
            var FranchForm = new FranchForm();
            FranchForm.Show();
        }
    }
}
