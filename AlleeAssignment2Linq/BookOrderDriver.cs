using System;
using System.Collections.Generic;

namespace AlleeAssignment2Linq
{
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

    class BookOrderDriver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Book> bookList = new List<Book>();
            Book book1 = new Book(1, "MoreEffective C#");
            Book book2 = new Book(2, "Head First Design Pattern");
            Book book3 = new Book(3, "Fluent Python");
            Book book4 = new Book(4, "First Generation MAinframes");
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);

            List<Order> orderList = new List<Order>();
            Order order1 = new Order(1,100,"Debit");
            Order order2 = new Order(1,104,"Cash");
            Order order3 = new Order(3,105,"Credit");
            Order order4 = new Order(4,108,"Cash");
            Order order5 = new Order(5,110,"Debit");
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
        }

    }
}
