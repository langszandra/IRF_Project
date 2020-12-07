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


namespace beadando
{
    
    public partial class Form1 : Form
    {
        BindingList<Stat> Stats = new BindingList<Stat>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = Stats;
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var doc = new XmlDocument();
            doc.LoadXml("adatok.xml");
            foreach (XmlElement element in doc.DocumentElement)
            {

                var stat = new Stat();
                Stats.Add(stat);

                stat.Email = element.GetAttribute("Email");
                stat.Nev = element.GetAttribute("Nev");
                stat.Nem = int.Parse(element.GetAttribute("Nem"));
                stat.Osszeg = int.Parse(element.GetAttribute("Osszeg"));
                stat.Mennyiseg = int.Parse(element.GetAttribute("Mennyiseg"));
           

            }
        }
    }
}
