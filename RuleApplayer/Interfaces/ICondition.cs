using System;
namespace RulePattern.Interfaces
{
    public interface ICondition<TContext>
    {
       
        Func<TContext, bool> IsSatisfied { get; set; }
    }
    public class Condition<TContext> : ICondition<TContext>
    {
        public Func<TContext, bool> IsSatisfied { get; set; }

        public Condition(){ IsSatisfied = x => throw new NotImplementedException(); }
    }
}
