using System;

class Automovil
{
    public string Marca { get; set; }
    public string Placa { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }
    public double CapacidadTanqueCombustible { get; set; }
    public double NivelCombustible { get; set; }
    public double RendimientoCombustible { get; set; }

    // Metodo constructor
    public Automovil(string marca, string placa, string modelo, string color, double capacidadTanque, double rendimientoCombustible)
    {
        Marca = marca;
        Placa = placa;
        Modelo = modelo;
        Color = color;
        CapacidadTanqueCombustible = capacidadTanque;
        RendimientoCombustible = rendimientoCombustible;
        NivelCombustible = 0; 
    }

    // Metodo conducir
    public void Conducir(int distancia)
    {
        double combustibleNecesario = distancia / RendimientoCombustible;

        if (combustibleNecesario > NivelCombustible)
        {
            Console.WriteLine("No hay suficiente combustible para conducir esa distancia.");
        }
        else
        {
            Console.WriteLine($"Conduciendo {distancia} kilómetros...");
            NivelCombustible -= combustibleNecesario;
            Console.WriteLine($"Nivel de combustible restante: {NivelCombustible} galones");
        }
    }

    // Metodo ReabastecerCombustible
    public void ReabastecerCombustible(double cantidad)
    {
        if (NivelCombustible + cantidad <= CapacidadTanqueCombustible)
        {
            NivelCombustible += cantidad;
            Console.WriteLine($"Se ha reabastecido {cantidad} galones de combustible.");
            Console.WriteLine($"Nivel de combustible actual: {NivelCombustible} galones");
        }
        else
        {
            Console.WriteLine("No se puede reabastecer, excede la capacidad máxima del tanque.");
        }
    }

    // Metodo PuedeConducir
    public bool PuedeConducir(int distancia)
    {
        double combustibleNecesario = distancia / RendimientoCombustible;

        return combustibleNecesario <= NivelCombustible;
    }
}
