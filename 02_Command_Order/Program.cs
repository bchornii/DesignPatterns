using System;

namespace _02_Command_Order
{
    internal class Program
    {
        private static void Main()
        {
            //var remoteControll = new SimpleRemoteControll();
            //var light = new Light();
            //var garage = new GarageDoor();
            //var lightOnCmd = new LightOnCommand(light);
            //var garageDoorOpenCmd = new GarageDoorOpenCommand(garage);

            //remoteControll.SetCommand(lightOnCmd);
            //remoteControll.ButtonWasPressed();

            //remoteControll.SetCommand(garageDoorOpenCmd);
            //remoteControll.ButtonWasPressed();

            var remoteControll = new RemoteControll();
            var light = new Light();
            remoteControll.SetCommand(Slots.First, new LightOnCommand(light), new LightOffCommand(light));


            remoteControll.OnButtonWasPushed(Slots.First);
            remoteControll.OffButtonWasPushed(Slots.First);
            Console.WriteLine(remoteControll);
            remoteControll.UndoButtonWasPushed();

            remoteControll.OffButtonWasPushed(Slots.First);
            remoteControll.OnButtonWasPushed(Slots.First);
            Console.WriteLine(remoteControll);
            remoteControll.UndoButtonWasPushed();

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Fan control commands example :\n");

            var cellFan = new CellingFan("Living room");
            var cellingFanMedium = new CellingFanMediumCommand(cellFan);
            var cellingFanHigh = new CellingFanHighCommand(cellFan);
            var cellingFanOff = new CellingFanOffCommand(cellFan);

            remoteControll.SetCommand(Slots.Second, cellingFanMedium, cellingFanOff);
            remoteControll.SetCommand(Slots.Third, cellingFanHigh, cellingFanOff);

            remoteControll.OnButtonWasPushed(Slots.Second);
            remoteControll.OffButtonWasPushed(Slots.Second);            
            remoteControll.UndoButtonWasPushed();

            remoteControll.OnButtonWasPushed(Slots.Third);            
            remoteControll.UndoButtonWasPushed();

            Console.WriteLine(remoteControll);

            Console.Read();
        }
    }
}
