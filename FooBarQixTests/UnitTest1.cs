using System;
using Xunit;
using RulePattern;
using FooBarQixCore.Rules;

namespace FooBarQixTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestDevidedAndGenerate()
        {
            /// Arrange

          
            RuleApplyer<int, string> divideApplyer = new RuleApplyer<int, string>();
            divideApplyer.Rules.Add(new RuleDividedByAndGenerate(3, "Foo"));
            divideApplyer.Rules.Add(new RuleDividedByAndGenerate(5, "Bar"));
            divideApplyer.Rules.Add(new RuleDividedByAndGenerate(7, "Qix"));
            int theInput = 15;

            /// Act

            var results = divideApplyer.ApplyRules(theInput);

            /// Assert
            string result = "";
            foreach (var res in results) result += res.Value;
            Assert.Matches("FooBar", result);


        }

        [Fact]
        public void TestMatchAndReplace()
        {
            /// Arrange

            RuleApplyer<string, string> replaceApplyer = new RuleApplyer<string, string>();
            replaceApplyer.Rules.Add(new RuleMatchAndReplace('0', "*"));
            string theInput = "101";

            /// Act

            var results = replaceApplyer.ApplyRules(theInput);

            /// Assert
            Assert.Matches("1*1", results[0].Value);


        }

        [Fact]
        public void TestMatchAndTranslate()
        {
            /// Arrange
            RuleApplyer<string, string> translateApplyer = new RuleApplyer<string, string>();
            translateApplyer.Rules.Add(new RuleMatchAndTranslate('3', "Foo"));
            translateApplyer.Rules.Add(new RuleMatchAndTranslate('5', "Bar"));
            translateApplyer.Rules.Add(new RuleMatchAndTranslate('7', "Qix"));
            string theInput = "357";



            /// Act
            var results = translateApplyer.ApplyRules(theInput);


            /// Assert
            string result = "";
            foreach (var res in results) result += res.Value;
            Assert.Matches("FooBarQix", result);


        }
    }
}
