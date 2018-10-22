using System;
using RulePattern;


namespace FooBarQixCore
{
    using FooBarQixCore.Conditions;
    using FooBarQixCore.Rules;

    public class Methods
    {
        string Compute(string theInput)
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

            var results2 = translateApplyer.ApplyRules(theInput);
            foreach (var res in results2) result += res.Value;

            return result;

        }
    }
}
