using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes
{
    public class Minotauro : Humano, IMinotauro
    {
        public void GolpearComChifre()
        {
            Console.WriteLine("Golpe realizado!!");
        }
    }
}