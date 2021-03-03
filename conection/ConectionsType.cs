using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using EasyModbus;

namespace DAQPM5500.conections
{
    public class ConectionsType
    {

        public void ModbusTcp(String ip, int port)
        {
            ModbusClient modbusClient = new ModbusClient(ip, port);
            try
            {
                modbusClient.Connect();
                Console.WriteLine("Client conected");
                Console.ReadKey(true);
            }

            catch(SystemException)
            {
                Console.WriteLine("Unable to conect to the client");
                Console.ReadKey(true);
            }

        }

        public void MdbusRtu(String port,  byte id = 1, int baudrate = 9600, String parity = "Even", String stopbits = "One")
        {
            ModbusClient modbusClient = new ModbusClient(port);
            modbusClient.UnitIdentifier = id;
            modbusClient.Baudrate = baudrate;

            switch (parity)
            {
                case "Even":
                    
                    modbusClient.Parity = System.IO.Ports.Parity.Even;

                    break;

                case "Odd":

                    modbusClient.Parity = System.IO.Ports.Parity.Odd;

                    break;

                default:

                    modbusClient.Parity = System.IO.Ports.Parity.Even;

                    break;
            }

            switch (stopbits)
            {
                case "Two":

                    modbusClient.StopBits = System.IO.Ports.StopBits.Two;

                    break;

                case "OnePointFive":

                    modbusClient.StopBits = System.IO.Ports.StopBits.OnePointFive;

                    break;

                case "One":

                    modbusClient.StopBits = System.IO.Ports.StopBits.One;

                    break;

                default:

                    modbusClient.StopBits = System.IO.Ports.StopBits.One;

                    break;
            }

            try
            {
                modbusClient.Connect();
                Console.WriteLine("Client conected");
                Console.ReadKey(true);
            }

            catch (SystemException)
            {
                Console.WriteLine("Unable to conect to the client");
                Console.ReadKey(true);
            }

        }

    }
}
