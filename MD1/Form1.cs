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

        public int rez; //global val

        public Form1()
        {
            InitializeComponent();
        }

        private void rezButton_Click(object sender, EventArgs e)
        {

            int vert1 = int.Parse(skaitlis1.Text);
            int vert2 = int.Parse(skaitlis2.Text);

            try
            {
                rez = vert1 % vert2;
            }
            catch (System.DivideByZeroException ex)
            {
                MessageBox.Show("Nedrīgst dalit ar 0", "Kļūdas paziņojums",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            finalValue.Text = rez.ToString();


        }

        //Pievieno keyPressEvent
        private void skaitlis1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // var izmantot ari (e.KeyChar != '-'), bet tad rezultati ir ikta nepareizi
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
