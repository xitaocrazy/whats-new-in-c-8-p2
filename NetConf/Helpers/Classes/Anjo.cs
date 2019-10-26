using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes
{
    public class Anjo : IAnjo
    {
        public int Idade { get; set; }

        public void Voar()
        {
            Console.WriteLine("Esta voando!!");
        }
    }
}