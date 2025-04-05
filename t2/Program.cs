using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day1, month1, year1, day2, month2, year2, totalDays1, totalDays2, daysDifference;
            // دریافت تاریخ تولد نفر اول
            Console.WriteLine(" Please enter the first person's date of birth. ");
            Console.WriteLine("day : ");
            day1 = int.Parse(Console.ReadLine());
            Console.WriteLine("month : ");
            month1 = int.Parse(Console.ReadLine());
            Console.WriteLine("year : ");
            year1 = int.Parse(Console.ReadLine());

            // دریافت تاریخ تولد نفر دوم
            Console.WriteLine(" Please enter the second person's date of birth. ");
            Console.WriteLine("day : ");
            day2 = int.Parse(Console.ReadLine());
            Console.WriteLine("month : ");
            month2 =int.Parse(Console.ReadLine());
            Console.WriteLine("year : ");
            year2 = int.Parse(Console.ReadLine());

            // تبدیل تاریخ‌ها به تعداد روزها از ابتدا
            totalDays1 = (year1 * 365) + ((month1 - 1) * 30) + day1; // فرض 30 روز برای هر ماه
            totalDays2 = (year2 * 365) + ((month2 - 1) * 30) + day2;

            // محاسبه اختلاف سنی
            daysDifference = Math.Abs(totalDays1 - totalDays2);

            // نمایش نتیجه

            Console.WriteLine($" The age difference between these two people is {daysDifference} days. ");
            Console.ReadKey();

        }
    }
}
