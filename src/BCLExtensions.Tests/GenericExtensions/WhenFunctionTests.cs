﻿using System;
using Xunit;

namespace BCLExtensions.Tests.GenericExtensions
{
    public class WhenFunctionTests
    {
        private string _newValue = "New World";

        [Fact]
        public void TruePredicateCallsFunction()
        {
            var executed = TestFunctionExecution(AlwaysTrue);

            Assert.True(executed);
        }

        [Fact]
        public void TruePredicateReturnsFunctionResult()
        {
            string input = "Hello World";

            Func<string, string> function = ReturnsNewValue;
            var result = input.When(AlwaysTrue, function);

            Assert.Equal(_newValue, result);
        }

        [Fact]
        public void FalsePredicateDoesNotCallFunction()
        {
            var executed = TestFunctionExecution(AlwaysFalse);

            Assert.False(executed);
        }

        [Fact]
        public void FalsePredicateReturnsInputValue()
        {
            string input = "Hello World";

            Func<string,string> function = ReturnsNewValue;
            var result = input.When(AlwaysFalse, function);

            Assert.Equal(input, result);
        }

        private bool TestFunctionExecution(Func<string, bool> predicate)
        {
            var executed = false;
            string input = "Hello World";

            input.When(predicate, s =>
            {
                executed = true;
                return s;
            });
            return executed;
        }

        private string ReturnsNewValue(string s)
        {
            return _newValue;
        }

        private bool AlwaysFalse(string s)
        {
            return false;
        }

        private bool AlwaysTrue(string s)
        {
            return true;
        }

    }
}
