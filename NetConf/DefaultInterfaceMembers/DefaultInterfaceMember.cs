using System;
using NetConf.Helpers.Classes;
using NetConf.Helpers.Interfaces;

namespace NetConf.DefaultInterfaceMembers
{
    public class DefaultInterfaceMember
    {
        public static void Demo()
        {
            Console.WriteLine("Human:");
            IHuman human = new Human();
            human.Speak();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("MinotaurVampire:");
            var minotauroVampiro = new MinotaurVampire();
            minotauroVampiro.StrikeWithHorn();
            minotauroVampiro.Hypnotize();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Human part:");
            var parteHumana = (IHuman) minotauroVampiro;
            parteHumana.Speak();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Minotaur part:");
            var parteMinotauro = (IMinotaur) minotauroVampiro;
            parteMinotauro.StrikeWithAxe();
            parteMinotauro.Speak();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Vampire part:");
            var parteVampiro = (IVampire) minotauroVampiro;
            parteVampiro.Heal();
            parteVampiro.Speak();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("IMinotaurVampire");
            IMinotaurVampire outroMinotaurVampire = new MinotaurVampire();
            //MinotaurVampire outroMinotaurVampire = new MinotaurVampire();
            outroMinotaurVampire.Speak();
            outroMinotaurVampire.StrikeWithHorn();
            outroMinotaurVampire.StrikeWithAxe();
            outroMinotaurVampire.Hypnotize();
            outroMinotaurVampire.Heal();
        }
    }
}
