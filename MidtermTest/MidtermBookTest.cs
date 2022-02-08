using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Midterm;
using MidtermTest;


namespace MidtermTest
{
    public class MidtermBookTest
    {
        [Fact]
        public void GetBookById()
        {
            var result = MidtermFunctions.GetBookById(2);
            Assert.True(result.BookTitle == "Canterbury Tales");
            
        }

        [Fact]
        public void GetAllMoviesTest()
        {
            var result = MidtermFunctions.GetAllBooks();
            Assert.True(result.Count == 2);
        }


    }
}
