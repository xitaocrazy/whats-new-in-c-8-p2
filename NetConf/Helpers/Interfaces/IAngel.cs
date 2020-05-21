using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IAngel : IHuman
    {
        void Voar();

        void Curar() => Console.WriteLine("Life was healed: 100");

        void IHuman.Speak() => Console.WriteLine("I am angel");
    }
}