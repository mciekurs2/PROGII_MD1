using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rezButton_Click(object sender, EventArgs e)
        {

            int vert1 = int.Parse(skaitlis1.Text);
            int vert2 = int.Parse(skaitlis2.Text);

            int rez = vert1 * vert2;

            finalValue.Text = rez.ToString();


        }

        //Pievieno keyPressEvent
        private void skaitlis1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //izveido MessageBox
                MessageBox.Show("Lūdzu ievadiet skaitli!", "Kļūdas paziņojums",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }



        }

        private void skaitlis2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                //izveido MessageBox
                MessageBox.Show("Lūdzu ievadiet skaitli!", "Kļūdas paziņojums",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }


        }



    }
}
