using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatExplode___Falcari___Manuzzato
{
    public partial class WinLoseForm : Form
    {
        public WinLoseForm()
        {
            InitializeComponent();
        }

        private void WinLoseForm_Load(object sender, EventArgs e)
        {

        }

        public WinLoseForm(bool winResult)
        {
            InitializeComponent();
            if (winResult)
            {
                lbl_Result.Text = "HAI VINTO!";
            }
            else
            {
                lbl_Result.Text = "HAI PERSO!";
            }
        }

        private void btn_Retry_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
            this.Hide();
        }

        private void lbl_Result_Click(object sender, EventArgs e)
        {

        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            Form1 settingsForm = new Form1();
            settingsForm.Show();
            this.Hide();
        }
    }
}
