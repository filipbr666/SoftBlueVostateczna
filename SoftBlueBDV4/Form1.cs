using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SoftBlueBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void KondensatoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kondensatory f = new Kondensatory();
            f.Show();
        }

        private void IndukcyjneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Indukcyjne f = new Indukcyjne();
            f.Show();
        }

        private void RezystoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rezystory f = new Rezystory();
            f.Show();
        }

        private void TranzystoryButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tranzystory f = new Tranzystory();
            f.Show();
        }

        private void UkladyButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Uklady f = new Uklady();
            f.Show();
        }

        private void ZlaczaButton_Click(object sender, EventArgs e)
        {
            this.Hide();     
            Zlacza f = new Zlacza();
            f.Show();
            
        }

        private void MechaniczneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mechaniczne f = new Mechaniczne();
            f.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SoftBlueBD.Program.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormTEST f = new FormTEST();
            f.Show();
        }
    }
}
