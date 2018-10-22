using System;
using RulePattern.Interfaces;

namespace FooBarQixCore.Conditions
{
    public class DividedBy : Condition<int>
    {

        public readonly uint _divider;

        public DividedBy(uint divider)
        {
            _divider = divider;

            IsSatisfied = (int value) =>
            {
                return (value % _divider == 0);
            };
        }
        /*
        public bool IsSatisfied(string strValue)
        {
            int parsedValue;
            bool parsed = Int32.TryParse(strValue, out parsedValue);
            if (parsed == false) return false;
            return IsSatisfied(parsedValue);
        }
*/

    }
}
