using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_188_Etapa3_KevinMoreno
{
    internal class Estudiante: Persona
    {
        // Kevin Johan Moreno Moreno

        //Atributos

        public string direccion { get; set; }

        // Métodos

        public void incribirCursos()
        {
            //
        }
        public void mostrarDatos()
        {
            Console.WriteLine("\tId: "+ id +"\n\tNombre: " + nombre + "\n\tDirección: " + direccion);
        }


    }
}
