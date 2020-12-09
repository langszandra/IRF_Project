using beadando.Entities;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Xml;

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


            DataTable dt = new DataTable();
            dt.TableName="Contact";
            DataColumn dc1 = new DataColumn("Felhasznalonev", typeof(string));
            DataColumn dc2 = new DataColumn("Osszeg",typeof(Int32));
            DataColumn dc3 = new DataColumn("Nem",typeof(Int32));
            DataColumn dc4 = new DataColumn("Datum", typeof(DateTime));

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);

            dt.Rows.Add("langszandra", "6540", "2", "2020-11-10");
            dt.Rows.Add("juhaszndora", "3600", "2","2020-12-01");
            dt.Rows.Add("muskatkristof", "2590", "1", "2020-10-12");

            DataSet ds = new DataSet();
            ds.DataSetName = "AdressBook";
            ds.Tables.Add(dt);
            ds.WriteXml("Contacts.xml");
            
        }

        private void btnLoad_Click(object sender, System.EventArgs e)
        {
            DataSet dsLoad = new DataSet();
            dsLoad.ReadXml("Contacts.xml");
            dgvLoadAddressBook.DataSource = dsLoad.Tables[0];
        }
        
        
        
    }
}
