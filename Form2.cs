using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proftaakp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            tijdlabel.Text = DateTime.Now.ToShortTimeString();
            timer1.Start();

            //Hoi Hicham
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tijdlabel.Text = DateTime.Now.ToShortTimeString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form overzicht = new overzichtsensoren();
            overzicht.Show(); 
        }
    }
}
