using System;
using NetConf.Helpers.Classes;

namespace NetConf.Patterns
{
    public class Pattern
    {
        public static void Demo()
        {
            Console.WriteLine("Switch Expression");
            Console.WriteLine(SwitchExpression(new Minotauro{Idade = 25}, 20));
            Console.WriteLine(SwitchExpression(new Minotauro{Idade = 20}, 20));
            Console.WriteLine(SwitchExpression(new Vampiro{Idade = 25}, 20));
            Console.WriteLine(SwitchExpression(new Vampiro{Idade = 25}, 10));
            Console.WriteLine(SwitchExpression(new Vampiro{Idade = 10}, 10));
            Console.WriteLine(SwitchExpression(new Minotauro{Idade = 10}, 10));
            Console.WriteLine(SwitchExpression(null, 10));
            Console.WriteLine(SwitchExpression(new Anjo(), 10));

            Console.WriteLine("Switch Statement");
            Console.WriteLine(SwitchExpression(new Minotauro{Idade = 25}, 20));
            Console.WriteLine(SwitchExpression(new Minotauro{Idade = 20}, 20));
            Console.WriteLine(SwitchExpression(new Vampiro{Idade = 25}, 20));
            Console.WriteLine(SwitchExpression(new Vampiro{Idade = 25}, 10));
            Console.WriteLine(SwitchExpression(new Vampiro{Idade = 10}, 10));
            Console.WriteLine(SwitchExpression(new Minotauro{Idade = 10}, 10));
            Console.WriteLine(SwitchExpression(null, 10));
            Console.WriteLine(SwitchExpression(new Anjo(), 10));
        }

        
        private static string SwitchStatement(object classe, int poder) 
        {
            switch (classe, poder)  //Tuple pattern
            {
                case (Minotauro {Idade: 25}, 20) : return "Golpe fatal do Minotauro"; //Property pattern
                case (Minotauro {Idade: _}, 20) : return "Golpe forte do Minotauro";
                case (Minotauro {Idade: 25}, _) : return "Golpe médio do Minotauro";
                case (Vampiro {Idade: 25}, 20) : return "Golpe fatal do Vampiro";
                case (Vampiro {Idade: _}, 20) : return "Golpe forte do Vampiro";
                case (Vampiro {Idade: 25}, _) : return "Golpe médio do Vampiro";
                case (Vampiro(2000), _) : return "Golpe especial do Vampiro"; //Positional pattern
                case (Humano {Idade: _}, _) : return "Golpe normal";
                case (null, _) : return "Classe não informada";
                case { }: return "Não é uma classe válida.";
                default: throw new ArgumentOutOfRangeException();
            };
        }    

        private static string SwitchExpression(object classe, int poder) => //Switch expression
            (classe, poder) switch //Tuple pattern
            {
                (Minotauro {Idade: 25}, 20) => "Golpe fatal do Minotauro", //Property pattern
                (Minotauro {Idade: _}, 20) => "Golpe forte do Minotauro",
                (Minotauro {Idade: 25}, _) => "Golpe médio do Minotauro",
                (Vampiro {Idade: 25}, 20) => "Golpe fatal do Vampiro",
                (Vampiro {Idade: _}, 20) => "Golpe forte do Vampiro",
                (Vampiro {Idade: 25}, _) => "Golpe médio do Vampiro",
                (Vampiro(2000), _) => "Golpe especial do Vampiro", //Positional pattern
                (Humano {Idade: _}, _) => "Golpe normal",
                (null, _) => "Classe não informada",
                { } => "Não é uma classe válida.",
            };
    }
}