using System;

namespace AlleeAssignment2Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Book
    {
        int bookID { get; set; }
        String bookName { get; set; }

        public Book(int bbookID, String bbookName)
        {
            bookID = bbookID;
            bookName = bbookName;
        }
    }
    class Order
    {
        int bookID { get; set; }
        int orderID { get; set; }
        String paymentMode { get; set; }

        public Order(int obookID, int oorderID, String opaymentMode)
        {
            bookID = obookID;
            orderID = oorderID;
            paymentMode = opaymentMode;
        }
    }
}
