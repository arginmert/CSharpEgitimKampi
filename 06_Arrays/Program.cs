using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dizideki Tüm Elemanları Listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 74, 125, 635, 488, 520, 7426, 2365, 1120 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3 == 0) {
            //    Console.WriteLine(numbers[i]);
            //}

            //            int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //            int maxNumber = myArray[0];
            //            for (int i = 0; i < myArray.Length; i++)
            //{
            //                if (myArray[i] > maxNumber)
            //                {
            //                    maxNumber = myArray[i];
            //                }
            //                Console.WriteLine(maxNumber);
            #endregion
            #region Dizi Metotlar
            string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            int index = Array.IndexOf(customers, "merve");
            Console.WriteLine(index);
            int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            Console.WriteLine("Dizini En Büyük Elemanı:" + numbers. Max() + "Dizinin En Küçük Elemanı: " + numbers.Min());
            #endregion
            #region Kullanıcıdan alma
            //for (int i = 0; i< cities. Length; i++)
            //{
            // Console.WriteLine(cities[i]);
            //}
            int[] numberss = { 10, 20, 30, 40, 50 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
            #endregion

            Console.Read();


        }
    }
}
