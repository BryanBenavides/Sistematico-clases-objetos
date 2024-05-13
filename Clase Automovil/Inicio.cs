using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Inicio
{
    static void Main(string[] args)
    {
        // Crear instancias de Automovil
        Automovil auto1 = new Automovil("Toyota", "MAN 040524", "Supra", "Blanco", 60, 15);
        Automovil auto2 = new Automovil("Mitsubishi", "GRA 4242452", "Lancer Evo XIII", "Gris", 50, 20);
        Automovil auto3 = new Automovil("Nissan", "MAS 412424", "Skyline GTR 34", "Azul", 70, 12);

        Console.WriteLine("Toyota Supra:");
        auto1.ReabastecerCombustible(50);
        auto1.Conducir(200);
        auto1.ReabastecerCombustible(10);
        auto1.Conducir(500);

        Console.WriteLine("\nMitsubishi Lancer Evo XIII:");
        auto2.ReabastecerCombustible(45);
        auto2.Conducir(300);
        auto2.ReabastecerCombustible(15);
        auto2.Conducir(400);

        Console.WriteLine("\nNissan Skyline GTR 34:");
        auto3.ReabastecerCombustible(60);
        auto3.Conducir(250);
        auto3.ReabastecerCombustible(20);
        auto3.Conducir(600);

        // Comprobar si un vehículo puede viajar una distancia determinada.
        int distancia = 150;
        if (auto1.PuedeConducir(distancia))
        {
            Console.WriteLine($"El Toyota Supra puede conducir {distancia} kilómetros sin quedarse sin combustible.");
        }
        else
        {
            Console.WriteLine($"El Toyota Supra no puede conducir {distancia} kilómetros sin quedarse sin combustible.");
        }

        distancia = 700;
        if (auto2.PuedeConducir(distancia))
        {
            Console.WriteLine($"El Mitsubishi Lancer Evo puede conducir {distancia} kilómetros sin quedarse sin combustible.");
        }
        else
        {
            Console.WriteLine($"El Mitsubishi Lancer Evo no puede conducir {distancia} kilómetros sin quedarse sin combustible.");
        }

        distancia = 400;
        if (auto3.PuedeConducir(distancia))
        {
            Console.WriteLine($"El Nissan Skyline GTR 34 puede conducir {distancia} kilómetros sin quedarse sin combustible.");
        }
        else
        {
            Console.WriteLine($"El Nissan Skyline GTR 34 no puede conducir {distancia} kilómetros sin quedarse sin combustible.");
        }
    }
}
