using System;
namespace RulePattern.Interfaces
{
    public interface IResult<TContext, TResult>
    {
        bool IsApplyed { get; set; }
        TResult Value { get; set; }
        IRule<TContext, TResult> Rule { get; set; }
        TContext Context { get; set; }
    }
}
