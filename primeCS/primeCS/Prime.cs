using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeCS
{
    public static class Prime
    {
        private static IEnumerable<int> GetRange(int from, int to)
        {
            for (int i = from; i <= to; i += 2)
                yield return i;

        }

        public static List<int> GetPriemsBelowParallel(int tot)
        {
            //geoptimaliseert om alle priemgetallen onder maximaal 5 764 801 te vinden.
            // namelijk 5 764 801 == 7^2^2^2
            List<int> PriemList = new List<int>(new int[] { 2, 3, 5, 7 });
            object priemLock = new object();
            do
            {
                PriemList.Sort();
                int[] IteratePriems = PriemList.ToArray();
                //stop
                int stop = IteratePriems.Last() * IteratePriems.Last();
                if (stop > tot)
                    stop = tot;



                Parallel.ForEach(GetRange(IteratePriems.Last() + 2, stop), (i) =>
                {
                    bool isPriem = true;
                    foreach (int priem in IteratePriems)
                    {
                        if (i % priem == 0)
                        {
                            isPriem = false;
                            break;
                        }
                    }
                    if (isPriem)
                    {
                        lock (priemLock)
                        {
                            PriemList.Add(i);
                        }
                    }
                }
                );

                if (stop == tot)
                    break;
            }
            while (true);

            return PriemList;
        }
    }
}

