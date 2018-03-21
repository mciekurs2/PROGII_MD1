using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
                LogThis($"Veikt aprēķins: {vert1} mod {vert2} = {rez}");
            }
            catch (System.DivideByZeroException ex)
            {

                LogThis($"Radies kļūdas paziņojums dalot ar 0: {vert1} mod {vert2} ");
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

                LogThis($"Centies ievadit vertibu kas nav skaitlis lauka `skaitlis1`: {e.KeyChar}");
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

                LogThis($"Centies ievadit vertibu kas nav skaitlis lauka `skaitlis2`: {e.KeyChar}");
                //izveido MessageBox
                MessageBox.Show("Lūdzu ievadiet skaitli!", "Kļūdas paziņojums",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                e.Handled = true;
            }


        }


        static void LogThis(string logMessage)
        {
            Console.WriteLine(logMessage);
            using (StreamWriter writer = new StreamWriter(FileDate() + ".txt", true))
            {
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt") + ": " + logMessage);
            }
        }

        static string FileDate()
        {
            return DateTime.Now.ToString("yyyy") + "-" + DateTime.Now.ToString("MM") + "-" + DateTime.Now.ToString("dd");
        }



    }
}
