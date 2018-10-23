using System;
namespace RulePattern
{
    using Interfaces;
    public class Action<TContext, TResult> : IAction<TContext, TResult>
    {
        public Func<TContext, TResult> Apply { get; set; }
        public Action() { Apply = x => { throw new NotImplementedException(); }; }
    }
}
