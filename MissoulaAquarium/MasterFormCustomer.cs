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
        private List<Event> eventsAvail = new List<Event>();
        private List<Event> eventsSigned = new List<Event>();
        private List<Employee> employees = new List<Employee>();
        private List<Tour> tourAvail = new List<Tour>();
        private List<Tour> tourSigned = new List<Tour>();


        public MasterFormCustomer(string custName)
        {
            InitializeComponent();
            this.custName = custName;
            tourRegLblCustName.Text = custName;
            fillForms();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            //Populate events
            //populate events with hard coded values
            eventsAvail.Add(new Event("Whale Watch", "12/12/2013", "3:00 pm", "Missoula Aquarium", 1));
            eventsAvail.Add(new Event("Open Discussion", "12/15/2013", "6:00 pm", "University of Montana", 2));
            eventsAvail.Add(new Event("Seal Play-time", "12/17/2013", "1:00 pm", "Missoula Aquarium", 3));
            eventsAvail.Add(new Event("Pot Luck Dinner", "12/20/2013", "5:00 pm", "Caras Park", 4));
            eventsAvailListBox.DataSource = eventsAvail;
            eventsAvailListBox.SelectedIndex = 0;


            //Populate tours
            tourAvail.Add(new Tour("Seal Safari", 1, "Bill Johnson", "12/20/2013 8:00 am", "Missoula Aquarium"));
            tourAvail.Add(new Tour("Morning Glory", 2, "Ace Boomer", "12/21/2013 8:00 am", "Missoula Aquarium"));
            tourAvail.Add(new Tour("Night Owl    ", 3, "Linda Weston", "12/22/2013 10:00 pm", "Caras Park"));
            tourAvail.Add(new Tour("Shark Scamper", 4, "Sara Jones", "12/23/2013 11:00 am", "Missoula Aquarium"));
            addToAvailToursListBox();

        }

        private void addToAvailToursListBox()
        {
            availToursListBox.DataSource = tourAvail;
            availToursListBox.SelectedIndex = 0;
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
            eventSignUpNameLbl.Text = custName;

                

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

        private void textBox3TourSignUpButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 0;
        }

        private void textBox3RegToursButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 2;
        }

        private void availToursListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //add selected item to signed up box
            int index = availToursListBox.SelectedIndex;
            Tour temp = tourAvail.ElementAt(index);
            Boolean isSigned = false;
            //make sure user is not already signed up for event
            foreach (Tour ev in tourSigned)
            {
                if (ev.getID() == temp.getID())
                {
                    isSigned = true;
                    MessageBox.Show("You are already signed up for this tour.");
                }
            }
            if (!isSigned)
            {
                tourSigned.Add(temp);
                addToSignedToursListBox();
            }
        }

        private void addToSignedToursListBox()
        {
            //add tour to signed up listbox
            List<Tour> temp = new List<Tour>();
            //must use new array for some reason or it will not work
            foreach (Tour e in tourSigned)
            {
                temp.Add(e);
            }
            tourRegTourSignedUpList.DataSource = temp;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
        {

        }

        private void eventsAvailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 5;
            trackBar2.Value = 5;
            trackBar3.Value = 5;
            feedbackComment.Text = "";
            feedbackEmail.Text = "";
            feedbackFirstName.Text = "";
            feedbackLastName.Text = "";

            MessageBox.Show("Thank you for your feedback!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //add selected item to signed up box
            int index = eventsAvailListBox.SelectedIndex;
            Event temp = eventsAvail.ElementAt(index);
            Boolean isSigned = false;
            //make sure user is not already signed up for event
            foreach (Event ev in eventsSigned)
            {
                if (ev.eventID == temp.eventID)
                {
                    isSigned = true;
                    MessageBox.Show("You are already signed up for this event.");
                }
            }
            if (!isSigned)
            {
                eventsSigned.Add(temp);
                addToListBoxSignedEvents();

            }
        }

        private void addToListBoxSignedEvents()
        {
            //add event to signed up listbox
            List<Event> temp = new List<Event>();
            //must use new array for some reason or it will not work
            foreach (Event e in eventsSigned)
            {
                temp.Add(e);
            }
            eventRegSignedUpList.DataSource = temp;
            

        }

        private void tourRegBtnClear_Click(object sender, EventArgs e)
        {
                        //cancel selected item in signed up box
            if ((tourSigned.Count) != 0)
            {
                int index = tourRegTourSignedUpList.SelectedIndex;
                tourSigned.RemoveAt(index);
                addToSignedToursListBox();
            }
            else
            {
                //if there is no event to cancel
                MessageBox.Show("There are no tours to cancel!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                        //cancel selected item in signed up box
            if ((eventsSigned.Count) != 0)
            {
                int index = eventRegSignedUpList.SelectedIndex;
                eventsSigned.RemoveAt(index);
                addToListBoxSignedEvents();
            }
            else
            {
                //if there is no event to cancel
                MessageBox.Show("There are no events to cancel!");
            }
        }
        
    }
}
