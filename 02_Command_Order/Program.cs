using System;
using System.Collections.Generic;

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

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Light control commands example :\n");

            var remoteControll = new RemoteControll();
            var light = new Light();
            remoteControll.SetCommand(Slots.First, new LightOnCommand(light), 
                new LightOffCommand(light));            

            remoteControll.OnButtonWasPushed(Slots.First);
            remoteControll.OffButtonWasPushed(Slots.First);            
            remoteControll.UndoButtonWasPushed();

            remoteControll.OffButtonWasPushed(Slots.First);
            remoteControll.OnButtonWasPushed(Slots.First);            
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

            Console.WriteLine(new string('-', 80));
            Console.WriteLine("Macro command example :\n");

            var light2 = new Light();
            var radio = new Radio();
            var tv = new Tv();
            var lightOnCmd = new LightOnCommand(light2);
            var lightOffCmd = new LightOffCommand(light2);
            var radionOnCmd = new RadioOnCommand(radio);
            var radioOffCmd = new RadioOffCommand(radio);
            var tvOnCmd = new TvOnCommand(tv);
            var tvOffCmd = new TvOffCommand(tv);
            
            var macroOnCmd = new MacroCommand(new ICommand[]
            {
                lightOnCmd,
                radionOnCmd,
                tvOnCmd
            });
            var macroOffCmd = new MacroCommand(new ICommand[]
            {
                lightOffCmd,
                radioOffCmd,
                tvOffCmd
            });
            remoteControll.SetCommand(Slots.Fourth, macroOnCmd, macroOffCmd);
            remoteControll.OnButtonWasPushed(Slots.Fourth);
            remoteControll.OffButtonWasPushed(Slots.Fourth);

            Console.WriteLine(remoteControll);

            Console.Read();
        }
    }
}
