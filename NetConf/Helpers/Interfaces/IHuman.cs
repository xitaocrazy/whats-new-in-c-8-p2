using System;

namespace NetConf.Helpers.Interfaces
{
    public interface IHuman
    {
        int Age { get; set; }

        void Speak() => Console.WriteLine("I am human!");
    }
}