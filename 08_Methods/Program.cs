using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            // Console.WriteLine(z);
            //}
            //Sum();
            #endregion
            #region Geriye değer döndürmeyen paramaetreli Metotlar
            //void WriteMethod(string customerName)
            //{
            // Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");
            void CustomerCard(string name, string surName)
            {
                Console.WriteLine("Müşteri" + name + " " + surName);
            }
                
                CustomerCard("Mehmet", "Yıldız");
                CustomerCard("Ayşegül", "Kaya");
                        #endregion
        }
    }
}
