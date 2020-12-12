using beadando.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace beadando
{
    public partial class Form2 : Form
    {
        
        /*BindingList<Data> Datas = new BindingList<Data>();*/

        public Form2()
        {
            InitializeComponent();
              
            

        }
        private void AdatokLekerese()
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Éves bevétel//
            var doc = XDocument.Load("Contacts.xml");
            var sum = (from nd in doc.Descendants("Osszeg")
                       select Int32.Parse(nd.Value)).Sum();
            textBox1.AppendText(sum.ToString()+" Ft");

            //Vásárlók összesen//
            var xml = XDocument.Load("Contacts.xml");
            int count = xml.Descendants("Nem").Count();
            textBox2.AppendText(count.ToString() + " db");

            //Nemek szerinti megoszlás//
            var nok = (from nd in doc.Descendants("Nem")
                       where nd.Value=="1"
                       select nd.Value).Count();
            textBox3.AppendText(nok.ToString()+" db");

            var ferfi = (from nd in doc.Descendants("Nem")
                       where nd.Value == "2"
                       select nd.Value).Count();
            textBox4.AppendText(ferfi.ToString()+" db");


        }

        
    }
}
