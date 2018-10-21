using fabiostefani.io.BookPadroesProjetos.Command.Commands;
using fabiostefani.io.BookPadroesProjetos.Command.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabiostefani.io.BookPadroesProjetos.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SIMPLE REMOTE CONTROL");
            var simpleRemoteControl = new SimpleRemoteControl();
            var light = new Light("Living room");
            var lightOn = new LightOnCommand(light);
            simpleRemoteControl.SetCommand(lightOn);
            simpleRemoteControl.ButtonWasPressed();

            var garageDoorSimpleControl = new GarageDoor();
            var garageOpen = new GarageDoorOpenCommand(garageDoorSimpleControl);
            simpleRemoteControl.SetCommand(garageOpen);
            simpleRemoteControl.ButtonWasPressed();

            Console.WriteLine("REMOTE CONTROL");
            var remoteControl = new RemoteControl();
            var livingRoomLight = new Light("Living room");
            var kitchenLight = new Light("Kitchen");
            var ceilingFan = new CeilingFan("Living room");
            var garageDoor = new GarageDoor();
            var stereo = new Stereo("Living room");

            var livingRoomLightOn = new LightOnCommand(livingRoomLight);
            var livingRoomLightOff = new LightOffCommand(livingRoomLight);
            var kitchenLightOn = new LightOnCommand(kitchenLight);
            var kitchenLightOff = new LightOffCommand(kitchenLight);

            var ceilingFanOn = new CeilingFanOnCommand(ceilingFan);
            var ceilingFanOff = new CeilingFanOffCommand(ceilingFan);

            var garageDoorOpen = new GarageDoorOpenCommand(garageDoor);
            var garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            var stereoOnWithCd = new StereoOnWithCdCommand(stereo);
            var stereoOffWithCd = new StereoOffWithCdCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOnWithCd, stereoOffWithCd);

            Console.WriteLine(remoteControl.ToString());
            Console.WriteLine("-----------------FUNÇÕES EXECUTANDO");

            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);

            Console.WriteLine("");
            Console.WriteLine("REMOTE CONTROL WITH UNDO");
            remoteControl.OnButtonWasPushed(0);
            remoteControl.OffButtonWasPushed(0);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(2);
            remoteControl.OffButtonWasPushed(2);
            remoteControl.UndoButtonWasPushed();
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OffButtonWasPushed(3);
            remoteControl.UndoButtonWasPushed();

            Console.WriteLine("");
            Console.WriteLine("REMOTE CONTROL WITH UNDO OF THE CEILING FAN");
            var remoteControlCeilingFan = new RemoteControl();
            var ceilingFanHigh = new CeilingFanHightCommand(ceilingFan);
            var ceilingFanMedium = new CeilingFanMediumCommand(ceilingFan);

            remoteControlCeilingFan.SetCommand(0, ceilingFanMedium, ceilingFanOff);
            remoteControlCeilingFan.SetCommand(1, ceilingFanHigh, ceilingFanOff);

            remoteControlCeilingFan.OnButtonWasPushed(0);
            remoteControlCeilingFan.OffButtonWasPushed(0);
            Console.WriteLine(remoteControlCeilingFan.ToString());
            remoteControlCeilingFan.UndoButtonWasPushed();
            //remoteControlCeilingFan.OnButtonWasPushed(0);
            remoteControlCeilingFan.OnButtonWasPushed(1);
            Console.WriteLine(remoteControlCeilingFan.ToString());
            remoteControlCeilingFan.UndoButtonWasPushed();


            Console.WriteLine("");
            Console.WriteLine("MACRO COMAND (PARTY MODE)");

            var tv = new Tv("Living room");
            var hottub = new Hottub();

            var tvOn = new TvOnCommand(tv);
            var tvOff = new TvOffCommand(tv);
            var hottubOn = new HottubOnCommand(hottub);
            var hottubOff = new HottubOffCommand(hottub);

            var commandsPartyOn = new List<ICommand>()
            {
                livingRoomLightOn,
                stereoOnWithCd,
                tvOn,
                hottubOn
            };

            var commandsPartyOff = new List<ICommand>()
            {
                livingRoomLightOff,
                stereoOffWithCd,
                tvOff,
                hottubOff
            };
            var partyOn = new MacroCommand(commandsPartyOn);
            var partyOff = new MacroCommand(commandsPartyOff);
            var remoteControlParty= new RemoteControl();

            remoteControlParty.SetCommand(0, partyOn, partyOff);

            Console.WriteLine(remoteControlParty.ToString());
            Console.WriteLine("PUSHING MACRO ON");
            remoteControlParty.OnButtonWasPushed(0);
            Console.WriteLine("PUSHING MACRO OFF");
            remoteControlParty.OffButtonWasPushed(0);

            Console.ReadKey();
        }
    }
}
