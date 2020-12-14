using beadando.Entities;
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        enum gender { Nő=2, Férfi=1}
      
        public Form2()
        {
            InitializeComponent();
              
            

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            //Éves bevétel//
            var xml = XDocument.Load("Contacts.xml");
            var sum = (from nd in xml.Descendants("Osszeg")
                       select Int32.Parse(nd.Value)).Sum();
            textBox1.AppendText(sum.ToString()+" Ft");

            //Vásárlók összesen//
           
            int count = xml.Descendants("Nem").Count();
            textBox2.AppendText(count.ToString() + " db");

            
            

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var xml = XDocument.Load("Contacts.xml");
            var sum = (from nd in xml.Descendants("Osszeg")
                       select Int32.Parse(nd.Value)).Sum();
            int count = xml.Descendants("Nem").Count();
            var nok = (from nd in xml.Descendants("Nem")
                       where nd.Value == "1"
                       select nd.Value).Count();
            var ferfi = (from nd in xml.Descendants("Nem")
                         where nd.Value == "2"
                         select nd.Value).Count();

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Comma Seperated Values (*.csv)|*.csv";
            sfd.DefaultExt = "csv";
            sfd.AddExtension = true;
            if(sfd.ShowDialog() != DialogResult.OK) return;
            using (StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
            {
                sw.Write("bevétel:");
                sw.Write(";");
                sw.Write(sum);
                sw.WriteLine();
                sw.Write("vásárlók:");
                sw.Write(";");
                sw.Write(count);
                sw.WriteLine();
                sw.Write("nők:");
                sw.Write(";");
                sw.Write(nok);
                sw.WriteLine();
                sw.Write("férfiak:");
                sw.Write(";");
                sw.Write(ferfi);
                sw.WriteLine();

            }

        }
        //Nemek szerinti megoszlás//
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            var xml = XDocument.Load("Contacts.xml");
            
            var nok = (from nd in xml.Descendants("Nem")
                       where nd.Value == "1"
                       select nd.Value).Count();
            string str= Enum.GetName(typeof(gender),2);
            textBox3.AppendText(str+":"+nok.ToString() + " db");

             
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            var xml = XDocument.Load("Contacts.xml");
            var ferfi = (from nd in xml.Descendants("Nem")
                         where nd.Value == "2"
                         select nd.Value).Count();
            string str = Enum.GetName(typeof(gender), 1);
            textBox4.AppendText(str+":"+ferfi.ToString() + " db");;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
