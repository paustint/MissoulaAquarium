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
    public partial class MasterFormCustomer : Form
    {
        private string custName = "";
        public MasterFormCustomer(string custName)
        {
            InitializeComponent();
            this.custName = custName;
            tourRegLblCustName.Text = custName;
            fillForms();
        }

        private void lblFeedbackTitle_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MasterFormCustomer_Load(object sender, EventArgs e)
        {

        }
        private void fillForms()
        {
            //This section fills the text boxes on the feedback form with the customers name
            char[] delim = {char.Parse(" ")};
            string[] name = custName.Split(delim);
            feedbackFirstName.Text = name[0];
            feedbackLastName.Text = name[1];

            //this section fills cust profile info
            cutInfoAdd1.Text = "12 Campus Drive";
            cutInfoAdd2.Text = "LA 206";
            cutInfoCity.Text = "Missoula";
            cutInfoPhone.Text = "406-555-1234";
            cutInfoStateCombo.Items.Add("MT");
            cutInfoStateCombo.SelectedIndex = 0;
            cutInfoZip.Text = "59801";
            cutInfoNameLAbel.Text = custName;
            cutInfoLblTitle.Text = name[0] + "'s " + cutInfoLblTitle.Text;

            //Fills tour sign up name (likely the same)
            tourSignUpNameLbl.Text = custName;


                

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
