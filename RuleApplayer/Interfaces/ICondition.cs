using System;
namespace RulePattern.Interfaces
{
    public interface ICondition<TContext>
    {
       
        Func<TContext, bool> IsSatisfied { get; set; }
    }
 
}
