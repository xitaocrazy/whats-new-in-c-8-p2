using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IAnjo : IHuman
    {
        void Voar();

        void Curar() => Console.WriteLine("Curou a vida");

        void IHuman.Speak() => Console.WriteLine("Eu sou anjo");
    }
}