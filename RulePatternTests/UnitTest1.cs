using System;
using Xunit;
using RulePattern;
using RulePattern.Interfaces;

namespace RulePatternTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestRuleApplayer()
        {
            /// Arrange
            RuleApplyer<int, string> ruleApplyer = new RuleApplyer<int, string>();
            Condition<int> condition = new Condition<int> {IsSatisfied = (int value) => (value % 5 == 0)};
            int theInput = 15;

            Rule<int,string> rule = new Rule<int,string>();
            rule.Conditions.Add(condition);
            rule.Action.Apply = context => { return "Bar"; };

            ruleApplyer.Rules.Add(rule);

            /// Act
            var results = ruleApplyer.ApplyRules(theInput);

            /// Assert
            Assert.Equal(1, results.Count);
            Assert.Matches("Bar", results[0].Value);
        }


    }
}
