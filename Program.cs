using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
using System.Threading;

namespace DAQPM5500
{
    class Program
    {
        public static void Main(string[] args)
        {
            int milliseconds = 200;

            ModbusClient modbusClient = new ModbusClient("169.254.0.10", 502);                                                //Defining ip adress and port 
            modbusClient.Connect();                                                                                           //connecting to the server                                                

            while (modbusClient.Connected)
            {

                Console.Clear();
                Console.WriteLine("o fabricante do multimedidor é " + modbusClient.ReadHoldingRegisters(70, 1)[0].ToString());
                bool[] readCoils = modbusClient.ReadCoils(38415, 4);

                for (int i = 0; i < readCoils.Length; i++)
                    Console.WriteLine("Status da entrada " + (i + 1) + " " + (38415 + i + 1) + " " + readCoils[i].ToString());
                //console output
                //for (int i = 0; i < readHoldingRegisters.Length; i++)
                //    Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());
                //modbusClient.Disconnect();                                                                                       //Disconnect from Server
                //Console.Write("Press any key to continue . . . ");
                //    Console.WriteLine(modbusClient.ReadInputRegisters(39057, 1)[0].ToString());

                Thread.Sleep(milliseconds);


                //Console.ReadKey(true);

                //}

                //static void ServerPublishing()
                //{
            }
        }
    }
}
