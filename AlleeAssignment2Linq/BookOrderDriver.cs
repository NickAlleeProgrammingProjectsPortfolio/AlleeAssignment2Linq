using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AlleeAssignment2Linq
{
    class Book
    {
        public int bookID { get; set; }
        public String bookName { get; set; }

        public Book(int bbookID, String bbookName)
        {
            bookID = bbookID;
            bookName = bbookName;
        }
    }
    class Order
    {
        public int bookID { get; set; }
        public int orderID { get; set; }
        public String paymentMode { get; set; }

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
            // making 4 books and adding them to a book list
            List<Book> bookList = new List<Book>();
            Book book1 = new Book(1, "MoreEffective C#");
            Book book2 = new Book(2, "Head First Design Pattern");
            Book book3 = new Book(3, "Fluent Python");
            Book book4 = new Book(4, "First Generation MAinframes");
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);


            // making 5 orders and adding them to order list
            List<Order> orderList = new List<Order>();
            Order order1 = new Order(1, 100, "Debit");
            Order order2 = new Order(1, 104, "Cash");
            Order order3 = new Order(3, 105, "Credit");
            Order order4 = new Order(4, 108, "Cash");
            Order order5 = new Order(5, 110, "Debit");
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);


            // start the first linq question here
            var bookOrders = (from book in bookList
                              join order in orderList on book.bookID equals order.bookID
                              select new
                              {
                                  book.bookID,
                                  book.bookName,
                                  order.paymentMode
                              }

                              );


            //executing bookorders query
            foreach (var theorder in bookOrders)
            {
                Console.WriteLine(theorder);
            }







            // first attempt was this but it does not work cause book id is not a string
            //var bookOrders = (from book in bookList
            //                  select book.bookID
            //                  ).Concat(from book in bookList
            //                           select book.bookName
            //                           ).Concat(from order in orderList
            //                                    select order.paymentMode);



            // linq question 2 with xml


            //var xmlBookList = (from book in bookList
            //                   select new { book.bookID, book.bookName });

            //XElement myXelement = new XElement("book list",
            //    foreach (var book in xmlBookList)
            //        {
            //            new XElement("BookID", book.bookID, new XAttribute("Book Name", book.bookName))
            //        } 
            //    );

            //2nd 
            foreach(Book bk in bookList)
            {
                XElement myXelement = new XElement("booklist", new XElement("bookID", bk.bookID),new XElement("bookName",bk.bookName));

                Console.WriteLine(myXelement);
            }



            // linq question 3 a cartesian product
            List <char> dataSet1 =new List<char> { 'H', 'A', 'P', 'P', 'Y' };
            List <int> dataSet2 = new List<int> { 1, 2, 3 };

            var cartesianP = (from letter in dataSet1
                              from number in dataSet2
                              select new { letter, number });
            // executing cartesionP query
            foreach (var combo in cartesianP)
            {
                Console.WriteLine(combo);
            }

        }

    }
}
