using SupermarketKata.Services;
using System;
using Xunit;

namespace SupermarketKata.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void WhenBAB_Returns95()
        {
            // Arrange
            string scannedItems = "B A B";

            // Act
            var checkout = new Checkout();
            checkout.Scan(scannedItems);
            var total = checkout.GetTotalPrice();

            // Assert
            Assert.Equal(95, total);
        }

        [Fact]
        public void When3A_Returns130()
        {   
            var checkout = new Checkout();
            checkout.Scan("A");
            checkout.Scan("A");
            checkout.Scan("A");

            var total = checkout.GetTotalPrice();

            Assert.Equal(130, total);
        }

        [Fact]
        public void WhenItemsAreNotInStock_Returns0()
        {
            var checkout = new Checkout();
            checkout.Scan("F, E");

            var total = checkout.GetTotalPrice();

            Assert.Equal(0, total);
        }


        [Fact]
        public void WhenItemsAreCommaSeparated()
        {
            var checkout = new Checkout();
            checkout.Scan("A, B");

            var total = checkout.GetTotalPrice();

            Assert.Equal(80, total);
        }

        [Fact]
        public void WhenItemsAreSeparatedWithMoreThanOneSpace()
        {
            var checkout = new Checkout();
            checkout.Scan("A  E");

            var total = checkout.GetTotalPrice();

            Assert.Equal(50, total);
        }        
    }
}
