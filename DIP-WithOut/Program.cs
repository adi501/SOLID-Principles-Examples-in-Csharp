using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_WithOut
{
    internal class Program
    {
        // with out DIP
        static void Main(string[] args)
        {
            // in this customer class . this class olny taking care of creating Errorhandler object creation.
            // but it's DIP problem.
        }
    }
    public class Customer
    {
        public void Add()
        {
            try
            {
            }
            catch (Exception ex)
            {
                Errorhandler objError = new Errorhandler();
                objError.WriteError(ex.ToString());
            }
        }
    }
    public class Errorhandler
    {
        public void WriteError(string Error)
        {
            System.IO.File.
                  WriteAllText(@"c:\Error.txt", Error);
        }
    }
}
