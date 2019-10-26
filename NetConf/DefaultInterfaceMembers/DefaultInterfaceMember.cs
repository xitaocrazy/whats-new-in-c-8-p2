using System;
using NetConf.Helpers.Classes;
using NetConf.Helpers.Interfaces;

namespace NetConf.DefaultInterfaceMembers
{
    public class DefaultInterfaceMember
    {
        public static void Demo()
        {
            Console.WriteLine("MinotauroVampiro");
            var minotauroVampiro = new MinotauroVampiro();
            minotauroVampiro.GolpearComChifre();
            minotauroVampiro.Hipnotizar();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Parte Humana");
            var parteHumana = (IHumano) minotauroVampiro;
            parteHumana.Falar();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Parte Minotauro");
            var parteMinotauro = (IMinotauro) minotauroVampiro;
            parteMinotauro.GolpearComMachado();
            parteMinotauro.Falar();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Parte Vampiro");
            var parteVampiro = (IVampiro) minotauroVampiro;
            parteVampiro.Curar();
            parteVampiro.Falar();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("IMinotauroVampiro");
            IMinotauroVampiro outroMinotauroVampiro = new MinotauroVampiro();
            outroMinotauroVampiro.Falar();
            outroMinotauroVampiro.GolpearComChifre();
            outroMinotauroVampiro.GolpearComMachado();
            outroMinotauroVampiro.Hipnotizar();
            outroMinotauroVampiro.Curar();
        }
    }
}
