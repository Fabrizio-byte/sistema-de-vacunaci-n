using System;
using System.Collections.Generic;

namespace TareaPilas
{
    public class Verificador
    {
        public static bool Validar(string texto)
        {
            Stack<char> pila = new Stack<char>();
            foreach (char c in texto)
            {
                if (c == '(' || c == '[' || c == '{') pila.Push(c);
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (pila.Count == 0) return false;
                    char u = pila.Pop();
                    if (c == ')' && u != '(' || c == ']' && u != '[' || c == '}' && u != '{') return false;
                }
            }
            return pila.Count == 0;
        }
    }
}