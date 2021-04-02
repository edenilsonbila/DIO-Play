using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_Play.Helpers
{
    public static partial class Helpers
    {
        public static void Printy <TSource>(this IEnumerable<TSource> source)
        {
            int index = -1;
            foreach (TSource element in source)
            {
                checked
                {
                    index++;
                }

                Console.WriteLine(element);
            }
        }
    }
}
