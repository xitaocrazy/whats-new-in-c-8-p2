using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IVampiro : IHumano
    {
        void Hipnotizar();

        void Curar() => Console.WriteLine("Curou a vida");

        new void Falar() => Console.WriteLine("Eu sou vampiro");
    }
}