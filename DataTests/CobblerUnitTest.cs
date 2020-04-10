using System;
using System.ComponentModel;
using ExamTwoCodeQuestions.Data;
using Xunit;

namespace ExamTwoCodeQuestions.DataTests
{
    public class CobblerUnitTests
    {
        [Theory]
        [InlineData(FruitFilling.Cherry)]
        [InlineData(FruitFilling.Blueberry)]
        [InlineData(FruitFilling.Peach)]
        public void ShouldBeAbleToSetFruit(FruitFilling fruit)
        {
            var cobbler = new Cobbler();
            cobbler.Fruit = fruit;
            Assert.Equal(fruit, cobbler.Fruit);
        }

        [Fact]
        public void ShouldBeServedWithIceCreamByDefault()
        {
            var cobbler = new Cobbler();
            Assert.True(cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldBeAbleToSetWithIceCream(bool serveWithIceCream)
        {
            var cobbler = new Cobbler();
            cobbler.WithIceCream = serveWithIceCream;
            Assert.Equal(serveWithIceCream, cobbler.WithIceCream);
        }

        [Theory]
        [InlineData(true, 5.32)]
        [InlineData(false, 4.25)]
        public void PriceShouldReflectIceCream(bool serveWithIceCream, double price)
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = serveWithIceCream
            };
            Assert.Equal(price, cobbler.Price);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var cobbler = new Cobbler();
            Assert.Empty(cobbler.SpecialInstructions);
        }

        [Fact]
        public void SpecialIstructionsShouldSpecifyHoldIceCream()
        {
            var cobbler = new Cobbler()
            {
                WithIceCream = false
            };
            Assert.Collection<string>(cobbler.SpecialInstructions, instruction =>
            {
                Assert.Equal("Hold Ice Cream", instruction);
            });
        }

        [Fact]
        public void ShouldImplementIOrderItemInterface()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<IOrderItem>(cobbler);
        }

        // Test 1: Cobbler should implement the INotifyPrpertyChanged Interface
        [Fact]
        public void CobblerShouldImplementINotifyPropertyChanged()
        {
            var cobbler = new Cobbler();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(cobbler);
        }

        // Test 2: Changing the "WithIceCream" property should invoke PropertyChanged for "WithIceCream"
        [Fact]
        public void ChangingWithIceCreamShouldInvokePropertyChangedForWithIceCream()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "WithIceCream", () => { cobbler.WithIceCream = false; });
        }

        // Test 3: Changing the "WithIceCream" property should invoke PropertyChanged for "SpecialInstructions"
        [Fact]
        public void ChangingWithIceCreamShouldInvokePropertyChangedForSpecialInstructions()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "SpecialInstructions", () => { cobbler.WithIceCream = false; });
        }

        // Test 4: Changing the "Fruit" property should invoke PropertyChanged for "Fruit"
        [Theory]
        [InlineData(FruitFilling.Cherry)]
        [InlineData(FruitFilling.Blueberry)]
        [InlineData(FruitFilling.Peach)]
        public void ChangingFruitShouldInvokePropertyChangedForFruit(FruitFilling fruit)
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Fruit", () => { cobbler.Fruit = fruit; });
        }

        
        // Test 5: Changing the "WithIceCream" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingWithIceCreamShouldInvokePropertyChangedForPrice()
        {
            var cobbler = new Cobbler();
            Assert.PropertyChanged(cobbler, "Price", () => { cobbler.WithIceCream = true; });
        }
    }
}
