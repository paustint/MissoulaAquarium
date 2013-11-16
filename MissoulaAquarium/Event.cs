using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissoulaAquarium
{
    class Event
    {
        private string eventName = "";
        private string eventDate = "";
        private string eventTime = "";
        private string eventLocation = "";
        private string attendee = "";
        public int eventID {get;set;}

        public Event(string name, string d, string time, string location, int i)
        {
            eventName = name;
            eventDate = d;
            eventTime = time;
            eventLocation = location;
            eventID = i;

        }

        public override string ToString()
        {
            return eventID + "\t" + eventName + "\t" + eventDate + "\t" + eventTime + "\t" + eventLocation;
        }

        public void setAttendee(string a)
        {
            attendee = a;
        }

        //public string 
    }
}
