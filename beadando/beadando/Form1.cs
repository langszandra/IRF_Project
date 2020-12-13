using beadando.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace beadando
{

    public partial class Form1 : Form
    {
        BindingList<Data> Rates = new BindingList<Data>();



        public Form1()
        {
            InitializeComponent();



        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            //xml létrehozása//

            DataTable dt = new DataTable();
            dt.TableName = "Contact";
            DataColumn dc1 = new DataColumn("Felhasznalonev", typeof(string));
            DataColumn dc2 = new DataColumn("Osszeg", typeof(Int32));
            DataColumn dc3 = new DataColumn("Nem", typeof(string));
            DataColumn dc4 = new DataColumn("Datum", typeof(DateTime));

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);

            dt.Rows.Add("langszandra", "6540", "2", "2020-01-10");
            dt.Rows.Add("dudaseszter", "6540", "2", "2020-01-10");
            dt.Rows.Add("juhaszndora", "3600", "2", "2020-01-01");
            dt.Rows.Add("muskatkristof", "3200", "1", "2020-02-12");
            dt.Rows.Add("kissalexandra", "4400", "2", "2020-02-10");
            dt.Rows.Add("nagyangelika", "5680", "2", "2020-02-10");
            dt.Rows.Add("juhaszndora", "3260", "2", "2020-03-01");
            dt.Rows.Add("kisspeter", "4523", "1", "2020-03-12");
            dt.Rows.Add("herczegoliver", "3200", "1", "2020-03-03");
            dt.Rows.Add("nagyreka", "4400", "2", "2020-03-09");
            dt.Rows.Add("ferenc112", "5680", "1", "2020-04-12");
            dt.Rows.Add("hgabor23", "3260", "1", "2020-04-01");
            dt.Rows.Add("hidegzsofi", "4523", "2", "2020-04-04");
            dt.Rows.Add("langszandra", "6540", "2", "2020-04-10");
            dt.Rows.Add("ddenes", "6540", "1", "2020-05-10");
            dt.Rows.Add("dudaseszter", "3600", "2", "2020-05-01");
            dt.Rows.Add("kornel23", "3200", "1", "2020-05-12");
            dt.Rows.Add("pmate", "4400", "1", "2020-06-10");
            dt.Rows.Add("vacakos", "5680", "1", "2020-06-10");
            dt.Rows.Add("vachajaaron", "3260", "1", "2020-06-01");
            dt.Rows.Add("nagyferenc", "4523", "1", "2020-06-12");
            dt.Rows.Add("hgabor23", "3200", "1", "2020-07-03");
            dt.Rows.Add("pmate", "4400", "1", "2020-07-09");
            dt.Rows.Add("muskatfanni", "5680", "2", "2020-07-12");
            dt.Rows.Add("kisspeter", "3260", "2", "2020-07-01");
            dt.Rows.Add("papplilla", "4523", "1", "2020-07-04");

            DataSet ds = new DataSet();
            ds.DataSetName = "AdressBook";
            ds.Tables.Add(dt);
            ds.WriteXml("Contacts.xml");

            /*Adatok betöltése*/
            DataSet dsLoad = new DataSet();
            dsLoad.ReadXml("Contacts.xml");
            dgvLoadAddressBook.DataSource = dsLoad.Tables[0];





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();

        }

    }

}