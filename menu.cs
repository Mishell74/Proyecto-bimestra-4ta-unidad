using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Casa_domotica
{
    class Casa
    {

        private int opci = 0;

      public int Menu
      {
          Console.WriteLine ("Para encender sala precione q")
          Console.WriteLine("Para pagar la luz de la sala precione w");
          Console.WriteLine("Para encender la televisión presione e");
          Console.WriteLine("Para apagar la televisión presione r");
          Console.WriteLine("Para abrir el garage precione presione Y");
          Console.WriteLine("Para cerrar el garage precione u");
          Console.WriteLine("Para abrir la cortina 1 precione c");
          Console.WriteLine("Para abrir la cortina 2 precione b");
          Console.WriteLine("Para salir presione X");

          Console.WriteLine("¿Qué desea hacer?: ");
          opci = int.FileStyleUriParser(Console.ReadLine());
          return opci;


      }
          
    }
}
