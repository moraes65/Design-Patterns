using fabiostefani.io.BookPadroesProjetos.Command.Interfaces;
using System;

namespace fabiostefani.io.BookPadroesProjetos.Command.Entities
{
    public class CeilingFan : ICeilingFan
    {
        private readonly string name;
        private EnumSpeedCeilingFan speed;

        public CeilingFan(string name)
        {
            this.name = name;
            this.Off();
        }
        public void Off()
        {
            Console.WriteLine($"{this.name} ceiling fan off");
            this.speed = EnumSpeedCeilingFan.Off;
        }

        public void On()
        {
            Console.WriteLine($"{this.name} ceiling fan on");            
        }

        public void High()
        {            
            this.speed = EnumSpeedCeilingFan.High;
            Console.WriteLine($"Setting ceiling fan of the {this.name} to Hight");
        }

        public void Medium()
        {
            this.speed = EnumSpeedCeilingFan.Medium;
            Console.WriteLine($"Setting ceiling fan of the {this.name} to Medium");
        }

        public void Low()
        {
            this.speed = EnumSpeedCeilingFan.Low;
            Console.WriteLine($"Setting ceiling fan of the {this.name} to Low");
        }

        public EnumSpeedCeilingFan GetSpeed()
        {
            return this.speed;
        }
        
    }

    public enum EnumSpeedCeilingFan
    {
        Off = 0,
        Low = 1,
        Medium = 2,
        High = 3
    }


}
