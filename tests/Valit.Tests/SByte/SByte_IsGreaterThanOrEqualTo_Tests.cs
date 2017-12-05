using Shouldly;
using Xunit;

namespace Valit.Tests.SByte
{
    public class SByte_IsGreaterThanOrEqualTo_Tests
    {
        [Fact]
        public void SByte_IsGreaterThanOrEqualTo_For_Not_Nullable_Values_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, sbyte>)null)
                    .IsGreaterThanOrEqualTo(1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void SByte_IsGreaterThanOrEqualTo_For_Not_Nullable_Value_And_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, sbyte>)null)
                    .IsGreaterThanOrEqualTo((sbyte?)1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void SByte_IsGreaterThanOrEqualTo_For_Nullable_Value_And_Not_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, sbyte?>)null)
                    .IsGreaterThanOrEqualTo(1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void SByte_IsGreaterThanOrEqualTo_For_Nullable_Values_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, sbyte?>)null)
                    .IsGreaterThanOrEqualTo((sbyte?)1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }


        [Theory]
        [InlineData(9, true)]
        [InlineData(10, true)]
        [InlineData(11, false)]
        public void SByte_IsGreaterThanOrEqualTo_Returns_Proper_Results_For_Not_Nullable_Values(sbyte value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.Value, _=>_
                    .IsGreaterThanOrEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

        [Theory]
        [InlineData((sbyte) 9, true)]
        [InlineData((sbyte) 10, true)]
        [InlineData((sbyte) 11, false)]
        [InlineData(null, false)]
        public void SByte_IsGreaterThanOrEqualTo_Returns_Proper_Results_For_Not_Nullable_Value_And_Nullable_Value(sbyte? value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.Value, _=>_
                    .IsGreaterThanOrEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

        [Theory]
        [InlineData(false, 9, true)]
        [InlineData(false, 10, true)]
        [InlineData(false, 11, false)]
        [InlineData(true, 9, false)]
        public void SByte_IsGreaterThanOrEqualTo_Returns_Proper_Results_For_Nullable_Value_And_Not_Nullable_Value(bool useNullValue, sbyte value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => useNullValue? m.NullValue : m.NullableValue, _=>_
                    .IsGreaterThanOrEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

        [Theory]
        [InlineData(false, (sbyte) 9, true)]
        [InlineData(false, (sbyte) 10, true)]
        [InlineData(false, (sbyte) 11, false)]
        [InlineData(false, null, false)]
        [InlineData(true, (sbyte) 9, false)]
        [InlineData(true, null, false)]
        public void SByte_IsGreaterThanOrEqualTo_Returns_Proper_Results_For_Nullable_Values(bool useNullValue, sbyte? value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => useNullValue? m.NullValue : m.NullableValue, _=>_
                    .IsGreaterThanOrEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

#region ARRANGE
        public SByte_IsGreaterThanOrEqualTo_Tests()
        {
            _model = new Model();
        }

        private readonly Model _model;

        class Model
        {
            public sbyte Value => 10;
            public sbyte? NullableValue => 10;
            public sbyte? NullValue => null;
        }
#endregion
    }
}
