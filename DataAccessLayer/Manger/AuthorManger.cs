using DataAccessLayer.Data;
using DataAccessLayer.DateValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Manger
{
    internal class AuthorManger
    {
        private readonly UniversityLibraryManagementEntities Context;
        
        public AuthorManger()
        {
            Context = new UniversityLibraryManagementEntities();
        }

        public ValidationResult AddAuthor(Author author)
        {
            var authorValidation = new AuthorValidator(Context);
            var reslut = authorValidation.Validate(author);

            if (reslut.IsValid)
            {
                Context.Authors.Add(author);
                Context.SaveChanges();
            }

            return reslut;
        }

        public List<Author> ReadeAuthor()
        {

            return Context.Authors.ToList();
        }

        public Author FindAuthor(int id)
        {
            return Context.Authors.Find(id);
        }

        public ValidationResult UpdateAuthor(Author authorUpdate)
        {
            var authorValidation = new AuthorValidator(Context);
            var reslut = authorValidation.Validate(authorUpdate);

            if (reslut.IsValid)
            {

                Context.Authors.AddOrUpdate(authorUpdate);

                Context.SaveChanges();


            }

            return reslut;
        }

        public void DeletAuthor(int id)
        {

            Author author = FindAuthor(id);

            if (author != null)
            {
                Context.Authors.Remove(author);
                Context.SaveChanges();
            }
        }

        public List<Author> FilterAuthor(String AuthorName)
        {


            IQueryable<Author> query = Context.Authors;

            string searchName = AuthorName.Trim();



            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(e => e.Author_Name.Contains(searchName));
            }

            List<Author> filteredResults = query.ToList();

            return filteredResults;
        }
    }
}
