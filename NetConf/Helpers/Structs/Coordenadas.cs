using System;

namespace NetConf.Helpers.Structs
{
    public struct Coordenada
    {
        public int x {get; set;}
        public int y {get; set;}

        readonly public double Distancia => Calcular();

        readonly public override string ToString() => $"({x}, {y}) está a {Distancia} da origem.";

        readonly public double Calcular()
        {
            //Não é possível fazer alterações.
            /* x = 20;
            y = 20; */
            return Math.Sqrt(x*x+y*y);
        }
    }
}