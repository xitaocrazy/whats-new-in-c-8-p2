using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes
{
    public class Angel : IAngel
    {
        public int Age { get; set; }

        public void Voar()
        {
            Console.WriteLine("Flying");
        }
    }
}