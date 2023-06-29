using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_With
{
    internal class Program
    {
        //With  OCP Principle
        static void Main(string[] args)
        {
        }
    }
    // Close the customer class for modification but it can be extended open closed principle

    public class Customer //normal customer
    {
        public virtual double CalculateDiscount()
        {
            return 0;
        }
    }
    public class PlatinumCustomer : Customer // OPEN closed principle - new classes are created by inheritance
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }
    }
    public class GoldCustomer : Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }
    }
}
