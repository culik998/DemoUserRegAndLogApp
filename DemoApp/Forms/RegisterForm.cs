using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp.Forms
{
    
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        




        private void txbx_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                Name = txbx_name.Text,
                Password = txbx_password.Text,
                Gender = comboBox_gender.Text
            };


            if (txbx_password.Text.Length > 6 && Regex.IsMatch(txbx_name.Text, @"^[\p{L}]+$"))
            {
                User.users.Add(user);

                MessageBox.Show("You've registered");
            }
            else
                lbl_error.Text += "Check pwd or name again";

          
 

          


        }

        

        private void btn_select_image_Click(object sender, EventArgs e)
        {
             openFileDialog1.ShowDialog();
                       pictureBox1.ImageLocation = openFileDialog1.FileName;
            
        }
    }
}
