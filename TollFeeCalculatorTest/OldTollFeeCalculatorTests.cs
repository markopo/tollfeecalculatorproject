using System;
using System.Collections.Generic;
using TollFeeCalculator;
using Xunit;

namespace TollFeeCalculatorTest
{
    public class OldTollFeeCalculatorTests: IClassFixture<TollCalculator>
    {
        private readonly TollCalculator _tollCalculator;

        public OldTollFeeCalculatorTests(TollCalculator tollCalculator)
        {
            _tollCalculator = tollCalculator;
        }
        
        [Fact]
        public void TestGetTollFee0605()
        {
            var date = TestHelper.GetDate( 6, 5);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 8, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee0635()
        {
            var date = TestHelper.GetDate(6, 35);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 13, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee0735()
        {
            var date = TestHelper.GetDate(7, 35);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 18, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee0815()
        {
            var date = TestHelper.GetDate(8, 15);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 13, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee1032()
        {
            var date = TestHelper.GetDate(10, 32);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 8, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee1515()
        {
            var date = TestHelper.GetDate(15, 15);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 13, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee1615()
        {
            var date = TestHelper.GetDate(16, 15);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 18, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee1715()
        {
            var date = TestHelper.GetDate(17, 15);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 13, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee1815()
        {
            var date = TestHelper.GetDate(18, 15);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 8, actual: fee);
        }
        
        [Fact]
        public void TestGetTollFee1930()
        {
            var date = TestHelper.GetDate(19, 30);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual: fee);
        }

        [Fact]
        public void TestGetTollFeeMotorBike()
        {
            var date = TestHelper.GetDate(8, 25);
            var fee = _tollCalculator.GetTollFee(date, new Motorbike());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeMotorSaturday()
        {
            var date = TestHelper.GetSaturday();
            var fee = _tollCalculator.GetTollFee(date, new Motorbike());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        
        
        
    }
}