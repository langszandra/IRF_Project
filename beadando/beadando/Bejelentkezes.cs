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
        string[] felhasznalo = { "langszandra@gmail.com", "hedi@gmail.com"};
        string[] jel = { "Jelszo12", "Jelszo56"};

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
                MessageBox.Show("Rossz e-mail cím vagy jelszó, próbáld újra!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regisztracio reg = new Regisztracio();
            reg.Show();
        }
    }
}
