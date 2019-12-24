using Shouldly;
using System;
using Xunit;

namespace Valit.Tests.Float
{
    public class Float_IsPositive_Tests
    {
        [Fact]
        public void Float_IsPositive_For_Not_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() =>
            {
                ((IValitRule<Model, float>)null)
                    .IsPositive();
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void Float_IsPositive_For_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() =>
            {
                ((IValitRule<Model, float?>)null)
                    .IsPositive();
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }


        [Fact]
        public void Float_IsPositive_Succeeds_When_Given_Value_Is_Postive()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.PositiveValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeTrue();
        }

        [Fact]
        public void Float_IsPositive_Fails_When_Given_Value_Is_Zero()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.ZeroValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        [Fact]
        public void Float_IsPositive_Fails_When_Given_Value_Is_Negative()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NegativeValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        [Fact]
        public void Float_IsPositive_Fails_When_Given_Value_Is_NaN()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NaN, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        [Fact]
        public void Float_IsPositive_Succeeds_When_Given_Value_Is_NullablePostive()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NullablePositiveValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeTrue();
        }

        [Fact]
        public void Float_IsPositive_Fails_When_Given_Value_Is_NullableZero()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NullableZeroValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        [Fact]
        public void Float_IsPositive_Fails_When_Given_Value_Is_NullableNegative()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NullableNegativeValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        [Fact]
        public void Float_IsPositive_Fails_When_Given_Value_Is_Null()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NullValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        [Fact]
        public void Float_IsPositive_Fails_When_Given_Value_Is_NullableNaN()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NullableNaN, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        [Theory]
        [InlineData(0f, float.Epsilon, false)]
        [InlineData(0.000001f, 0.001f, true)]
        [InlineData(0.000001f, 0f, true)]
        [InlineData(-0.000001f, 0.01f, false)]
        public void Float_IsPositive_Return_Proper_Results_For_Given_Epsilon_Value(float value, float epsilon, bool expected)
        {
            IValitResult result = ValitRules<Model>
                                    .Create()
                                    .Ensure(m => value, _ => _.IsPositive(epsilon))
                                    .For(_model)
                                    .Validate();

            result.Succeeded.ShouldBe(expected);
        }

        #region ARRANGE
        public Float_IsPositive_Tests()
        {
            _model = new Model();
        }

        private readonly Model _model;

        class Model
        {
            public float PositiveValue => 10;
            public float ZeroValue => 0;
            public float NegativeValue => -10;
            public float NaN => Single.NaN;
            public float? NullablePositiveValue => 10;
            public float? NullableZeroValue => 0;
            public float? NullableNegativeValue => -10;
            public float? NullValue => null;
            public float? NullableNaN => Single.NaN;
        }
        #endregion
    }
}
