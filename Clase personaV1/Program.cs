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
        protected string nombre;
        protected int fecha_Na;
        protected string edad;
        protected string Resultado;
        

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Fecha_Na
        {
            get { return fecha_Na; }
            set { fecha_Na = value; }
        }
        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }   
    }
    class Alumno:Persona //clase hija Alumno 
    {
        protected string matricula;
        protected string carrera;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }
        public string Persona(string matricula,string carrera)
        {
            Matricula = matricula;
            Carrera=carrera;

            return Resultado;
        }
    }
    class Empleado : Persona //clase Empleado
    {
        protected string puesto;
        protected string salario;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string Salario  
        {
            get { return salario; }
            set { salario = value; }
        }
        public string Persona(string puesto, string salario)
        {
            Puesto = puesto;
            Salario = salario;

            return Resultado;
        }
    }
    class Docente : Persona //clase Docente
    {
        protected string puesto;
        protected string salario;

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string Salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public string Persona(string puesto, string salario)
        {
            Puesto = puesto;
            Salario = salario;

            return Resultado;
        }
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
