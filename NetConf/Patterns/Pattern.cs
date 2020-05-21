using System;
using NetConf.Helpers.Classes;

namespace NetConf.Patterns
{
    public class Pattern
    {
        public static void Demo()
        {
            SwitchStatementSamples();
            Console.WriteLine("-------------------------------------");
            SwitchExpressionSamples();
        }

        private static void SwitchStatementSamples()
        {
            Console.WriteLine("Switch Statement");
            Console.WriteLine(SwitchStatement(new Minotaur {Age = 25}, 20)); //"Minotaur fatal damage"
            Console.WriteLine(SwitchStatement(new Minotaur {Age = 20}, 20)); //"Minotaur strong damage"
            Console.WriteLine(SwitchStatement(new Minotaur {Age = 25}, 10)); //"Minotaur normal damage"
            Console.WriteLine(SwitchStatement(new Vampire {Age = 25}, 20)); //"Vampire fatal damage"
            Console.WriteLine(SwitchStatement(new Vampire {Age = 20}, 20)); //"Vampire strong damage"
            Console.WriteLine(SwitchStatement(new Vampire {Age = 25}, 10)); //"Vampire normal damage"
            Console.WriteLine(SwitchStatement(new Vampire {Age = 10}, 10)); //"Vampire special damage"
            Console.WriteLine(SwitchStatement(new Minotaur {Age = 10}, 10)); //"Human normal damage"
            Console.WriteLine(SwitchStatement(null, 10)); //"Class not reported"
            Console.WriteLine(SwitchStatement(new Angel(), 10)); //"It is not a valid class"
        }


        private static string SwitchStatement(object classe, int poder) 
        {
            switch (classe, poder)  //Tuple pattern
            {
                case (Minotaur {Age: 25}, 20) : return "Minotaur fatal damage"; //Property pattern
                case (Minotaur {Age: _}, 20) : return "Minotaur strong damage";
                case (Minotaur {Age: 25}, _) : return "Minotaur normal damage";
                case (Vampire {Age: 25}, 20) : return "Vampire fatal damage";
                case (Vampire {Age: _}, 20) : return "Vampire strong damage";
                case (Vampire {Age: 25}, _) : return "Vampire normal damage";
                case (Vampire(10), _) : return "Vampire special damage"; //Positional pattern
                case (Human {Age: _}, _) : return "Human normal damage";
                case (null, _) : return "Class not reported";
                default: return "It is not a valid class";
            };
        } 
        
        private static void SwitchExpressionSamples()
        {
            Console.WriteLine("Switch Expression");
            Console.WriteLine(SwitchExpression(new Minotaur {Age = 25}, 20)); //"Minotaur fatal damage"
            Console.WriteLine(SwitchExpression(new Minotaur {Age = 20}, 20)); //"Minotaur strong damage"
            Console.WriteLine(SwitchExpression(new Minotaur {Age = 25}, 10)); //"Minotaur normal damage"
            Console.WriteLine(SwitchExpression(new Vampire {Age = 25}, 20)); //"Vampire fatal damage"
            Console.WriteLine(SwitchExpression(new Vampire {Age = 20}, 20)); //"Vampire strong damage"
            Console.WriteLine(SwitchExpression(new Vampire {Age = 25}, 10)); //"Vampire normal damage"
            Console.WriteLine(SwitchExpression(new Vampire {Age = 10}, 10)); //"Vampire special damage"
            Console.WriteLine(SwitchExpression(new Minotaur {Age = 10}, 10)); //"Human normal damage"
            Console.WriteLine(SwitchExpression(null, 10)); //"Class not reported"
            Console.WriteLine(SwitchExpression(new Angel(), 10)); //"It is not a valid class"          
        }

        private static string SwitchExpression(object classe, int poder) => //Switch expression
            (classe, poder) switch //Tuple pattern
            {
                (Minotaur {Age: 25}, 20) => "Minotaur fatal damage", //Property pattern
                (Minotaur {Age: _}, 20) => "Minotaur strong damage",
                (Minotaur {Age: 25}, _) => "Minotaur normal damage",
                (Vampire {Age: 25}, 20) => "Vampire fatal damage",
                (Vampire {Age: _}, 20) => "Vampire strong damage",
                (Vampire {Age: 25}, _) => "Vampire normal damage",
                (Vampire(10), _) => "Vampire special damage", //Positional pattern
                (Human {Age: _}, _) => "Human normal damage",
                (null, _) => "Class not reported",
                _ => "It is not a valid class"
            };
    }
}