using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSiegeTradeCalc.Model
{
    public enum ResourceType
    {
        Fiber = 1,
        Crystal = 1,
        Biomass = 1,

        Resin = 2,
        Chitin = 2,
        Ossian = 2,

        Ferrite = 3,
        Conduit = 3,
        Psigem = 3,

        Xalloy = 4,
        Sparkdust = 4,
        Vitrium = 4,

        Lattice = 5,
        Voidium = 5,
        Isotope = 5,
    }

    public class Trade
    {
        
        public DateTime tradeDate;

        public ResourceType resourceTypePaid;
        public int quantityPaid;
        public ResourceType resourceTypeReceived;
        public int quantityReceived;

        public float tradeRatio { get { return (float)quantityReceived / quantityPaid; } }
        
    }
}
