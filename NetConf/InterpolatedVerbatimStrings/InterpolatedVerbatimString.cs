using System;

namespace NetConf.InterpolatedVerbatimStrings
{
    public class InterpolatedVerbatimString
    {
        public static void Demo() 
        {
            var nome = "João";
            var idade = 28;

            Console.WriteLine($@"{nome} tem {idade} anos e é \casado\.");
            Console.WriteLine(@$"{nome} tem {idade} anos e é \casado\.");
        }
    }
}