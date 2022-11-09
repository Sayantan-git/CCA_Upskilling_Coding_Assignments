using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    public class Problem_6
    {
        public enum bookTypes
        {
            Magazine = 0,
            Novel,
            ReferenceBook,
            Miscellaneous
        }

        struct Book
        {
            public int bookId;
            public string title;
            public string price;
            public string bookType;

        
        }

        public void BookDetails()
        {
            Book book = new Book();

            Console.WriteLine("Enter Book Id: ");
            book.bookId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Book Title: ");
            book.title = Console.ReadLine();


            Console.WriteLine("Enter Book price: ");
            book.price = Console.ReadLine();


            Console.WriteLine("Enter Book Type: ");
            Console.WriteLine("1-Magazine : 2-Novel : 3-ReferenceBook : 4-Miscellaneous");

            int action = Convert.ToInt32(Console.ReadLine());

            switch(action)
            {
                case 1:
                    {
                        book.bookType = "Magazine";
                        break;
                    }
                case 2:
                    {
                        book.bookType = "Novel";
                        break;
                    }
                case 3:
                    {
                        book.bookType = "ReferenceBook";
                        break;
                    }
                case 4:
                    {
                        book.bookType = "Miscellaneous";
                        break;
                    }
                default:
                    Console.WriteLine("Wrong action!! try again");
                    break;
            }

            Console.WriteLine("Details of book are: " + "ID: " + book.bookId + " || Title: "+ book.title+ " || Price: "+book.price+" || Type: "+book.bookType);
            Console.ReadKey();
        }

         
    }
}
