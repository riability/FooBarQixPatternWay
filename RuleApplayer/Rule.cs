using System;
using System.Collections.Generic;

namespace RulePattern
{
    using Interfaces;
    public class Rule<TContext, TResult> : IRule<TContext, TResult>
    {
        public IList<Condition<TContext>> Conditions { get; set; }
        public Action<TContext, TResult> Action { get; set; }

        public Rule()
        {
            Conditions = new List<Condition<TContext>>();
            Action = new Action<TContext, TResult>();
            Action.Apply = x => { throw new NotImplementedException(); };
        }
    }
}
