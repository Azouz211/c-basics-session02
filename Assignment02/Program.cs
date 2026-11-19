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

            Book book = new Book
            {
                Title = "My Book",
                Pages = 400
            };

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
        }

            #endregion
    }
    
}
