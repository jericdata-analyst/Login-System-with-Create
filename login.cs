using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace covid2020
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
          
        }

        Class1 Login = new Class1("127.0.0.1", "db_boring", "test", "12345");
        
        private void btn_exit_Click(object sender, EventArgs e) 
        {
            Application.Restart();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Login.GetData("select * from tblaccounts where username = '" + txtbox_Username.Text +
                 "' and password = '" + txtbox_Password.Text +"'");
                if (dt.Rows.Count > 0)
                {
                   formmain main = new formmain(txtbox_Username.Text, dt.Rows[0].Field<string>("usertype"), txtbox_Password.Text);
                   formregistration reg = new formregistration("","","","add","");
                    main.Show();
                    reg.Close();
                    this.Hide();
                
                }
                else
                {
                    MessageBox.Show("Incorrect username or password or account is inactive", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void link_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formregistration reg = new formregistration("","","","add","");
            reg.Show();
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
