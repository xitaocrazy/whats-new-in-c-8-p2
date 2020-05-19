using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IMinotaur : IHuman
    {
        void StrikeWithHorn();

        void StrikeWithAxe() => Console.WriteLine("Axe hit: 100");

        void IHuman.Speak() => Console.WriteLine("I am Minotaurrrrrrrr!!");
    }
}