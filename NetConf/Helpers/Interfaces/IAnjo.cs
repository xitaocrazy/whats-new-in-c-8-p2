using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IAnjo : IHumano
    {
        void Voar();

        void Curar() => Console.WriteLine("Curou a vida");

        void IHumano.Falar() => Console.WriteLine("Eu sou anjo");
    }
}