using System;
using TollCalculatorProject.Vehicles;

namespace TollCalculatorProject
{
    public class TollCalculator
    {
        public int GetTollFee(DateTime[] dates, IVehicle vehicle)
        {
            var totalFee = 0;
            var index = 0;
            foreach (var date in dates)
            {
                
                var nextFee = GetTollFee(date, vehicle);

                if (index > 0)
                {
                    var intervalStart = dates[index - 1];
                    var tempFee = GetTollFee(intervalStart, vehicle);
                    var minutes = date - intervalStart;

                    if (minutes.TotalMinutes <= 60)
                    {
                        if (totalFee > 0) totalFee -= tempFee;
                        if (nextFee >= tempFee) tempFee = nextFee;
                        totalFee += tempFee;
                    }
                    else
                    {
                        totalFee += nextFee;
                    }
                }
                else
                {
                    totalFee += nextFee;
                }

                index += 1;
            }


            if (totalFee > 60)
            {
                totalFee = 60;
            }
            
            
            return totalFee;
        }


        public int GetTollFee(DateTime date, IVehicle vehicle)
        {
            if (IsTollFreeDate(date) || vehicle.IsTollFree) return 0;
            
            var hour = date.Hour;
            var minute = date.Minute;

            return hour switch
            {
                6 when minute >= 0 && minute <= 29 => 8,
                6 when minute >= 30 && minute <= 59 => 13,
                7 when minute >= 0 && minute <= 59 => 18,
                8 when minute >= 0 && minute <= 29 => 13,
                var h when (h >= 8 && h <= 14) && minute >= 30 && minute <= 59 => 8,
                15 when minute >= 0 && minute <= 29 => 13,
                var hh when (hh == 15 || hh == 16) && minute >= 0 && minute <= 59 => 18,
                17 when minute >= 0 && minute <= 59 => 13,
                18 when minute >= 0 && minute <= 29 => 8,
                _ => 0
            };
        }

        private static bool IsTollFreeDate(DateTime date)
        {
            var month = date.Month;
            var day = date.Day;
            
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday) return true;
            
            switch (month)
            {
                case 1 when day == 1:
                case 3 when (day == 28 || day == 29):
                case 4 when (day == 1 || day == 30):
                case 5 when (day == 1 || day == 8 || day == 9):
                case 6 when (day == 5 || day == 6 || day == 21):
                case 7:
                case 11 when day == 1:
                case 12 when (day == 24 || day == 25 || day == 26 || day == 31):
                    return true;
                default:
                    return false;
            }
        }
        
    }
}