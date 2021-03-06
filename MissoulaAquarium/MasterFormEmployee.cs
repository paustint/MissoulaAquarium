﻿using System;
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
    public partial class MasterFormEmployee : Form
    {
        private string currUser = "";
        private List<Event> eventsAvail = new List<Event>();
        private List<Event> eventsSigned = new List<Event>();
        private List<Employee> employees = new List<Employee>();
        private List<Tour> tourAvail = new List<Tour>();
        private List<Tour> tourSigned = new List<Tour>();

        public MasterFormEmployee(string currUser)
        {
            InitializeComponent();
            this.currUser = currUser;

            //populate events with hard coded values
            eventsAvail.Add(new Event("Whale Watch", "12/12/2013", "3:00 pm", "Missoula Aquarium", 1));
            eventsAvail.Add(new Event("Open Discussion", "12/15/2013", "6:00 pm", "University of Montana", 2));
            eventsAvail.Add(new Event("Seal Play-time", "12/17/2013", "1:00 pm", "Missoula Aquarium", 3));
            eventsAvail.Add(new Event("Pot Luck Dinner", "12/20/2013", "5:00 pm", "Caras Park", 4));

            addToListBoxAvailEvents();

            //populte employees with hard coded values
            int userNum = int.Parse(currUser);
            int diff = 0;// userNum - 79002;
            Employee current = new Employee("John Lee", userNum, "Associate");
            employees.Add(current);            
            Employee current2 = new Employee("Mary Jane", userNum - diff + 1, "Associate");
            employees.Add(current2);
            Employee current3 = new Employee("Fred Savage", userNum - diff + 2, "Manager");
            employees.Add(current3);
            Employee current4 = new Employee("Todd Regal", userNum - diff + 3, "Gift Shop Clerk");
            employees.Add(current4);
            
            //print to console for reference and debug
            foreach (Employee e in employees)
            {
                Console.WriteLine(e);
            }

            //add employees to schedule in sloppy manner ;)

            Shift currentEmpSch = new Shift(current, "Off", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "Off");
            ListViewItem item = new ListViewItem(new[] { "" + currentEmpSch.emp.empID, currentEmpSch.emp.empName, currentEmpSch.mon, currentEmpSch.tue, currentEmpSch.wed, currentEmpSch.thu, currentEmpSch.fri, currentEmpSch.sat, currentEmpSch.sun });
            scheduleListBox.Items.Add(item);

            currentEmpSch = new Shift(current2, "9:00 am-5:00 pm", "Off", "Off", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm");
            item = new ListViewItem(new[] { "" + currentEmpSch.emp.empID, currentEmpSch.emp.empName, currentEmpSch.mon, currentEmpSch.tue, currentEmpSch.wed, currentEmpSch.thu, currentEmpSch.fri, currentEmpSch.sat, currentEmpSch.sun });
            scheduleListBox.Items.Add(item);

            currentEmpSch = new Shift(current3, "Off", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "Off");
            item = new ListViewItem(new[] { "" + currentEmpSch.emp.empID, currentEmpSch.emp.empName, currentEmpSch.mon, currentEmpSch.tue, currentEmpSch.wed, currentEmpSch.thu, currentEmpSch.fri, currentEmpSch.sat, currentEmpSch.sun });
            scheduleListBox.Items.Add(item);

            currentEmpSch = new Shift(current4, "9:00 am-5:00 pm", "9:00 am-5:00 pm", "9:00 am-5:00 pm", "Off", "Off", "9:00 am-5:00 pm", "9:00 am-5:00 pm");
            item = new ListViewItem(new[] { "" + currentEmpSch.emp.empID, currentEmpSch.emp.empName, currentEmpSch.mon, currentEmpSch.tue, currentEmpSch.wed, currentEmpSch.thu, currentEmpSch.fri, currentEmpSch.sat, currentEmpSch.sun });
            scheduleListBox.Items.Add(item);

            ///add tours
            ///
            tourAvail.Add(new Tour("Seal Safari", 1, "Bill Johnson", "12/20/2013 8:00 am", "Missoula Aquarium"));
            tourAvail.Add(new Tour("Morning Glory", 2, "Ace Boomer", "12/21/2013 8:00 am", "Missoula Aquarium"));
            tourAvail.Add(new Tour("Night Owl", 3, "Linda Weston", "12/22/2013 10:00 pm", "Caras Park"));
            tourAvail.Add(new Tour("Shark Scamper", 4, "Sara Jones", "12/23/2013 11:00 am", "Missoula Aquarium"));
            addToAvailToursListBox();

        }

        private void addToAvailToursListBox()
        {
            availToursListBox.DataSource=tourAvail;
            availToursListBox.SelectedIndex = 0;
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
            toursSignedListBox.DataSource = temp;

        }

        private void addToListBoxAvailEvents()
        {   //add available events to listbox
            eventsAvailListBox.DataSource = eventsAvail;
            eventsAvailListBox.SelectedIndex = 0;
        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void eventsAvailListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void signupBtn_Click(object sender, EventArgs e)
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
            eventsSignedListBox.DataSource = temp;

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //cancel selected item in signed up box
            if ((eventsSigned.Count) != 0)
            {
                int index = eventsSignedListBox.SelectedIndex;
                eventsSigned.RemoveAt(index);
                addToListBoxSignedEvents();
            }
            else
            {
                //if there is no event to cancel
                MessageBox.Show("There are no events to cancel!");
            }
        }

        private void signTourBtn_Click(object sender, EventArgs e)
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

        private void cancelTourBtn_Click(object sender, EventArgs e)
        {
            //cancel selected item in signed up box
            if ((tourSigned.Count) != 0)
            {
                int index = toursSignedListBox.SelectedIndex;
                tourSigned.RemoveAt(index);
                addToSignedToursListBox();
            }
            else
            {
                //if there is no event to cancel
                MessageBox.Show("There are no tours to cancel!");
            }
        }
    }
}
