using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_WithOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    // SRP- SRP says that a class should be having only one responsibility and not multiple.
    // but in this Customer class is doing multiple responsibilitys like Database connection, Adding to Database & Writing errors into error file

    public class Customer
    {
        public void Add()
        {
            try
            {
                // creating connection to Databse
                //adding to databse 
            }
            catch (Exception ex)
            {
                System.IO.File.
                  WriteAllText(@"c:\Error.txt", ex.ToString());
            }
        }
    }
}
