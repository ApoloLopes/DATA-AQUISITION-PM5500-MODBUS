using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace DAQPM5500.readactions
{
    class ReadActions
    {
        public void ReadCoils(int start_a, int e_num)
        {

            bool[] readCoils = modbusClient.ReadCoils(9, 10);
        } 
    }
}
