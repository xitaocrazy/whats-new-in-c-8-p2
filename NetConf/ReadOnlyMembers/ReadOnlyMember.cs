using System;
using NetConf.Helpers.Structs;

namespace NetConf.ReadOnlyMembers
{    
    public class ReadOnlyMember
    {
        public static void Demo() 
        {
            var coordinate = new Coordinate {X = 10, Y=10};
            Console.WriteLine(coordinate.ToString());
        }
    }
}