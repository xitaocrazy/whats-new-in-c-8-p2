using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes
{
    public class Minotaur : Human, IMinotaur
    {
        public void StrikeWithHorn()
        {
            Console.WriteLine("Horn hit: 100");
        }
    }
}