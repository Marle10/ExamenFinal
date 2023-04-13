using System;
using System.Collections.Generic;

public class AgenteTransito
{
    public string CodigoEmpleado { get; set; }
    public string NombreCompleto { get; set; }
    public string Direccion { get; set; }
    public DateTime FechaIngreso { get; set; }

    public AgenteTransito(string codigoEmpleado, string nombreCompleto, string direccion, DateTime fechaIngreso)
    {
        CodigoEmpleado = codigoEmpleado;
        NombreCompleto = nombreCompleto;
        Direccion = direccion;
        FechaIngreso = fechaIngreso;
    }

    public override string ToString()
    {
        return string.Format("Código de Empleado: {0}, Nombre Completo: {1}, Dirección: {2}, Fecha de Ingreso: {3}", CodigoEmpleado, NombreCompleto, Direccion, FechaIngreso.ToShortDateString());
    }
}
