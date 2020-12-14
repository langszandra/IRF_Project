using beadando.Controller;
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
    public partial class Regisztracio : Form
    {
        private AccountController _controller = new AccountController();

       
        
        public Regisztracio()
        {
            InitializeComponent();
           
            
        }
       

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                _controller.Register(
                    txtEmail.Text,
                    txtPassword.Text);
                Form1 f1 = new Form1();
                f1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}