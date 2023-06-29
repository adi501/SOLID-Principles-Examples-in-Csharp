using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_WithOut
{
    internal class Program
    {
        //With Out LSP Principle
        // with out liskov substitution principle
        // Problem : // when we call Eqnuiry custome Add method() throws exception
        // to solving this problem we are using  Liskov (LSP) 

        static void Main(string[] args)
        {
            List<Customer> obj = new List<Customer>();
            obj.Add(new PlatinumCustomer());
            obj.Add(new GoldCustomer());
            obj.Add(new EnuiryCustomer()); // when we call Eqnuiry custome Add method() throws exception

            foreach (Customer o in obj)
            {
                o.Add();
            }
        }
    }

    // as polymorphism 
    public class Customer // Normal Customer
    {
        public virtual double CalculateDiscount()
        {
            return 0;
        }
        public virtual void Add()
        {
            //Add to database
        }
    }
    public class PlatinumCustomer : Customer // Platinum Customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 10;
        }
        public override void Add()
        {
            //Add to database
        }
    }
    public class GoldCustomer : Customer //Gold customer
    {
        public override double CalculateDiscount()
        {
            return base.CalculateDiscount() + 5;
        }
        public override void Add()
        {
            //Add to database
        }
    }
    public class EnuiryCustomer : Customer //Enuiry customer
    {
        public override double CalculateDiscount()
        {
            return 2;
        }
        public override void Add()
        {
            throw new NotImplementedException(" FOr Enuiry customer  not required");
        }
    }
}
