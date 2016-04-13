using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemystifyingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            

            var i = 0;
            var sequence = GeneratedStrings(() => i++.ToString());
            i = 50;
            foreach (var item in sequence.Take(110))
                Console.WriteLine(item);
            
            var iterator = sequence.GetEnumerator();
            
            //for (int i = 0; i < 1000; i++)
            //{
            //    if (iterator.MoveNext())
            //        Console.WriteLine(iterator.Current);
            //    else
            //        break;
            //}





            
            
        }


        private static IEnumerable<T> GeneratedStrings<T>(Func<T> itemGenerated)
        {

            var i = 0;
            while (i++ < 100)
                yield return itemGenerated();

        }
    }
}
