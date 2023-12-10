using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aim.task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen dize içeriğini virgül ekleyerek giriniz. Ör:2,10,20,100,11,2,0,8,100");
            var values = Console.ReadLine();

            ArrayFixer(values);
        }

        static List<int> ArrayFixer(string degerler)
        {
            object[] vals = degerler.Split(',');
            List<int> list = new List<int>();
            foreach (object i in vals)
            {
                var value = Convert.ToInt32(i);
                if (value >= 0 && value <= 100)
                    list.Add(Convert.ToInt32(i));
                else
                {

                    Console.WriteLine("Girilen değer 0-100 arasında olmalıdır");
                    return list;
                }
            }

            List<int> newList = list.Distinct().ToList();
            newList.Sort();
            Console.WriteLine(string.Join(",", newList));
            Console.ReadKey();
            return newList;
        }
    }
}
