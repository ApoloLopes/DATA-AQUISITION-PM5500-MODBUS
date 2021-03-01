﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;
namespace DAQPM5500
{
    class Program
    {
        static void Main(string[] args)
        {
            ModbusClient modbusClient = new ModbusClient("169.254.0.10", 502);                                                //Defining ip adress and port 
            modbusClient.Connect();                                                                                           //connecting to the server                                                
            
            int[] readHoldingRegisters = modbusClient.ReadHoldingRegisters(0, 10);
            
            //console output
            for (int i = 0; i < readHoldingRegisters.Length; i++)
                Console.WriteLine("Value of HoldingRegister " + (i + 1) + " " + readHoldingRegisters[i].ToString());
            modbusClient.Disconnect();                                                                                       //Disconnect from Server
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);

        }

        static void ServerPublishing()
        {

        }
    }
}
