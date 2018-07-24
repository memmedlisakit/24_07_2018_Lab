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
    public partial class AllUsers : Form
    {
        public AllUsers()
        {
            InitializeComponent();
            fillData(LocalStorage.Users);
        }


        void fillData(List<User> users)
        {
            int index = 0;
            foreach (User usr in users)
            {
                dgwData.Rows.Add();
                dgwData.Rows[index].Cells[0].Value = usr.Username;
                dgwData.Rows[index].Cells[1].Value = usr.Surname;
                dgwData.Rows[index].Cells[2].Value = usr.Age;
                dgwData.Rows[index].Cells[3].Value = usr.Gender ? "Male" : "Female";
                index++;
            }
        }
    }
}
