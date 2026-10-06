using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass8
{
    internal class Expressshipment : Shipman
    {
        private decimal extrafee;
        public decimal Extrafee
        {
            get
            {
                return extrafee >= 0 ? del * 0.5m : 0;


            }
        }
        public Expressshipment(string trackingcode, string description, int weight, int delivery, Delivaryaddress destination, decimal extrafee) : base(trackingcode, description, weight, delivery, destination)
        {
            this.extrafee = extrafee;
        }

        public override decimal Estimate()
        {
           
                return del + (Weight * 5) + Extrafee;
            
        }
        public override void printshipman()
        {
            Console.WriteLine($"the estimated is:{Estimate}the extrafee is:{extrafee}");
        }
        public decimal CalculateInsurance()
        {
            decimal res = 0.8m * Estimate();
            return res;
        }
    }
}