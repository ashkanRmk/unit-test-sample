using System;
using Xunit;

namespace Account.Test
{
    public class TestAccount
    {
        private Account _account;

        [Fact]
        public void Check_Create_Account_And_Increase_Cash()
        {
            // Arrange
            _account = new Account("Ashkan", 8000);

            // Act
            _account.IncreaseCash(500);

            // Assert
            Assert.Equal(8500, _account.Cash);
            Assert.Equal("Ashkan", _account.Customer);
            Assert.True(_account.IsActive);
        }

        [Fact]
        public void Check_Decrease_Cash()
        {
            _account = new Account("Ashkan", 8000);

            _account.DecreaseCash(1000);

            Assert.Equal(7000, _account.Cash);
        }

        [Fact]
        public void Check_Actiavtion_Account()
        {
            _account = new Account("Amir", 8000);

            Assert.True(_account.IsActive);

            _account.ChangeActivation();
            Assert.False(_account.IsActive);
        }

        [Fact]
        public void Check_Cash_Validation()
        {
            _account = new Account("Amir", 8000);

            Assert.Throws<Exception>(() => _account.IncreaseCash(-500));
            Exception ex = Assert.Throws<Exception>(() => _account.IncreaseCash(-500));
            Assert.Equal("مبلغ زیر صفر", ex.Message);

            Assert.Throws<ArgumentOutOfRangeException>(() => _account.DecreaseCash(100000));
        }


        //Simple Example of theory
        bool IsOdd(int value)
        {
            return value % 2 == 1;
        }

        [Theory]
        [InlineData(7)]
        [InlineData(5)]
        [InlineData(3)]
        public void Check_IsOdd(int value)
        {
            Assert.True(IsOdd(value));
        }
    }
}
