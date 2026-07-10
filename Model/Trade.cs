using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoSiegeTradeCalc
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
        
        public DateTime TradeDate { get; set; }

        public ResourceType ResourceTypePaid { get; set; }
        private int _qtyPaid;
        public int QtyPaid
        {
            get
            {
                return _qtyPaid;
            }
            set
            {
                if(_qtyPaid != value)
                {
                    _qtyPaid = value;
                    OnPropertyChanged(nameof(QtyPaid));
                    OnPropertyChanged(nameof(TradeRatio));
                }
            }
        }
        
        public ResourceType ResourceTypeReceived { get; set; }
        private int _qtyReceived;
        public int QtyReceived
        {
            get
            {
                return _qtyReceived;
            }
            set
            {
                if (_qtyReceived != value)
                {
                    _qtyReceived = value;
                    OnPropertyChanged(nameof(QtyReceived));
                    OnPropertyChanged(nameof(TradeRatio));
                }
            }
        }

        public float TradeRatio => QtyPaid == 0 ? 0 : (float)QtyReceived / QtyPaid;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
