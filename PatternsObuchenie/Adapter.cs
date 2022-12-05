using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsObuchenie
{
    interface IRedBull
    {
        void EbatBottasa();
    }
    class Tapok
    {
        public double litry_redbulla { get; set; }
        public void HamLoshara()
        {
            Console.WriteLine("Sem pobed odnu ne zhdut");
        }
    }
    class Adapter : IRedBull
    {
        public void EbatBottasa()
        {
            Console.WriteLine("Grustnyi Doner");
        }
        private Tapok tapok = new Tapok();
        public void Loshara()
        {
            tapok.HamLoshara();
        }
    }
}
