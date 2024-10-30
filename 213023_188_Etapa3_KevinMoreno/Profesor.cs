using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_188_Etapa3_KevinMoreno
{
    internal class Profesor: Persona
    {
        // Kevin Johan Moreno Moreno

        //Atributos

        public decimal salario { get; set; }

        // Métodos

        public void asignarCursos()
        {
            Console.WriteLine("Salario: " + salario);
        }

        public void mostrarDatos()
        {
            Console.WriteLine("\tId: " + id + "\n\tNombre: " + nombre + "\n\tSalario: " + salario);
        }
    }
}
