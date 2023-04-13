using System;
using System.Collections.Generic;

public class Conductor
{
    public string NombreCompleto { get; set; }
    public string Cedula { get; set; }
    public string Direccion { get; set; }
    public string TipoLicencia { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public Conductor(string nombreCompleto, string cedula, string direccion, string tipoLicencia, DateTime fechaNacimiento)
    {
        NombreCompleto = nombreCompleto;
        Cedula = cedula;
        Direccion = direccion;
        TipoLicencia = tipoLicencia;
        FechaNacimiento = fechaNacimiento;
    }

    public override string ToString()
    {
        return string.Format("Nombre: {0}, Cedula: {1}, Direccion: {2}, Tipo de Licencia: {3}, Fecha de Nacimiento: {4}", NombreCompleto, Cedula, Direccion, TipoLicencia, FechaNacimiento.ToShortDateString());
    }
}