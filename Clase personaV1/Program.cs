using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_personaV1
{
    class Persona //clase padre
    {
        //variables 
        //atributos
        //metodos
        //se colocara la informacion necesaria que se apoyara la con la informacion
        //se colocara el nombre, edad, fecha de nacimiento, donde agarrara tendra
        //la informacion guardada como en cajones
    }
    class Alumno:Persona //clase hija Alumno 
    {
        //variables
        //atributos
        //metodos
        //se colocara la informacion necesaria que se apoyara la con la informacion
        //se colocara el nombre, edad, fecha de nacimiento, donde agarrara tendra
        //la informacion guardada como en cajones
    }
    class Empleado : Persona //clase Empleado
    {
        //variables
        //atributos
        //metodos
        //se colocara la informacion necesaria que se apoyara la con la informacion
        //se colocara el nombre, edad, fecha de nacimiento, donde agarrara tendra
        //la informacion guardada como en cajones
    }
    class Docente : Persona //clase Docente
    {
        //variables
        //atributos
        //metodos
        //se colocara la informacion necesaria que se apoyara la con la informacion
        //se colocara el nombre, edad, fecha de nacimiento, donde agarrara tendra
        //la informacion guardada como en cajones
    }
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
