using _213023_188_Etapa3_KevinMoreno;
using System.Security.Cryptography.X509Certificates;

// Autor: Kevin Johan Moreno Moreno


internal class Program
{
    private static Estudiante estudiante;
    private static Profesor profesor;
    private static Escuela escuela;
    private static Curso curso;
    private static void Main(string[] args)
    {
        int opcion = 0;

        do
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("                SISTEMA DE INFORMACIÓN UNIVERSITARIO               ");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("1. Registrar Estudiante");
            Console.WriteLine("2. Registrar Profesor");
            Console.WriteLine("3. Registrar Escuela");
            Console.WriteLine("4. Registrar Curso");
            Console.WriteLine("5. Mostrar Información");
            Console.WriteLine("6. Salir");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());


            switch (opcion)
            {
                case 1:
                    RegistrarEstudiante();
                    break;
                
                case 2:
                    RegistrarProfesor();
                    break;

                case 3:
                    RegistrarEscuela();
                    break;

                case 4:
                    RegistrarCurso();
                    break;

                case 5:
                    MostrarInformacion();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine("Saliendo del sistema. ¡Hasta luego!");
                    break;

                default:
                    Console.WriteLine("Opción no válida, intente de nuevo.");
                    break;
            }
        } while (opcion != 6);
                          

    }

    static void RegistrarEstudiante()
    {
        estudiante = new Estudiante();
        Console.Write("Ingrese el ID del estudiante: ");
        estudiante.id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del estudiante: ");
        estudiante.nombre = Console.ReadLine();
        Console.Write("Ingrese la dirección del estudiante: ");
        estudiante.direccion = Console.ReadLine();
        Console.WriteLine("Estudiante registrado exitosamente.");
        Console.ReadLine();

    }

    static void RegistrarProfesor()
    {
        profesor = new Profesor();
        Console.Write("Ingrese el ID del profesor: ");
        profesor.id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del profesor: ");
        profesor.nombre = Console.ReadLine();
        Console.Write("Ingrese el salario del profesor: ");
        profesor.salario = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Profesor registrado exitosamente.");
        Console.ReadLine();
    }

    static void RegistrarEscuela()
    {
        escuela = new Escuela();
        Console.Write("Ingrese el nombre de la escuela: ");
        escuela.nombre = Console.ReadLine();
        Console.WriteLine("Escuela registrada exitosamente.");
        Console.ReadLine();
    }

    static void RegistrarCurso()
    {
        curso = new Curso();
        Console.Write("Ingrese el código del curso: ");
        curso.id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre del curso: ");
        curso.nombre = Console.ReadLine();
        Console.WriteLine("Curso registrado exitosamente.");
        Console.ReadLine();
    }


    static void MostrarInformacion()
    {
        Console.Clear();
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("                SISTEMA DE INFORMACIÓN UNIVERSITARIO               ");
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine("                       REPORTE DE INFORMACIÓN                      ");
        Console.WriteLine("-------------------------------------------------------------------");
        // Mostrar información del estudiante
        if (estudiante != null)
        {
            Console.WriteLine("Información del Estudiante:");
            estudiante.mostrarDatos();
        }
        else
        {
            Console.WriteLine("No hay estudiante registrado.");
        }
        Console.WriteLine("-------------------------------------------------------------------");

        // Mostrar información del profesor
        if (profesor != null)
        {
            Console.WriteLine("Información del Profesor:");
            profesor.mostrarDatos();
        }
        else
        {
            Console.WriteLine("No hay profesor registrado.");
        }
        Console.WriteLine("-------------------------------------------------------------------");

        // Mostrar información de la escuela
        if (escuela != null)
        {
            Console.WriteLine("Información de la Escuela:");
            escuela.mostrarDatos();
        }
        else
        {
            Console.WriteLine("No hay escuela registrada.");
        }
        Console.WriteLine("-------------------------------------------------------------------");

        // Mostrar información del curso
        if (curso != null)
        {
            Console.WriteLine("Información del Curso:");
            curso.mostrarDatos();
        }
        else
        {
            Console.WriteLine("No hay curso registrado.");
        }
        Console.WriteLine("-------------------------------------------------------------------");
        Console.ReadLine();





    }


}