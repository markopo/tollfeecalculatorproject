using System;

namespace TollFeeCalculatorTest
{
    public static class TestHelper
    {
        public static DateTime GetDate(int hour, int minute)
        {
            return new DateTime(2023, 10, 12, hour, minute, 0);
        }
        
        public static DateTime GetSaturday()
        {
            return new DateTime(2023, 10, 10,  10, 10, 0);
        }
        
        public static DateTime GetSunday()
        {
            return new DateTime(2023, 10, 11,  10, 10, 0);
        }
    }
}