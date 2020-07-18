using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{
    class customer
    {
        //Member variables
        public int CustID;
        public string Name;
        public string Address;

        //constructor for initializing fields
        customer()
        {
            CustID = 1101;
            Name = "Tom";
            Address = "USA";
        }

        //method for displaying customer records (functionality)
        public void displayData()
        {
            Console.WriteLine("Customer=" + CustID);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Address=" + Address);
        }

        //Code for entry point
        static void Main(string[] args)
        {
            //object instantiation
            customer obj = new customer();

            //method call
            obj.displayData();

            //fields call
            Console.WriteLine(obj.CustID);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);
        }
    }
}
