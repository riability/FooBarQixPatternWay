using System;
using System.Collections.Generic;
namespace RulePattern.Interfaces
{
    public interface IRule<TContext, TResult>
    {
        IList<Condition<TContext>> Conditions { get; set; }
        Action<TContext, TResult> Action { get; set; }
    }
}
