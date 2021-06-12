using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_Laundry
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data_Pemesanan pemesanan = new Data_Pemesanan();
            pemesanan.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login keluar = new Login();
            keluar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
