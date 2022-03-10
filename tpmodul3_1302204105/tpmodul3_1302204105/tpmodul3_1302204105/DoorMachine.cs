using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302204105
{
    internal class DoorMachine
    {
        enum State {Terkunci, Terbuka};
        
        public void kunci()
        {
            State kondisi = State.Terkunci;
            string[] menu = {"Terkunci", "Terbuka"};
            Console.WriteLine("Pintu Terkunci");
            while (kondisi != null)
            {
                Console.WriteLine("Menu " + menu[(int)kondisi]);
                Console.Write("Masukkan perintah : ");
                string perintah = Console.ReadLine();
                switch (kondisi)
                {
                    case State.Terkunci:
                        if (perintah == "BukaPintu")
                        {
                            kondisi = State.Terbuka;
                            Console.WriteLine("Pintu tidak terkunci");
                        }
                        else if (perintah == "KunciPintu")
                        {
                            Console.WriteLine("Pintu terkunci");
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }
                        break;
                    case State.Terbuka:
                        if (perintah == "KunciPintu")
                        {
                            kondisi = State.Terbuka;
                            Console.WriteLine("Pintu terkunci");
                        }
                        else if (perintah == "BukaPintu")
                        {
                            Console.WriteLine("Pintu tidak terkunci");
                        }
                        else
                        {
                            System.Environment.Exit(1);
                        }
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
