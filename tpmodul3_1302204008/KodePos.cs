using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204008
{
    internal class KodePos
    {
        public void getKodePos()
        {
            String[] kelurahan = {"Batununggal","Kujangsari","Mengger","Wates","Cijaura","Jatisari",
                                  "Margasari","Sekejati","Kebonwaru","Maleer","Samoja"};
            int[] kode = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
            for(int i = 0; i < kelurahan.Length; i++)
            {
                Console.WriteLine(kelurahan[i]+" "+kode[i]);
            }
        }
    }
}
