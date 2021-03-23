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
    public partial class formregistration : Form
    {
        public formregistration(string username, string password, string usertype, string action, string user)
        {
            InitializeComponent();
            this.username = username;
            this.action = action;
            this.usertype = usertype;
            this.user = user;
        }

        Class1 Account = new Class1("127.0.0.1", "db_boring", "test", "12345");
        string user, username, action, usertype;

        private void formregistration_Load(object sender, EventArgs e)
        {

        }

        int error;

        private void btn_login_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox4.Text == textBox2.Text)
                {
                    //validate();
                    if (action == "add")
                    {
                        if (error == 0)
                        {
                            Account.executeSQL("INSERT INTO tblaccounts VALUES ('" + textBox1.Text + "' ,'" + textBox4.Text + "' , '" + comboBox1.Text + "' )");
                            if (Account.rowAffected > 0)
                            {
                                MessageBox.Show("Account Registered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                // Account.executeSQL("INSERT INTO tbllogs VALUES ('" + DateTime.Now.ToString() + "' , 'Added new equipment with asset number-" + asset_format + "' , '" + username + "' , 'Equipments Management')");
                                this.Close();
                            }
                        }
                    }
                }
                else
                {

                    MessageBox.Show("Password Not Same", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



    }
}
 

