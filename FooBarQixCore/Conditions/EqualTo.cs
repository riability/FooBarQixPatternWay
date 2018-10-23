using System;
using RulePattern;
using RulePattern.Interfaces;
namespace FooBarQixCore.Conditions
{
    public class EqualTo : Condition<int>
    {
        public readonly int _rhs;

        public EqualTo(int rhs)
        {
            _rhs = rhs;

            IsSatisfied = (int value) =>
            {
                return (value == _rhs);
            };

        }

    }
}
