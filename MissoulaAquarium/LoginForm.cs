using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissoulaAquarium
{
    public partial class LoginForm : Form
    {
        //Hardcoded strings of valid login names

        Dictionary<string, string> userNamesEmp = new Dictionary<string, string>();
        Dictionary<string, string> userNamesCust = new Dictionary<string, string>();
        

        public LoginForm()
        {
            InitializeComponent();
            userNamesEmp.Add("John", "j1234");
            userNamesEmp.Add("Sally", "s1234");
            userNamesEmp.Add("Bob", "b1234");
            userNamesEmp.Add("Harry", "h1234");
            userNamesCust.Add("Bruno Mars", "b1234");
            userNamesCust.Add("Josh Price", "j1234");
            userNamesCust.Add("Marshall Hanson", "m1234");
        }

        private void login_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            Boolean correctCredentials;
            correctCredentials = checkPassword(true, empNameTxtBox.Text, empPasswordTxtBox.Text);

            if (correctCredentials)
            {
                MasterFormEmployee emp = new MasterFormEmployee();

                lblStatus.Text = "";
                emp.currUser = empNameTxtBox.Text;
                clearLabels();
                //TODO: OPEN MasterFormEmployee
                this.Hide();
                emp.ShowDialog();
                this.Show();

            }
            else
            {
                lblStatus.Text = "Invalid login credentials, please try again";
                clearLabels();
            }

            


        }//Close employee login button


        private void button1_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "";
            Boolean correctCredentials;
            correctCredentials = checkPassword(false, custNameTxtBox.Text, custPasswordTxtBox.Text);

            if (correctCredentials)
            {
                clearLabels();
                //TODO: OPEN MasterFormCust
                this.Hide();
                MasterFormCustomer cust = new MasterFormCustomer();
                cust.ShowDialog();
                this.Show();
            }
            else
            {
                lblStatus.Text = "Invalid login credentials, please try again";
                clearLabels();
            }
        }

        public void clearLabels()
        {
            custNameTxtBox.Text = "";
            custPasswordTxtBox.Text = "";
            empNameTxtBox.Text = "";
            empPasswordTxtBox.Text = "";
        }

        //Checks if password is correct
        private Boolean checkPassword(Boolean isEmployee, string userName, string password)
        {
            Boolean correctPassword = false;
            string tempPassword = "";

            if (isEmployee)
            {
                if (userNamesEmp.TryGetValue(userName, out tempPassword))
                {
                    if (tempPassword.Equals(password))
                    {
                        correctPassword = true;
                    }
                    
                }

            }
                //Must be customer
            else
            {
                if (userNamesCust.TryGetValue(userName, out tempPassword))
                {
                    if (tempPassword.Equals(password))
                    {

                        correctPassword = true;
                    }
                }

            }


            return correctPassword;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }


    
    
    }
}
