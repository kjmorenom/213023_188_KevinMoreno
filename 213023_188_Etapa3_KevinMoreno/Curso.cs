using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _213023_188_Etapa3_KevinMoreno
{
    internal class Curso
    {
        // Kevin Johan Moreno Moreno

        //Atributos

        public int id { get; set; }
        public string nombre { get; set; }

        // Métodos

        public void consultar()
        {
            //
        }

        public void mostrarDatos()
        {
            Console.WriteLine("\tId: "+ id +"\n\tNombre: " + nombre);
        }
    }
}
