using System;
using System.Collections.Generic;


public class Vehiculo
{
    public string Placa { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Color { get; set; }
    public int Año { get; set; }
    public string NumeroChasis { get; set; }

    public Vehiculo(string placa, string marca, string modelo, string color, int anio, string numeroChasis)
    {
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Color = color;
        Año = anio;
        NumeroChasis = numeroChasis;
    }

    public override string ToString()
    {
        return string.Format("Placa: {0}, Marca: {1}, Modelo: {2}, Color: {3}, Año: {4}, Número de Chasis: {5}", Placa, Marca, Modelo, Color, Año, NumeroChasis);
    }
}