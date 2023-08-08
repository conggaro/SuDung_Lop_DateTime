using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            // tạo đối tượng
            // lúc nhập giá trị khởi tạo
            // Năm/Tháng/Ngày
            // Giờ/Phút/Giây
            DateTime dt1 = new DateTime(2023, 12, 31, 23, 59, 25);

            // hiển thị
            Console.WriteLine(dt1);
            Console.WriteLine($"{dt1.Day}/{dt1.Month}/{dt1.Year} {dt1.Hour}:{dt1.Minute}:{dt1.Second}");
        }
    }
}