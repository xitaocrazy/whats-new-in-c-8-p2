using System;
using NetConf.Helpers.Interfaces;

namespace NetConf.Helpers.Classes 
{
    public class MinotauroVampiro : IMinotauroVampiro
    {
        public int Idade { get; set; }

        public void GolpearComChifre() => Console.WriteLine("Golpeou com Chifre");

        public void Hipnotizar() => Console.WriteLine("Hipnotizou");
    }
}