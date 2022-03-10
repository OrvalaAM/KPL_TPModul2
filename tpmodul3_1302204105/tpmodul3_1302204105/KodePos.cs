using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204105
{
    internal class KodePos
    {
        string[] kelurahan = {"Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
        "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"};
        string[] kodepos = {"40266", "40287", "40267", "40256", "40287",
        "40286", "40286", "40286", "40272", "40274", "40273"};

        public void getKodePos()
        {
            int panjang = kodepos.Length;
            for(int i = 0; i < panjang; i++)
            {
                Console.WriteLine(kodepos[i]);
            }
        }
    }
}
