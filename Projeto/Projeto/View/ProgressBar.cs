using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        public int carregamento=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(carregamento < 100)
            {
                carregamento += 5;
                progressBar1.Value = carregamento;
                lbl_porc.Text = carregamento.ToString() + "%";
            }
            else
            {
                tmr_bar.Enabled = false;
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
