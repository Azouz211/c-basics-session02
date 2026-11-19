using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //object Book = new Book();

            //Console.WriteLine(Book.ToString());


            #endregion

            #region Question 2 

            //    Book book = new Book
            //    {
            //        Title = "My Book",
            //        Pages = 400
            //    };

            //    Console.WriteLine(book.ToString());
            //    Console.WriteLine(book.Equals(book));
            //    Console.WriteLine(book.GetHashCode());
            //    Console.WriteLine(book.GetType());
            //}

            #endregion

            #region Question 3

            ////int pages = "464"; // Copile time error
            //int Pages = 464; // Fixed

            #endregion

            #region Question 4

            //    int Number1 = 10;
            //    int Number2 = 0;
            //try
            //{
            //    Console.WriteLine(Number1 / Number2);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion

            #region Question 5

            //int Pages = 300;
            //Double DoublePages = Pages;
            //Console.WriteLine(DoublePages);
            #endregion

            #region Question 6

            //double Price = 49.99;
            //int intPrice = (int)Price;

            //Console.WriteLine(intPrice);

            #endregion

            #region Question 7

            //string pagesText = "464";

            //int Pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(Pages);

            #endregion

            #region Question 8 

            string yearText = "2023";
            int year = int.Parse(yearText);

            string badText = "abc";
            if (int.TryParse(badText, out int Number))
            {
                Console.WriteLine(Number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            #endregion
        }
    }
    
}
