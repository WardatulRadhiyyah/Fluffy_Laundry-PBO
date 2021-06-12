using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fluffy_Laundry
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.LoginName = tbUsername.Text;
            employee.Password = tbPassword.Text;

            if (employee.Login(employee.LoginName, employee.Password))
            { MessageBox.Show("Login Berhasil, ID Anda adalah " + employee.EmployeeID.ToString());
                Menu menu = new Menu();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }
         
            
        }
    }



