using System;

namespace _01_Prototype
{
    public class CalendarEvent : CalendarProptotype
    {
        public Attendee[] Attendees { get; set; }
        public Priority Priority { get; set; }
        public DateTime StartDateTime { get; set; }

        public override CalendarProptotype Clone()
        {
            var copy = (CalendarEvent)base.Clone();

            // це дозволить нам мати список із посиланнями на тих же відвідувачів            
            var copiedAttendees = (Attendee[])Attendees.Clone();
            copy.Attendees = copiedAttendees;

            //copy.Attendees = copiedAttendees; 
            // Також скопіюємо приоритет
            //. ....
            copy.Priority = Priority.Clone();

            return copy;
        }
    }
}
