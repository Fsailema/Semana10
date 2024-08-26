
using System;
using System.Collections.Generic;
using System.Linq;

class ProgramaVacunacion
{
    static void Main()
    {
        // Conjunto ficticio de 500 ciudadanos
        var ciudadanos = new HashSet<int>(Enumerable.Range(1, 500));

        // Conjunto ficticio de 75 ciudadanos vacunados con Pfizer
        var vacunadosPfizer = new HashSet<int>(Enumerable.Range(1, 75));

        // Conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
        var vacunadosAstrazeneca = new HashSet<int>(Enumerable.Range(76, 75));

        // Listado de ciudadanos que han recibido las dos vacunas
        var vacunadosDosVacunas = new HashSet<int>(vacunadosPfizer);
        vacunadosDosVacunas.IntersectWith(vacunadosAstrazeneca);

        // Listado de ciudadanos que no se han vacunado
        var noVacunados = new HashSet<int>(ciudadanos);
        noVacunados.ExceptWith(vacunadosPfizer);
        noVacunados.ExceptWith(vacunadosAstrazeneca);

        // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
        var soloPfizer = new HashSet<int>(vacunadosPfizer);
        soloPfizer.ExceptWith(vacunadosAstrazeneca);

        // Listado de ciudadanos que solamente han recibido la vacuna de AstraZeneca
        var soloAstrazeneca = new HashSet<int>(vacunadosAstrazeneca);
        soloAstrazeneca.ExceptWith(vacunadosPfizer);

        // Mostrar los resultados
        Console.WriteLine("Ciudadanos no vacunados: " + noVacunados.Count);
        Console.WriteLine("Ciudadanos vacunados con dos vacunas: " + vacunadosDosVacunas.Count);
        Console.WriteLine("Ciudadanos solo con Pfizer: " + soloPfizer.Count);
        Console.WriteLine("Ciudadanos solo con AstraZeneca: " + soloAstrazeneca.Count);
    }
}