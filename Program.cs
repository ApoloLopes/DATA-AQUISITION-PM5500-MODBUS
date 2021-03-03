using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Threading;
using DAQPM5500.conections;

namespace DAQPM5500
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ConectionsType conect = new ConectionsType();

            conect.ModbusTcp("169.254.0.10", 502);
            //conect.MdbusRtu("COM1", 1, 19200, "Even", "One");
   
        }
    }
}
