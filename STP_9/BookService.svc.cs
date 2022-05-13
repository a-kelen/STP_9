using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace STP_9
{
   
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class BookService : IBookService
    {
        public List<Book> GetBooksList()
        {
            return GetBookData();
        }

        public Book GetBookById(string id)
        {
            int intId = int.Parse(id);
            return GetBookData().FirstOrDefault(x => x.Id == intId);
        }

        private List<Book> GetBookData()
        {
            List<Book> books = new List<Book>();

            books.Add(new Book
            {
                Id = 1,
                Name = "Book 1",
                Description = "Some long description ...",
                Year = 2015
            });
            books.Add(new Book
            {
                Id = 2,
                Name = "Book 2",
                Description = "Some long description ...",
                Year = 2007
            });
            books.Add(new Book
            {
                Id = 3,
                Name = "Book 3",
                Description = "Some long description ...",
                Year = 2012
            });
            books.Add(new Book
            {
                Id = 4,
                Name = "Book 4",
                Description = "Some long description ...",
                Year = 2021
            });

            return books;
        }
    }
}
