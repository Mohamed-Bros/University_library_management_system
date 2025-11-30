using DataAccessLayer.Data;
using DataAccessLayer.DateValidation;
using DataAccessLayer.DateValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Manger
{
    public class BookManger
    {
       private readonly UniversityLibraryManagementEntities Context;

        public BookManger()
        {
            Context = new UniversityLibraryManagementEntities();
        }

        public ValidationResult AddBook(Book book)
        {
            var bookValidation = new BookValidator(Context);
            var reslut = bookValidation.Validate(book);

            if (reslut.IsValid)
            {
                Context.Books.Add(book);
                Context.SaveChanges();
            }

            return reslut;
        }

        public List<Book> ReadeBook() { 
            
            return Context.Books.Include(book =>  book.Author).Include(book => book.Category).ToList();
        }

        public Book FindBook (int id)
        {
            return Context.Books.Find(id);
        }

        public ValidationResult UpdateBook(Book bookUpdate)
        {
            var bookValidation = new BookValidator(Context);
            var reslut = bookValidation.Validate(bookUpdate);

            if (reslut.IsValid)
            {

                Context.Books.AddOrUpdate(bookUpdate);

                Context.SaveChanges();


            }

            return reslut;
        }

        public void DeletBook(int id) { 
            
            Book book = FindBook(id);
            
            if (book != null)
            {
                Context.Books.Remove(book);
                Context.SaveChanges();
            }
        }

        public List<Book> FilterBook(String bookName ,int? idAuthor,int? idCategory) {


            IQueryable<Book> query = Context.Books;

            string searchName = bookName.Trim();
             

            if ( idAuthor >0 && idAuthor != null)
            {
                query = query.Where(e => e.Author_ID == idAuthor);
            }

            if (idCategory > 0 && idCategory != null)
            {
                query = query.Where(e => e.Category_ID == idCategory);
            }

            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(e => e.Title.Contains(searchName));
            }

            List<Book> filteredResults = query.ToList();

            return filteredResults;
        }

    }
}
