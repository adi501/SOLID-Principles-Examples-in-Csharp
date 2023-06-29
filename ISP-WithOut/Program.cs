using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_WithOut
{
    internal class Program
    {
        //With Out ISP 
        static void Main(string[] args)
        {
            //For now Customer class having Add() method.
            // in feture if i want to add Read() method for new clients. 
            //if i add Read() method in Icustomer interface we will get problem for old customers
            // by using ISP we can solve this problem

        }
    }
    public interface IEnquiry
    {
        double CalculateDiscount();
    }
    public interface ICustomer : IEnquiry
    {
        void Add();
        //void Read();
    }
    public class Customer : ICustomer
    {
        public void Add()
        {
            // Adds the customer Database 
        }
        public double CalculateDiscount()
        {
            throw new NotImplementedException();
        }
    }
    public class PlatinumCustomer : Customer
    {

    }

    public class GoldCustomer : Customer
    {

    }
    public class EquiryCustomer : IEnquiry 
    {
        public double CalculateDiscount()
        {
            return 2;
        }

    }
}
