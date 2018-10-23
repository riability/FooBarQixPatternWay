using System;
namespace RulePattern
{
    using Interfaces;
    public class Condition<TContext> : ICondition<TContext>
    {
        public Func<TContext, bool> IsSatisfied { get; set; }

        public Condition() { IsSatisfied = x => throw new NotImplementedException(); }
    }
}
