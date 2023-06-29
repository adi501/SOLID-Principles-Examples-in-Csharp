using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_With
{
    internal class Program
    {
        //SRP- Single Responsibility Principle
        static void Main(string[] args)
        {
        }
    }
    //SRP Example
    //In this class we are moved Error writing into out of class.
    // now this class following SRP. even we can move this try & catch block to golbal error handler.
    // Now customer class is doing add to database
    //errorhandler class is doing writing errors into log
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
                Errorhandler objError = new Errorhandler();
                objError.WriteError(ex.ToString());
            }
        }
    }
    // SRP ( Created a new class for error handling)
    public class Errorhandler
    {
        public void WriteError(string Error)
        {
            System.IO.File.
                  WriteAllText(@"c:\Error.txt", Error);
        }
    }
}
