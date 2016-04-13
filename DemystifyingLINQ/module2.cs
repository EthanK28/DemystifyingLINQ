using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBackGround
{
    public static class MyLinqImplementation
    {   
        // this 를 붙임으로써 extension method라는 것을 C#에게 알려준다
        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            foreach (T item in source) 
                if (predicate(item)) 
                    yield return item;
        }
    }

    class module2
    {
        static void Main(string[] args)
        {
            var sequence = GeneratedNumbers().Select(n => {

                return n.ToString();
            });


            sequence = sequence.Where(s => s.Length < 2);   
            foreach (var item in sequence)
                Console.WriteLine(item);

            var sequence2 = GeneratedNumbers().Where(n => n % 3 == 0);
            foreach (var item in sequence2)
                Console.WriteLine(item);

        }

        private static IEnumerable<string> GeneratedSequence()
        {
            var i = 0;

            while (i++ < 100)
                yield return i.ToString();
        }

        private static IEnumerable<int> GeneratedNumbers()
        {
            var i = 0;

            while (i++ < 100)
                yield return i;
        }
    }
}
