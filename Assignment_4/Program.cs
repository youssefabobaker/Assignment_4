using System.Drawing;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?
            //Book book = new Book();
            //Console.WriteLine(book.password); // error because 'password' is private and cannot be accessed from outside the class
            #endregion

            #region Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock); // it conpiles because 'copiesInStock' is internal and can be accessed from the same assembly
            #endregion

            #region Add a public string Title; field to Book. Set it and print it from Main. 
            //Book book = new Book();
            //book.Title = "Book Title";
            //Console.WriteLine(book.Title);
            #endregion

            #region Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it. 
            //Book book = new Book();
            //Console.WriteLine(book.genre);
            #endregion

        }
    }
}
