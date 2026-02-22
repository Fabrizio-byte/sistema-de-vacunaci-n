using System;
using System.Collections.Generic;

namespace TareaPilas
{
    public class Hanoi
    {
        public static void Resolver(int n, Stack<int> ori, Stack<int> des, Stack<int> aux, string o, string d, string a)
        {
            if (n > 0)
            {
                Resolver(n - 1, ori, aux, des, o, a, d);
                int disco = ori.Pop();
                des.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {o} a {d}");
                Resolver(n - 1, aux, des, ori, a, d, o);
            }
        }
    }
}