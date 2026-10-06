
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass8
{
    internal sealed class Completedshipment : Shipman
    {
        Completedshipment(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination) : base(trackingcode, description, weight, delivery, destination)
        {

        }
        public override decimal Estimate()
        {
            throw new NotImplementedException();
        }
        public override void printshipman()
        {
            throw new NotImplementedException();
        }
    }
}