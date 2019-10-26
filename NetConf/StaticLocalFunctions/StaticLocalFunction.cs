using System;
using System.Collections.Generic;

namespace NetConf.StaticLocalFunctions
{
    public class StaticLocalFunction
    {
        public static void Demo() 
        {
            foreach (var i in Contador(1,10))
                Console.WriteLine(i);
        }

        //Agora (O compilador provê otimizações declarando como static)
        public static IEnumerable<int> Contador(int inicio, int fim)
        {
            if (inicio >= fim)
                throw new ArgumentOutOfRangeException("O início do contador deve ser maior do que o fim.");

            return ContadorLocal(inicio, fim);

            static IEnumerable<int> ContadorLocal(int inicio, int fim) 
            {
                for (var i = inicio; i <= fim; i++)
                    yield return i;
            }
        }
    }
}