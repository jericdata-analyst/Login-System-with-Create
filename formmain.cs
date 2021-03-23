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
    public partial class formmain : Form
    {

        string user, usertype, password;
        public formmain(string user, string usertype, string password)
        {
            InitializeComponent();
            this.user = user;
            this.usertype = usertype;
            this.password = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        Class1 Login = new Class1("127.0.0.1", "db_boring", "test", "12345");

        private void formmain_Load(object sender, EventArgs e)
        {

        }
    }
}
