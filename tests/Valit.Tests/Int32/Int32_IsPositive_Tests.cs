using Shouldly;
using Xunit;

namespace Valit.Tests.Int32
{
    public class Int32_IsPositive_Tests
    {
        [Fact]
        public void Int32_IsPositive_For_Not_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() =>
            {
                ((IValitRule<Model, int>)null)
                    .IsPositive();
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void Int32_IsPositive_For_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() =>
            {
                ((IValitRule<Model, int?>)null)
                    .IsPositive();
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }


        [Fact]
        public void Int32_IsPositive_Succeeds_When_Given_Value_Is_Postive()
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
        public void Int32_IsPositive_Fails_When_Given_Value_Is_Zero()
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
        public void Int32_IsPositive_Fails_When_Given_Value_Is_Negative()
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
        public void Int32_IsPositive_Succeeds_When_Given_Value_Is_NullablePostive()
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
        public void Int32_IsPositive_Fails_When_Given_Value_Is_NullableZero()
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
        public void Int32_IsPositive_Fails_When_Given_Value_Is_NullableNegative()
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
        public void Int32_IsPositive_Fails_When_Given_Value_Is_Null()
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.NullValue, _ => _
                    .IsPositive())
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBeFalse();
        }

        #region ARRANGE
        public Int32_IsPositive_Tests()
        {
            _model = new Model();
        }

        private readonly Model _model;

        class Model
        {
            public int PositiveValue => 10;
            public int ZeroValue => 0;
            public int NegativeValue => -10;
            public int? NullablePositiveValue => 10;
            public int? NullableZeroValue => 0;
            public int? NullableNegativeValue => -10;
            public int? NullValue => null;
        }
        #endregion
    }
}
