﻿using System;

namespace _01_Prototype
{
    public class PrototypeDemo
    {
        public static CalendarEvent GetExistingEvent()
        {
            var beerParty = new CalendarEvent();
            var friends = new Attendee[2];

            var andriy = new Attendee { FirstName = "Andriy", LastName = "Buday", Email = "andriybuday@liamg.com" };

            friends[0] = andriy;

            beerParty.Attendees = friends;
            beerParty.StartDateTime = new DateTime(2010, 7, 23, 19, 0, 0);
            beerParty.Priority = new Priority().Hight();

            return beerParty;
        }

        public static void Run()
        {
            var beerParty = GetExistingEvent();
            var nextFridayEvent = (CalendarEvent)beerParty.Clone();
            nextFridayEvent.StartDateTime = new DateTime(2010, 7, 30, 19, 0, 0);

            nextFridayEvent.Attendees[0].Email = "andriybuday@liamg.com";
            nextFridayEvent.Priority.Low();

            nextFridayEvent.Attendees[1] = new Attendee { Email = "dfdf", FirstName = "vd", LastName = "dh" };

            if (beerParty.Attendees != nextFridayEvent.Attendees)
            {
                Console.WriteLine("GOOD: Each event has own list of attendees.");
            }

            if (beerParty.Attendees[0].Email == nextFridayEvent.Attendees[0].Email)
            {
                Console.WriteLine(beerParty.Attendees[0].Email);
                Console.WriteLine(nextFridayEvent.Attendees[0].Email);

                nextFridayEvent.Attendees[0].Email = "dfdfd";

                Console.WriteLine(beerParty.Attendees[0].Email);
                Console.WriteLine(nextFridayEvent.Attendees[0].Email);
                // В цьому випадку добре мати поверхневу копію кожного із учасників,

                // таким чином моя адреса, ім'я і персональні дані залишаються тими ж

                Console.WriteLine("GOOD: Update to my e-mail address will be reflected in all events.");
            }
            
            if(beerParty.Priority.Prior != nextFridayEvent.Priority.Prior)
            {
                Console.WriteLine("GOOD: Each event should have own priority object, fully-copied.");
            }          
        }
    }
}
