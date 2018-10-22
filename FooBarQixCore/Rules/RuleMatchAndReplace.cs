using System;
using RulePattern;

namespace FooBarQixCore.Rules
{
    using FooBarQixCore.Conditions;

    public class RuleMatchAndReplace : Rule<string, string>
    {

        public RuleMatchAndReplace(char charMatch, string replace)
        {
            char _charMatch = charMatch;
            string _replace = "";

            Conditions.Add(new ContainsChar(charMatch));
            Action.Apply = context => {
              
                foreach (char readedChar in context)
                {
                    if (readedChar == _charMatch) _replace += '*';
                    else _replace += readedChar;
                }

                return _replace;
            };

        }
    }
}
