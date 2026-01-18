using System;

namespace MiProywcto
{
    [cite_start]// Clase que define la estructura de un Nodo [cite: 3]
    public class Nodo 
    {
        public int Dato;
        public Nodo Siguiente;

        public Nodo(int dato) 
        {
            Dato = dato;
            Siguiente = null;
        }
    }

    // Clase para manejar la Lista Enlazada
    public class ListaEnlazada 
    {
        public Nodo Cabeza;

        // Método para insertar datos al final de la lista
        public void Agregar(int dato) 
        {
            Nodo nuevo = new Nodo(dato);
            if (Cabeza == null) 
            {
                Cabeza = nuevo;
            } 
            else 
            {
                Nodo actual = Cabeza;
                while (actual.Siguiente != null) 
                {
                    actual = actual.Siguiente;
                }
                actual.Siguiente = nuevo;
            }
        }

        [cite_start]// 1. Función que calcule el número de elementos de una lista [cite: 2, 3]
        public int ContarElementos() 
        {
            int contador = 0;
            Nodo actual = Cabeza;
            while (actual != null) 
            {
                contador++;
                actual = actual.Siguiente;
            }
            return contador;
        }

        [cite_start]// 3. Método de búsqueda: retorna el número de veces que se encuentra el dato [cite: 6, 9]
        public void BuscarDato(int valor) 
        {
            int vecesEncontrado = 0;
            Nodo actual = Cabeza;
            while (actual != null) 
            {
                if (actual.Dato == valor) 
                {
                    vecesEncontrado++;
                }
                actual = actual.Siguiente;
            }

            if (vecesEncontrado > 0) 
            {
                Console.WriteLine($"El dato {valor} se encontró {vecesEncontrado} veces.");
            } 
            else 
            {
                [cite_start]// Mensaje obligatorio si el dato no fue encontrado [cite: 7]
                Console.WriteLine($"El dato {valor} no fue encontrado.");
            }
        }
    }

    class Program 
    {
        static void Main() 
        {
            ListaEnlazada miLista = new ListaEnlazada();
            
            // Cargando datos de prueba
            miLista.Agregar(10);
            miLista.Agregar(25);
            miLista.Agregar(10);
            miLista.Agregar(40);

            Console.WriteLine("--- EJERCICIOS DE LISTAS ENLAZADAS ---");
            
            [cite_start]// Ejecución del Ejercicio 1 [cite: 2]
            int total = miLista.ContarElementos();
            Console.WriteLine($"Número total de elementos: {total}");

            [cite_start]// Ejecución del Ejercicio 3 [cite: 6]
            Console.WriteLine("Buscando el número 10...");
            miLista.BuscarDato(10);

            Console.WriteLine("Buscando el número 99...");
            miLista.BuscarDato(99);
        }
    }
}