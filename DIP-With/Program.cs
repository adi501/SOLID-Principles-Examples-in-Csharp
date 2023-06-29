using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_With
{
    internal class Program
    {
        // with  DIP
        static void Main(string[] args)
        {
            // In this example We implemented  DIP
            // see below we  create IErrorhandle interface , FileerrorHandler class & EventErrorHandler class's are IErrorhandler from interface.
            //in customer class based on error type we are injecting the Error handler class object


            Customer obj = new Customer(new FileErrorhandler());
            Customer obj1 = new Customer(new EventErrorhandler());
            // now customer class not creating Error object creation
            // when we calling customer class only we are passing the Error object.
            // In this examle main method is taking care of Object creation for error.
        }
    }
    public class Customer
    {
        private IErrorhandler IErr;
        public Customer(IErrorhandler i) // Depedency inversion :- Error handler will come from outside
        {
            IErr = i;
        }
        public void Add()
        {
            try
            {
            }
            catch (Exception ex)
            {
                IErr.WriteError(ex.ToString());
            }
        }
    }
    public interface IErrorhandler
    {
        void WriteError(string err);
    }
    public class FileErrorhandler: IErrorhandler
    {
        public void WriteError(string Error)
        {
            System.IO.File.
                  WriteAllText(@"c:\Error.txt", Error);
        }
    }
    public class EventErrorhandler : IErrorhandler
    {
        public void WriteError(string Error)
        {
            System.IO.File.
                  WriteAllText(@"c:\EventError.txt", Error);
        }
    }
}
