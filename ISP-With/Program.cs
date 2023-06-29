using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_With
{
    internal class Program
    {
        //With ISP 
        static void Main(string[] args)
        {
            

            // old clients can use only Add method
            ICustomer Iold = new Customer();
            Iold.Add();

            //New clients
            IRead Inew=new Customer();
            Inew.Add();
            Inew.Read();

            //ISP- show only those methods to the client whitch they need

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
    public interface IRead : ICustomer // ISP :- Seperated interfaces
    {
        void Read();

    }
    public class Customer : ICustomer,IRead
    {
        public void Add()
        {
            // Adds the customer Database 
        }
        public double CalculateDiscount()
        {
            return 0;
        }

        public void Read()
        {
           // read
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
