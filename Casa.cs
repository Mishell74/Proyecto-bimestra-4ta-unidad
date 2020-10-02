using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ConsoleApplication1
{
    class Casa
    {

        private SerialPort Arduino = new SerialPort("COM9", 9600);

        public void EnviarCaracter(string dato)
        {
            Arduino.Write(dato);
        }

    }
}
