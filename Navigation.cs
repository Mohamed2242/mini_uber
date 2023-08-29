using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_uber
{
    internal class Navigation
    {
        private TripTypeStrategy tripTypeStrategy;

        public void setStrategy(TripTypeStrategy tripTypeStrategy)
        {
            this.tripTypeStrategy = tripTypeStrategy;
        }

        public void tripType(string start, string destination)
        {
            this.tripTypeStrategy.tripType(start, destination);
        }
    }
}
