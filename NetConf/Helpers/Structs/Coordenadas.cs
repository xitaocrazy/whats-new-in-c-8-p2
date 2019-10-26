using System;

namespace NetConf.Helpers.Structs
{
    public struct Coordenada
    {
        public int x {get; set;}
        public int y {get; set;}

        public double Distancia => Calcular();

        public override string ToString() => $"({x}, {y}) está a {Distancia} da origem.";

        public double Calcular()
        {
            x = 20;
            y = 20;
            return Math.Sqrt(x*x+y*y);
        }
    }
}