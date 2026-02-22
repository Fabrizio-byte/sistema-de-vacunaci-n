using System;
using System.Collections.Generic;

namespace TareaPilas
{
    // --- CLASE PARA LOS PARÉNTESIS ---
    public class Verificador {
        public static bool Validar(string texto) {
            Stack<char> pila = new Stack<char>();
            foreach (char c in texto) {
                if (c == '(' || c == '[' || c == '{') pila.Push(c);
                else if (c == ')' || c == ']' || c == '}') {
                    if (pila.Count == 0) return false;
                    char u = pila.Pop();
                    if (c == ')' && u != '(' || c == ']' && u != '[' || c == '}' && u != '{') return false;
                }
            }
            return pila.Count == 0;
        }
    }

    // --- CLASE PARA HANOI ---
    public class Hanoi {
        public static void Resolver(int n, Stack<int> ori, Stack<int> des, Stack<int> aux, string o, string d, string a) {
            if (n > 0) {
                Resolver(n - 1, ori, aux, des, o, a, d);
                int disco = ori.Pop();
                des.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {o} a {d}");
                Resolver(n - 1, aux, des, ori, a, d, o);
            }
        }
    }

    // --- PUNTO DE ENTRADA ---
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("=== EJERCICIO 1: PARÉNTESIS ===");
            string formula = "{7 + (8 * 5) - [(9 - 7) + (4 + 1)]}";
            Console.WriteLine(Verificador.Validar(formula) ? "Fórmula balanceada." : "Error de balanceo.");

            Console.WriteLine("\n=== EJERCICIO 2: TORRES DE HANOI ===");
            Stack<int> A = new Stack<int>();
            Stack<int> B = new Stack<int>();
            Stack<int> C = new Stack<int>();
            for (int i = 3; i >= 1; i--) A.Push(i);
            Hanoi.Resolver(3, A, C, B, "A", "C", "B");
            
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}