using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IMinotauro : IHumano
    {
        void GolpearComChifre();

        void GolpearComMachado() => Console.WriteLine("Golpe com machado");

        void IHumano.Falar() => Console.WriteLine("Eu sou minotauro");
    }
}