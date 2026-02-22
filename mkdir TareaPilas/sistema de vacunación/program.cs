using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // 1. Generar Universo de 500 ciudadanos
        HashSet<string> universo = new HashSet<string>(
            Enumerable.Range(1, 500).Select(i => $"Ciudadano {i}")
        );

        // 2. Generar vacunados Pfizer (75 ciudadanos, ej. del 1 al 75)
        HashSet<string> pfizer = new HashSet<string>(
            Enumerable.Range(1, 75).Select(i => $"Ciudadano {i}")
        );

        // 3. Generar vacunados AstraZeneca (75 ciudadanos, ej. del 50 al 124)
        // Esto crea una intersección deliberada (del 50 al 75) para probar el sistema
        HashSet<string> astrazeneca = new HashSet<string>(
            Enumerable.Range(50, 75).Select(i => $"Ciudadano {i}")
        );

        // --- OPERACIONES DE CONJUNTOS ---

        // Ciudadanos con ambas vacunas (Intersección)
        HashSet<string> ambasDosis = new HashSet<string>(pfizer);
        ambasDosis.IntersectWith(astrazeneca);

        // Ciudadanos solo con Pfizer (Diferencia)
        HashSet<string> soloPfizer = new HashSet<string>(pfizer);
        soloPfizer.ExceptWith(astrazeneca);

        // Ciudadanos solo con AstraZeneca (Diferencia)
        HashSet<string> soloAstra = new HashSet<string>(astrazeneca);
        soloAstra.ExceptWith(pfizer);

        // Ciudadanos no vacunados (Universo - Unión de vacunados)
        HashSet<string> vacunados = new HashSet<string>(pfizer);
        vacunados.UnionWith(astrazeneca);
        
        HashSet<string> noVacunados = new HashSet<string>(universo);
        noVacunados.ExceptWith(vacunados);

        // Mostrar Resultados
        Console.WriteLine($"Total No Vacunados: {noVacunados.Count}");
        Console.WriteLine($"Total Ambas Dosis: {ambasDosis.Count}");
        Console.WriteLine($"Total Solo Pfizer: {soloPfizer.Count}");
        Console.WriteLine($"Total Solo AstraZeneca: {soloAstra.Count}");
    }
}
