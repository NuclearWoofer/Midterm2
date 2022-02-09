using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Midterm.Models;
using Midterm;

namespace Midterm
{
    public class MidtermFunctions
    {
        //Get Single book by ID
        public static Books GetBookById(int id)
        {
            try
            {
                using (var db = new SE407_BookStoreContext())
                {
                    return db.Books.Find(id);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;

            }
        }
        //Get all books
        public static List<Books> GetAllBooks()
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Books.ToList();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;

            }
        }

        //Get all books written by a specific authors last name
        public static Authors GetBooksByLastName(string AuthorLast)
        {
            try
            {
                using (var context = new SE407_BookStoreContext())
                {
                    return context.Authors.Find(AuthorLast);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;

            }

        }

    }
}


