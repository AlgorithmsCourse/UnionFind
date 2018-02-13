using System;
using System.IO;
using UnionFind;

namespace UnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("data file name for QuickFind:");
            string file = Console.ReadLine();
            string[] RawSet = File.ReadAllLines(file);
            int N = Convert.ToInt32(RawSet[0]);
            string[] ProbSet = new string[RawSet.Length - 1];
            for (int i = 1; i < RawSet.Length; i++)
            {
                ProbSet[i - 1] = RawSet[i];

            }

            QuickFind uf = new QuickFind(N);
            foreach (string word in ProbSet)
            {
                string[] Pair = word.Split(" ");
                int p = Convert.ToInt32(Pair[0]);
                int q = Convert.ToInt32(Pair[1]);
                if (uf.IsConnected(p, q)) continue;
                uf.Union(p, q);
                Console.WriteLine(p + " " + q + " are now connected");
            }

            Console.WriteLine(uf.Count() + " total components");
        }
    }
}
