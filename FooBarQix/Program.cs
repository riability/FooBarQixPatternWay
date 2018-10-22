using System;
using RulePattern;
using FooBarQixCore;
using FooBarQixCore.Conditions;
using FooBarQixCore.Rules;
/*
If the number is divisible by 3, write “Foo” instead of the number
If the number is divisible by 5, add “Bar”
If the number is divisible by 7, add “Qix”
For each digit 3, 5, 7, add “Foo”, “Bar”, “Qix” in the digits order.
*/
namespace FooBarQix
{
   

    class Program
    {
        public static void Main(string[] args)
        {
            string inputLine;
            while (true)
            {
                inputLine = Console.ReadLine();

                Console.WriteLine(" " + inputLine +" ==> " + Program.Compute(inputLine));
            }

        }

       
        static string Compute(string theInput)
        {

            string result = "";
            int parsedValue;

            bool parsed = Int32.TryParse(theInput, out parsedValue);

            if (parsed == false) return " Please enter a valid Digit";
            RuleApplyer<int, string> divideApplyer = new RuleApplyer<int, string>();
            divideApplyer.Rules.Add(new RuleDividedByAndGenerate(3, "Foo"));
            divideApplyer.Rules.Add(new RuleDividedByAndGenerate(5, "Bar"));
            divideApplyer.Rules.Add(new RuleDividedByAndGenerate(7, "Quix"));


            var results = divideApplyer.ApplyRules(parsedValue);
            foreach (var res in results) result += res.Value;

            RuleApplyer<string, string> translateApplyer = new RuleApplyer<string, string>();
            translateApplyer.Rules.Add(new RuleMatchAndTranslate('3', "Foo"));
            translateApplyer.Rules.Add(new RuleMatchAndTranslate('5', "Bar"));
            translateApplyer.Rules.Add(new RuleMatchAndTranslate('7', "Quix"));
            translateApplyer.Rules.Add(new RuleMatchAndTranslate('0', "*"));
            var results2 = translateApplyer.ApplyRules(theInput);
            foreach (var res in results2) result += res.Value;




            RuleApplyer<string, string> replaceApplyer = new RuleApplyer<string, string>();
            replaceApplyer.Rules.Add(new RuleMatchAndTranslate('0', "*"));



            return result;
        }
      
    }
}
