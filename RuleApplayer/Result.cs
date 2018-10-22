using System;
namespace RulePattern
{
    using Interfaces;

    public class Result<TContext, TResult> : IResult<TContext, TResult>
    {
        public bool IsApplyed { get; set; }
        public TResult Value { get; set; }
        public IRule<TContext, TResult> Rule { get; set; }
        public TContext Context { get; set; }
    }
}
