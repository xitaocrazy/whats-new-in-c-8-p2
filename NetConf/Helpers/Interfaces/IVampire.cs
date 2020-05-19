using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IVampire : IHuman
    {
        void Hypnotize();

        void Heal() => Console.WriteLine("Healing: 100");

        new void Speak() => Console.WriteLine("I am vampire HA HA HA.");
    }
}