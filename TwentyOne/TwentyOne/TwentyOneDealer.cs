using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace TwentyOne
{
    public class TwentyOneDealer : Dealer
    {
        private List<Card> _hand = new List<Card>();
        public List<Card> Cards = new List<Card>();
        public bool Stay { get { return _hand; } set { _hand = value; } }
        public bool isBusted { get; set; }
    }
}
