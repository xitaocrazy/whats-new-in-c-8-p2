using System;
using NetConf.Helpers.Structs;

namespace NetConf.ReadOnlyMembers
{    
    public class ReadOnlyMember
    {
        public static void Demo() 
        {
            var coordenada = new Coordenada {x = 10, y=10};
            Console.WriteLine(coordenada.ToString());
        }
    }
}