using System;
using System.Collections.Generic;


public class Infraccion
{
    public Conductor Conductor { get; set; }
    public Vehiculo Vehiculo { get; set; }
    public AgenteTransito Agente { get; set; }
    public string TipoInfraccion { get; set; }
    public double Penalidad { get; set; }
    public DateTime FechaInfraccion { get; set; }

    public Infraccion(Conductor conductor, Vehiculo vehiculo, AgenteTransito agente, string tipoInfraccion, double penalidad, DateTime fechaInfraccion)
    {
        Conductor = conductor;
        Vehiculo = vehiculo;
        Agente = agente;
        TipoInfraccion = tipoInfraccion;
        Penalidad = penalidad;
        FechaInfraccion = fechaInfraccion;
    }

    public override string ToString()
    {
        return string.Format("Conductor: {0}, Vehículo: {1}, Agente de Tránsito: {2}, Tipo de Infracción: {3}, Penalidad: {4:C}, Fecha de Infracción: {5}", Conductor.NombreCompleto, Vehiculo.Placa, Agente.NombreCompleto, TipoInfraccion, Penalidad, FechaInfraccion.ToShortDateString());
    }
}