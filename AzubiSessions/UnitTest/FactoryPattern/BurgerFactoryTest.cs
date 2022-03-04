using FactoryPattern;
using FluentAssertions;
using NUnit.Framework;
using System;

namespace UnitTest.FactoryPattern
{
    internal class BurgerFactoryTest
    {
        private BurgerFactory _sut;

        [SetUp]
        public void SetUp()
        {
            _sut = new BurgerFactory();
        }

        [TestCase(230, typeof(VeggieBurger))]
        [TestCase(400, typeof(CheeseBurger))]
        [TestCase(1000, typeof(DoubleWhooper))]
        public void ShouldReturnBurger(int caloriesLeft, Type expected)
        {
            // Act
            var result = _sut.Create(caloriesLeft);

            // Assert
            result.GetType().Should().Be(expected);
        }

        [Test]
        public void ShouldReturnNull()
        {
            // Act
            var result = _sut.Create(120);

            // Assert
            result.Should().BeNull();
        }
    }
}
