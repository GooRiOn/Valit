using Shouldly;
using Xunit;

namespace Valit.Tests.UInt16
{
    public class UInt16_IsEqualTo_Tests
    {
        [Fact]
        public void UInt16_IsEqualTo_For_Not_Nullable_Values_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, ushort>)null)
                    .IsEqualTo(1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void UInt16_IsEqualTo_For_Not_Nullable_Value_And_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, ushort>)null)
                    .IsEqualTo((ushort?)1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void UInt16_IsEqualTo_For_Nullable_Value_And_Not_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, ushort?>)null)
                    .IsEqualTo(1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void UInt16_IsEqualTo_For_Nullable_Values_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, ushort?>)null)
                    .IsEqualTo((ushort?)1);
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }


        [Theory]
        [InlineData(10, true)]
        [InlineData(9, false)]
        [InlineData(11, false)]
        public void UInt16_IsEqualTo_Returns_Proper_Results_For_Not_Nullable_Values(ushort value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.Value, _=>_
                    .IsEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

        [Theory]
        [InlineData((ushort) 10, true)]
        [InlineData((ushort) 9, false)]
        [InlineData((ushort) 11, false)]
        [InlineData(null, false)]
        public void UInt16_IsEqualTo_Returns_Proper_Results_For_Not_Nullable_Value_And_Nullable_Value(ushort? value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.Value, _=>_
                    .IsEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

        [Theory]
        [InlineData(false, 10, true)]
        [InlineData(false, 9, false)]
        [InlineData(false, 11, false)]
        [InlineData(true, 10, false)]
        public void UInt16_IsEqualTo_Returns_Proper_Results_For_Nullable_Value_And_Not_Nullable_Value(bool useNullValue, ushort value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => useNullValue? m.NullValue : m.NullableValue, _=>_
                    .IsEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

        [Theory]
        [InlineData(false, (ushort) 10, true)]
        [InlineData(false, (ushort) 9, false)]
        [InlineData(false, (ushort) 11, false)]
        [InlineData(false, null, false)]
        [InlineData(true, (ushort) 10, false)]
        [InlineData(true, null, false)]
        public void UInt16_IsEqualTo_Returns_Proper_Results_For_Nullable_Values(bool useNullValue, ushort? value,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => useNullValue? m.NullValue : m.NullableValue, _=>_
                    .IsEqualTo(value))
                .For(_model)
                .Validate();

            result.Succeeded.ShouldBe(expected);
        }

#region ARRANGE
        public UInt16_IsEqualTo_Tests()
        {
            _model = new Model();
        }

        private readonly Model _model;

        class Model
        {
            public ushort Value => 10;
            public ushort? NullableValue => 10;
            public ushort? NullValue => null;
        }
#endregion
    }
}
