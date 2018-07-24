using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserRegistiration
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User() 
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
                Age = Convert.ToInt32(txtAge.Text),
                Surname = txtSurname.Text,
                Gender = rdMale.Checked ? true: false,
            };

            LocalStorage.Users.Add(user);

             


            foreach (Control ctrl in this.Controls)
            { 
                if(ctrl is TextBox)
                {
                    this.cleaner((TextBox)ctrl);
                } 
            }  
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            LocalStorage.MainForm = this;
            AllUsers form = new AllUsers();
            form.Show();
        }

        void cleaner(TextBox txt)
        {
            txt.Text = "";
        }

    }
}
