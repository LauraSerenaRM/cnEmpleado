using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnEmpleado
{/// <summary>
/// Nombre: Laura Serena Rivera Mejía
/// Fecha: 24-02-2023
/// Descripción: Este programa solicita el nombre de un empleado y evalua su sueldo para determinar el cobro de impuestos.
/// </summary>
    internal class ClsEmpleado
    {   
        //Declaración de variables
        string Nombre;
        double Sueldo;
        static void Main(string[] args)
        {
            //Se crea un objeto de la Clase Empleado
            ClsEmpleado oEmpleado = new ClsEmpleado();
            //Se llaman los métodos a partir del objeto empleado
            oEmpleado.SolicitarDatos();
            oEmpleado.ImprimirDatos();
            oEmpleado.Impuestos();
            //Instrucción de espera al final de toda la ejecución.
            Console.ReadLine();

        }

        //Metodo 1
        public void SolicitarDatos()
        {
            //Mensajes de salida y captura de datos de entrada
            Console.WriteLine("Ingrese el nombre del empleado");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado");
            Sueldo = int.Parse(Console.ReadLine());

        }

        //Método 2
        public void ImprimirDatos()
        {   //Mensajes de salida
            Console.WriteLine("El nombre del empleado es " + Nombre);
            Console.WriteLine("El sueldo del empleado es " + Sueldo);
        }
        //Método 3
        public void Impuestos()
        {   //Ciclo lógico
            if (Sueldo > 3000)
            {
                Console.WriteLine("El/la empleado(a) " + Nombre + " debe pagar impuestos");

            }
            else
            {
                Console.WriteLine("El empleado(a) " + Nombre + " no debe pagar impuestos");
            }
        }



    }
}
