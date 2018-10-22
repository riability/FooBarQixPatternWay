using System;
namespace RulePattern.Interfaces
{

    public interface IAction<TContext, TResult>
    {
        //TResult Apply(TContext context);
        Func<TContext, TResult> Apply { get; set; }
    }
    public class Action<TContext, TResult> : IAction<TContext, TResult>
    {
        public Func<TContext, TResult> Apply { get; set; }
        public Action() { Apply = x => { throw new NotImplementedException(); }; }
    }
}
