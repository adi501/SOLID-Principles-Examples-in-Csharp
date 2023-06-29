using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LSP_With
{
    internal class Program
    {
        //With LSP
        static void Main(string[] args)
        {
            List<Customer> obj = new List<Customer>();
            obj.Add(new PlatinumCustomer());
            obj.Add(new GoldCustomer());
            // obj.Add(new EnuiryCustomer()); // now i implemented LSP. thats reason in compile time error is giving

            foreach (Customer o in obj)
            {
                o.Add();
            }
        }
    }
    public interface IEnquiry
    {
        double CalculateDiscount();
    }
    public interface ICustomer : IEnquiry
    {
        void Add();
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
    public class EquiryCustomer : IEnquiry // LISKOV Ienquiry and Icustomer interface created 
    {
        public double CalculateDiscount()
        {
            return 2;
        }

    }
}
