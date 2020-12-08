using System.Data;
using System.Windows.Forms;


namespace beadando
{

    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            
                       
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {


            DataTable dt = new DataTable();
            dt.TableName="Contact";
            DataColumn dc1 = new DataColumn("Felhasznalonev");
            DataColumn dc2 = new DataColumn("Kor");
            DataColumn dc3 = new DataColumn("Nem");
            DataColumn dc4 = new DataColumn("VásárlásIdőpontja");

            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);

            dt.Rows.Add("langszandra", "22", "2", "2020.11.10.");
            dt.Rows.Add("juhaszndora", "22", "2","2020.12.01.");
            dt.Rows.Add("muskatkristof", "24", "1", "2020.10.12.");

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

        private void button1_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
