using System;
using RulePattern;

namespace FooBarQixCore.Rules
{
    using RulePattern.Interfaces;
    using FooBarQixCore.Conditions;
    using FooBarQixCore.Rules;


    public class RuleDividedByAndGenerate : Rule<int, string>
    {

        public RuleDividedByAndGenerate(uint divideBy, string generate)
        {
            Conditions.Add(new DividedBy(divideBy));
            Action.Apply = x => { return generate; };

        }
    }
}

