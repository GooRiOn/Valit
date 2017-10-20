using Shouldly;
using Xunit;

namespace Valit.Tests.Byte
{
    public class Byte_IsLessThan_Tests
    {
  [Fact]
        public void Byte_IsLessThan_For_Not_Nullable_Values_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, byte>)null)
                    .IsLessThan(1);
            });
            
            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void Byte_IsLessThan_For_Not_Nullable_Value_And_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, byte>)null)
                    .IsLessThan((byte?)1);
            });
            
            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void Byte_IsLessThan_For_Nullable_Value_And_Not_Nullable_Value_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, byte?>)null)
                    .IsLessThan(1);
            });
            
            exception.ShouldBeOfType(typeof(ValitException));
        }

        [Fact]
        public void Byte_IsLessThan_For_Nullable_Values_Throws_When_Null_Rule_Is_Given()
        {
            var exception = Record.Exception(() => {
                ((IValitRule<Model, byte?>)null)
                    .IsLessThan((byte?)1);
            });
            
            exception.ShouldBeOfType(typeof(ValitException));
        }


        [Theory]
        [InlineData(11, true)]
        [InlineData(10, false)]
        [InlineData(9, false)]     
        public void Byte_IsLessThan_Returns_Proper_Results_For_Not_Nullable_Values(byte value,  bool expected)
        {            
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.Value, _=>_
                    .IsLessThan(value))
                .For(_model)
                .Validate();

            Assert.Equal(result.Succeeded, expected);
        }

        [Theory]
        [InlineData((byte) 11, true)]
        [InlineData((byte) 10, false)]
        [InlineData((byte) 9, false)]     
        [InlineData(null, false)]     
        public void Byte_IsLessThan_Returns_Proper_Results_For_Not_Nullable_Value_And_Nullable_Value(byte? value,  bool expected)
        {            
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => m.Value, _=>_
                    .IsLessThan(value))
                .For(_model)
                .Validate();

            Assert.Equal(result.Succeeded, expected);
        }

        [Theory]
        [InlineData(false, 11, true)]
        [InlineData(false, 10, false)]        
        [InlineData(false, 9, false)]     
        [InlineData(true, 11, false)]     
        public void Byte_IsLessThan_Returns_Proper_Results_For_Nullable_Value_And_Not_Nullable_Value(bool useNullValue, byte value,  bool expected)
        {            
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => useNullValue? m.NullValue : m.NullableValue, _=>_
                    .IsLessThan(value))
                .For(_model)
                .Validate();

            Assert.Equal(result.Succeeded, expected);
        }

        [Theory]
        [InlineData(false, (byte) 11, true)] 
        [InlineData(false, (byte) 10, false)]    
        [InlineData(false, (byte) 9, false)]
        [InlineData(false, null, false)]     
        [InlineData(true, (byte) 11, false)]     
        [InlineData(true, null, false)]     
        public void Byte_IsLessThan_Returns_Proper_Results_For_Nullable_Values(bool useNullValue, byte? value,  bool expected)
        {            
            IValitResult result = ValitRules<Model>
                .Create()
                .Ensure(m => useNullValue? m.NullValue : m.NullableValue, _=>_
                    .IsLessThan(value))
                .For(_model)
                .Validate();

            Assert.Equal(result.Succeeded, expected);
        }

#region ARRANGE
        public Byte_IsLessThan_Tests()
        {
            _model = new Model();
        }

        private readonly Model _model;

        class Model
        {
            public byte Value => 10;
            public byte? NullableValue => 10;
            public byte? NullValue => null;
        }
#endregion
    }
    
}