using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beadando
{
    public partial class Bejelentkezes : Form
    {
        string[] felhasznalo = { "Láng Alexandra", "Kecskés Klaudia" };
        string[] jel = { "jelszo12", "98765" };

        public Bejelentkezes()
        {
            InitializeComponent();
            jelszo.PasswordChar = '*';
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (felhasznalo.Contains(nev.Text) && jel.Contains(jelszo.Text) && Array.IndexOf(felhasznalo, nev.Text) == Array.IndexOf(jel, jelszo.Text))
            {

                Form1 f1 = new Form1();
                f1.Show();
            }


            else
            {
                MessageBox.Show("Rossz felhasználónév vagy jelszó, próbáld újra!");
            }
        }
    }
}
