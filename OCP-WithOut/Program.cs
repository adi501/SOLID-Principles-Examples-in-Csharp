using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_WithOut
{
    internal class Program
    {
        //With Out OCP Principle
        static void Main(string[] args)
        {
        }
    }
   //
    public class Customer
    {
        private int _CustType;
        public int CustType
        {
            get { return _CustType; }
            set { _CustType = value; }
        }
      
        public double CalculateDiscount()
        {
            //Problem: see in this below if condition. now we have Platinum gold & normal customers.
            // but in feture if we want to add 1 or 2 more customers types we want to add. then we need to edit the code.
            //but based on OCP this is not good way.
            // OCP says that : any class(project) open to extension closed to modification

            //platinum customer
            if (_CustType==1)
            {
                return 10;
            }
            //Gold customer
            else if (_CustType==2)
            {
                return 5;
            }
            else
            {
                return 0;
            }
        }
      
    }
   
}
