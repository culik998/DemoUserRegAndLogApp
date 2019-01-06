using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            foreach (var item in User.users)
            {
                if (item.Name == textBox1_name.Text && item.Password == textBox2_password.Text)
                {
                    MessageBox.Show("WELCOME!");
                }
                else
                    MessageBox.Show("Bas bayra");

            }
            
        }
    }
}
