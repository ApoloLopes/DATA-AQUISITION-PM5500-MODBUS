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
        static ConectionsType conect = new ConectionsType();
        private static String ip = "169.254.0.10";
        private static int port = 502;
        private static String comPort = "COM1";
        private static byte id = 1;
        private static int baudrate = 19200;
        private static String parity = "Even";
        private static String stopbits = "One";

        static void Main(string[] args)
        {
            Thread t = new Thread(ModbusTcp);
            t.Start();
            //conect.ModbusTcp("169.254.0.10", 502);
            ModbusRtu();

            t.Abort();
   
        }

        static void ModbusTcp()
        {
            conect.ModbusTcp(ip, port);
        }

        static void ModbusRtu()
        {
            conect.MdbusRtu(comPort, id, baudrate, parity, stopbits);
        }
    }
}
