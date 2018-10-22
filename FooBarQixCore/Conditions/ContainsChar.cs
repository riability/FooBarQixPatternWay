using System;
using RulePattern.Interfaces;

namespace FooBarQixCore.Conditions
{
    public class ContainsChar : Condition<string>
    {
        public readonly char _charMatch;
        public ContainsChar(char charMatch)
        {
            _charMatch = charMatch;

            IsSatisfied = (string context) =>
            {
                foreach (char readedChar in context)
                {
                    if (readedChar == _charMatch) return true;
                }
                return false;

            };


        }

    }
}
