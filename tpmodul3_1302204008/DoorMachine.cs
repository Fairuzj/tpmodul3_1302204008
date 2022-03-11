using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204008
{
    internal class DoorMachine
    {
        String State;
        public String KunciPintu()
        {
            State = "Terkunci";
            return State;
        }
        public String BukaPintu()
        {
            State = "Terbuka";
            return State;
        }
        public void CekPintu()
        {
            if(State == "Terkunci")
            {
                Console.WriteLine("Pintu Terkunci");
                Console.ReadLine();
            }else if(State == "Terbuka")
            {
                Console.WriteLine("Pintu Tidak Terkunci");
                Console.ReadLine();
            }
        }
    }
}
