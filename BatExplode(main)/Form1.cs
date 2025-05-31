using BatExplode___Falcari___Manuzzato.Properties;

namespace BatExplode___Falcari___Manuzzato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_PlayIniziale_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            playForm.Show();
            this.Hide();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}