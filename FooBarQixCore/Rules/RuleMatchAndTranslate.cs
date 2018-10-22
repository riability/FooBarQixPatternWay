using System;
using RulePattern;

namespace FooBarQixCore.Rules
{
    using FooBarQixCore.Conditions;

    public class RuleMatchAndTranslate : Rule<string, string>
    {

        public RuleMatchAndTranslate(char charMatch, string generate)
        {
            char _charMatch = charMatch;
            string _generate = "";

            Conditions.Add(new ContainsChar(charMatch));
            Action.Apply = context => {
                int counter = 0;
                foreach (char readedChar in context)
                {
                    if (readedChar == _charMatch) counter++;
                }

                for (int i = 0; i < counter; i++)
                {
                    _generate += generate;
                }
                return _generate;
            };

        }
    }
}
