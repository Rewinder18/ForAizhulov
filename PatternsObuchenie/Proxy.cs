using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsObuchenie
{
    interface UpravlenieClanom
    {
        void BeginClanWar();
    }
    class RealLeader : UpravlenieClanom
    {
        public void BeginClanWar()
        {
            Console.WriteLine("BITVA ZA 3 LITRA PIVA NACHATA");
        }
    }
    class ProxyCoLeader : UpravlenieClanom
    {
        RealLeader realOne;
        public void BeginClanWar()
        {
            if (realOne == null)
            {
                realOne = new RealLeader();
            }
            realOne.BeginClanWar();
            Console.WriteLine("The clan war has begun by Co-Leader Kolyan Pootis");

        }
    }
    class Client
    {
        public void zapros_piva(UpravlenieClanom subject)
        {
            subject.BeginClanWar();
        }
    }
}
