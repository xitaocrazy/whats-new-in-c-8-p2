using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes
{
    public class Anjo : IAnjo
    {
        public int Age { get; set; }

        public void Voar()
        {
            Console.WriteLine("Esta voando!!");
        }
    }
}