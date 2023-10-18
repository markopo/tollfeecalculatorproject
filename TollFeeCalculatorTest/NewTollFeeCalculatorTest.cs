using System;
using System.Collections.Generic;
using TollCalculatorProject.Vehicles;
using Xunit;
using Car = TollCalculatorProject.Vehicles.Car;
using Motorbike = TollCalculatorProject.Vehicles.MotorBike;

namespace TollFeeCalculatorTest
{
    public class NewTollFeeCalculatorTest: IClassFixture<TollCalculatorProject.TollCalculator>
    {
        private readonly TollCalculatorProject.TollCalculator _tollCalculator;

        public NewTollFeeCalculatorTest(TollCalculatorProject.TollCalculator tollCalculator)
        {
            _tollCalculator = tollCalculator;
        }
        
         [Fact]
        public void TestGetTollFee0605()
        {
            var date = TestHelper.GetDate(6, 5);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 8, fee);
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
        public void TestGetTollFeeMotorDiplomat()
        {
            var date = TestHelper.GetDate(8, 25);
            var fee = _tollCalculator.GetTollFee(date, new Diplomat());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeMotorEmergency()
        {
            var date = TestHelper.GetDate(8, 25);
            var fee = _tollCalculator.GetTollFee(date, new Emergency());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeMotorForeign()
        {
            var date = TestHelper.GetDate(8, 25);
            var fee = _tollCalculator.GetTollFee(date, new Foreign());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeMotorMilitary()
        {
            var date = TestHelper.GetDate(8, 25);
            var fee = _tollCalculator.GetTollFee(date, new Military());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeMotorTractor()
        {
            var date = TestHelper.GetDate(8, 25);
            var fee = _tollCalculator.GetTollFee(date, new Tractor());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeSaturday()
        {
            var date = TestHelper.GetSaturday();
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeSunday()
        {
            var date = TestHelper.GetSunday();
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeSpecialFirstOfJanuary()
        {
            var date = new DateTime(2020, 1, 1);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual:fee);
        }

        [Fact]
        public void TestGetTollFeeSpecialLastDaysOfFebruary()
        {
            var date = new DateTime(2020, 3, 28);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeSpecialDayInApril()
        {
            var date = new DateTime(2020, 4, 30);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeOnNationalDay()
        {
            var date = new DateTime(2020, 6, 6);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual:fee);
        }
        
        [Fact]
        public void TestGetTollFeeOnChristmas()
        {
            var date = new DateTime(2020, 12, 24);
            var fee = _tollCalculator.GetTollFee(date, new Car());
            Assert.Equal(expected: 0, actual:fee);
        }


        [Fact]
        public void TestGetMaxFee()
        {
            var dates = new List<DateTime>
            {
                // 13 
                TestHelper.GetDate(6, 5),
                // 18
                TestHelper.GetDate(7, 35),
                // 8
                TestHelper.GetDate(10, 32),
                // 18
                TestHelper.GetDate(16, 15),
                // 8
                TestHelper.GetDate(18, 15)
            };

            // 65?
            var fee = _tollCalculator.GetTollFee(dates.ToArray(), new Car());
            Assert.Equal(expected: 60, actual: fee);

        }

        [Fact]
        public void TestOneFeeUnderOneHour()
        {
            var dates = new List<DateTime>
            {
                // 18
                TestHelper.GetDate(7, 5),
                // 18
                TestHelper.GetDate(7, 35)
            };

            // 36 = 18+18
            var fee = _tollCalculator.GetTollFee(dates.ToArray(), new Car());
            Assert.Equal(expected: 18, actual: fee);
        }
    }
}