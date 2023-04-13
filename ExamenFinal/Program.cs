using System;

namespace GestionInfraccionesTransito
{
    class Program
    {
        static void Main(string[] args)
        {
            // conductor
            string nombre = "Alexa Ramirez";
            string cedula = "402-3055281-8";
            string direccion = "San Isidro #123";
            string tipoLicencia = "Tipo A";
            DateTime fechaNacimiento = new DateTime(2002, 10, 05);

            // vehículo
            string placa = "ABC123";
            string marca = "KIA";
            string modelo = "K5";
            string color = "Blanco";
            int año = 2016;
            string numChasis = "FYTE4H34264Y35W";

            //agente de tránsito
            string codigoEmpleado = "AT234";
            string nombreAgente = "Jose Diaz";
            string direccionAgente = "Los Mina #542";
            DateTime fechaIngreso = new DateTime(2020,10,05);


            // Mostrar información
            Console.WriteLine("Datos del conductor:");
            Console.WriteLine("- Nombre: " + nombre);
            Console.WriteLine("- Cédula: " + cedula);
            Console.WriteLine("- Dirección: " + direccion);
            Console.WriteLine("- Fecha de nacimiento: " + fechaNacimiento.ToString("yyyy/MM/dd"));
            Console.WriteLine("- Tipo de licencia: " + tipoLicencia);
            Console.WriteLine();

            Console.WriteLine("Datos del vehículo:");
            Console.WriteLine("- Placa: " + placa);
            Console.WriteLine("- Marca: " + marca);
            Console.WriteLine("- Modelo: " + modelo);
            Console.WriteLine("- Color: " + color);
            Console.WriteLine("- Año: " + año);
            Console.WriteLine("- Número de chasis: " + numChasis);
            Console.WriteLine();

            Console.WriteLine("Datos del agente de tránsito:");
            Console.WriteLine("- Código de empleado: " + codigoEmpleado);
            Console.WriteLine("- Nombre: " + nombreAgente);
            Console.WriteLine("- Dirección: " + direccionAgente);
            Console.WriteLine("- Fecha de ingreso: " + fechaIngreso.ToString("dd/MM/yyyy"));
            Console.WriteLine();

            
            // Mostrar opciones de infracciones
            Console.WriteLine("Seleccione el tipo de infracción cometida:");
            Console.WriteLine("1. Obstrucción de tránsito - RD$1,800.00");
            Console.WriteLine("2. Pase de semáforo en rojo - RD$5,950.00");
            Console.WriteLine("3. Hablar por el celular - RD$3,750.00");
            Console.WriteLine("4. Conducir sin cinturón - RD$2,560.00");
            Console.WriteLine("5. Licencia vencida - RD$3,890.00");

            // Leer la opción seleccionada y calcular la penalidad correspondiente
            int opcion = int.Parse(Console.ReadLine());
            double penalidad = 0;
            switch (opcion)
            {
                case 1:
                    penalidad = 1800;
                    break;
                case 2:
                    penalidad = 5950;
                    break;
                case 3:
                    penalidad = 3750;
                    break;
                case 4:
                    penalidad = 2560;
                    break;
                case 5:
                    penalidad = 3890;
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    return;
            }

            Console.WriteLine("Ingrese la fecha de la infracción (dd/mm/aaaa):");
            DateTime fechaInfraccion;
            while (!DateTime.TryParse(Console.ReadLine(), out fechaInfraccion))
            {
                Console.WriteLine("Fecha inválida. Ingrese la fecha de la infracción (dd/mm/aaaa):");
            }

            Console.WriteLine("Registro de infracción:");
            Console.WriteLine($"Conductor: {nombre}");
            Console.WriteLine($"Vehículo: {placa}");
            Console.WriteLine("- Tipo de infracción: " + opcion);
            Console.WriteLine("- Penalidad: RD$" + penalidad.ToString("N2"));
            Console.WriteLine($"Fecha de infracción: {fechaInfraccion.ToShortDateString()}");
            Console.WriteLine();

            // presione una tecla para salir
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
