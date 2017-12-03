using Shouldly;
using Xunit;

namespace Valit.Tests.UInt64
{
    public class UInt64_Required_Tests
    {

        [Fact]
        public void UInt64_Required_For_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, ulong?>)null)
                    .Required();
            });

            exception.ShouldBeOfType(typeof(ValitException));
        }


        [Theory]
        [InlineData(false, true)]
        [InlineData(true, false)]
        public void UInt64_Required_Returns_Proper_Results_For_Nullable_Value(bool useNullValue,  bool expected)
        {
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => useNullValue? m.NullValue : m.NullableValue, _=>_
                    .Required())
                .For(_model)
                .Validate();

            Assert.Equal(result.Succeeded, expected);
        }

#region ARRANGE
        public UInt64_Required_Tests()
        {
            _model = new Model();
        }

        private readonly Model _model;

        class Model
        {
            public ulong Value => 10;
            public ulong ZeroValue => 0;
            public ulong? NullableValue => 10;
            public ulong? NullableZeroValue => 0;
            public ulong? NullValue => null;
        }
#endregion
    }
}
