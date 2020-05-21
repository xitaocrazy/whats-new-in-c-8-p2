using System;

namespace NetConf.Helpers.Structs
{
    public struct Coordinate
    {
        public int X {get; set;}
        public int Y {get; set;}

        private readonly double Distance => CalculateDistance();

        public override readonly string ToString() => $"({X}, {Y}) is {Distance} from the origin.";

        private readonly double CalculateDistance()
        {
            //You can't do any modification.
            //X = 20;
            //Y = 20; 
            return Math.Sqrt(X*X+Y*Y);
        }
    }
}