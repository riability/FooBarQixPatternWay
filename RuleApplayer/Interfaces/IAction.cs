using System;
namespace RulePattern.Interfaces
{

    public interface IAction<TContext, TResult>
    {

        Func<TContext, TResult> Apply { get; set; }
    }

}
