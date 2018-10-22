using System;
using System.Collections.Generic;
using System.Linq;
namespace RulePattern
{
    using Interfaces;

    public class RuleApplyer<TContext, TResult>
    {
        public IList<IRule<TContext, TResult>> Rules { get; set; }
        // public IList<IResult<TContext,TResult>> Results { get; set; }


        public RuleApplyer()
        {
            Rules = new List<IRule<TContext, TResult>>();
        }
        public bool SomesConditionsAreSatified(TContext context)
        {
            foreach (var rule in Rules)
            {
                if (rule.Conditions.All(x => x.IsSatisfied(context))) return true;
            }
            return false;
        }

        public virtual IList<IResult<TContext, TResult>> ApplyRules(TContext context)
        {
            IList<IResult<TContext, TResult>> Results = new List<IResult<TContext, TResult>>();

            foreach (var rule in Rules)
            {
                if (rule.Conditions.All(x => x.IsSatisfied(context)))
                {
                    IResult<TContext, TResult> result = new Result<TContext, TResult>();

                    result.IsApplyed = true;
                    result.Value = rule.Action.Apply(context);
                    result.Rule = rule;
                    result.Context = context;
                    Results.Add(result);
                }
            }
            return Results;
        }

    }
}
