using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;

            //foreach (int i in numbers)
            //{
            //    total += i; 
            //}
            //Console.WriteLine(total);

            #endregion

            #region Örnek Sınav Sistemi Uygulaması
            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("- ");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("-- -");
           
            //öğrenci isimlerini ve not ortalamarını saklayacak diziler

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];
            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini giriniz");
                studentNames[i] = Console.ReadLine();
                double totalExamResult = 0;
                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($" {studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResult += value;
                    studentExamAvg[i] = totalExamResult / 3;
                }
                    //Sınav ortalamaları
                    for (int i = 0; i < studentCount; i++)
                        Console.WriteLine("- -");
                    Console.WriteLine($" {studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
                //Öğrencilerin ortalaması ve geçip kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı");
                    Console.WriteLine("- -");
                    #endregion
                }
            }
        }
    }

}