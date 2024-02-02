using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("**********Bienvenidos al sistema de registro de la empresa HIKARI S.A*************");
        Console.WriteLine("Ingrese la cantidad de aumentos salariales a registrar:");
        int cantidadAumentos = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidadAumentos; i++)
        {
            Console.WriteLine($"\nRegistro de aumento salarial #{i + 1}:");

            Console.Write("Número de cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Nombre del empleado: ");
            string nombreEmpleado = Console.ReadLine();

            Console.Write("Tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            int tipoEmpleado = int.Parse(Console.ReadLine());

            while (tipoEmpleado > 3 || tipoEmpleado < 1 )
            {
                Console.Write("ERROR, escoja un Tipo de empleado disponible (1-Operario, 2-Técnico, 3-Profesional): ");
                tipoEmpleado = int.Parse(Console.ReadLine());
            }
            Console.Write("Cantidad de horas trabajadas: ");
            double horasTrabajadas = double.Parse(Console.ReadLine());

            Console.Write("Precio por hora: ");
            double precioHora = double.Parse(Console.ReadLine());

            double salarioOrdinario = horasTrabajadas * precioHora;

            double aumento = 0;

            switch (tipoEmpleado)
            {
                case 1: // Operario
                    aumento = 0.15 * salarioOrdinario;
                    break;
                case 2: // Técnico
                    aumento = 0.10 * salarioOrdinario;
                    break;
                case 3: // Profesional
                    aumento = 0.05 * salarioOrdinario;
                    break; 
            }

            double salarioBruto = salarioOrdinario + aumento;
            double deduccionCCSS = 0.0917 * salarioBruto;
            double salarioNeto = salarioBruto - deduccionCCSS;

            // Mostrar información
            Console.WriteLine("\nInformación del empleado:");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre del empleado: {nombreEmpleado}");
            Console.WriteLine($"Tipo de empleado: {tipoEmpleado}");
            Console.WriteLine($"Salario por hora: {precioHora:C}");
            Console.WriteLine($"Cantidad de horas trabajadas: {horasTrabajadas}");
            Console.WriteLine($"Salario ordinario: {salarioOrdinario:C}");
            Console.WriteLine($"Aumento: {aumento:C}");
            Console.WriteLine($"Salario bruto: {salarioBruto:C}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS:C}");
            Console.WriteLine($"Salario neto: {salarioNeto:C}");
        }

        Console.WriteLine("\nPrograma finalizado, GRACIAS.");
    }
}
