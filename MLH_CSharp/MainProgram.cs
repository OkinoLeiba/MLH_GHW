using System;
using System.Security.Cryptography;



namespace MLH
{
    class Program
    {
        public static void Main(string[] args)
        {

            _ = Request.RequestCallApi();
            RequestCustomer.GetCustomerObject();
            Console.WriteLine("Hello, World!");
        }
    }
}