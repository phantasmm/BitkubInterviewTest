using System;
using System.Collections.Generic;

namespace BitkubQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> mounthDict = new Dictionary<int, string>() {
                { 1, "มกราคม" },
                { 2, "กุมภาพันธ์" },
                { 3, "มีนาคม" },
                { 4, "เมษายน" },
                { 5, "พฤษภาคม" },
                { 6, "มิถุนายน" },
                { 7, "กรกฎาคม" },
                { 8, "สิงหาคม" },
                { 9, "กันยายน" },
                { 10, "ตุลาคม" },
                { 11, "พฤศจิกายน" },
                { 12, "ธันวาคม" }
            };
            string[] dayStr = new string[] { "วันอาทิตย์", "วันจันทร์", "วันอังคาร", "วันพุทธ", "วันพฤหัส", "วันศุกร์", "วันเสาร์" };

            string dateStr = Console.ReadLine();
            string[] dateArray = dateStr.Split('/');

            int dayInWeek = 0,day = 0, mounth = 0, year = 0;
            try
            {
                day = Convert.ToInt32(dateArray[0]);
                mounth = Convert.ToInt32(dateArray[1]);
                year = Convert.ToInt32(dateArray[2]);
                
                dayInWeek = CalDayOfWeek(day, mounth, year);

                Console.WriteLine(dayStr[dayInWeek] + "ที่ " + day + " " + mounthDict[mounth] + " " + (year + 543) );

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static int CalDayOfWeek(int day, int mounth, int year)
        {
            int[] mounthVal = new int[]{ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (var d = 0; d < mounth -1; d++)
            {
                day += mounthVal[d];
            }

            if(mounth > 2 && (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)))
            {
                day++;
            }

            year--;
            var result = (day + year + year/4 - year/100 + year/400) % 7;

            return result;
        }
    }
}
