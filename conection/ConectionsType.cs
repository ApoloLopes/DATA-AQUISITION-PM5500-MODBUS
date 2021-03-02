using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace DAQPM5500.conections
{
    class ConectionsType
    {

        private void modbusTcp(String ip, int port)
        {
            ModbusClient modbusClient = new ModbusClient(ip, port);
            try
            {
                modbusClient.Connect();
                Console.WriteLine("Client conected");
            }

            catch(SystemException)
            {
                Console.WriteLine("Unable to conect to the client");
            }

        }

    }
}
