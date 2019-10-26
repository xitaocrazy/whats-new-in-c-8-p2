using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IHumano
    {
        int Idade { get; set; }

        void Falar() => Console.WriteLine("Eu sou humano");
    }
}