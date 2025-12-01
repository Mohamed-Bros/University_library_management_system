using DataAccessLayer.Data;
using DataAccessLayer.DateValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer.Manger
{
    public class BorrowingManger
    {
        public ValidationResult AddBorrower(Borrowing borrowing)
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {
                var BorrorwingValidation = new BorrowingValidator(Context);
                var reslut = BorrorwingValidation.Validate(borrowing);

                if (reslut.IsValid)
                {
                    Book  book = Context.Books.Find(borrowing.Book_ID) ;
                    book.Copies--;
                        

                    Context.Borrowings.Add(borrowing);
                    Context.SaveChanges();
                }

                return reslut;
            }
        }

        public List<Borrowing> ReadeBorrower()
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {
                return Context.Borrowings.Include(borrowing => borrowing.Book)
                    .Include(borrowing => borrowing.Borrower).ToList();
            }
        }

        public Borrowing FindBorrowing(int id)
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {
                return Context.Borrowings.Find(id);
            }
        }

        public ValidationResult UpdateBorrower(Borrowing borrowingUpdate)
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {
                var borrowingValidation = new BorrowingValidator(Context);
                var reslut = borrowingValidation.Validate(borrowingUpdate);

                if (reslut.IsValid)
                {

                    Context.Borrowings.AddOrUpdate(borrowingUpdate);

                    Context.SaveChanges();


                }

                return reslut;
            }
        }

        public void DeletBorrowing(int id)
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {
                Borrowing borrowing = Context.Borrowings.Find(id);

                if (borrowing != null)
                {
                    Context.Borrowings.Remove(borrowing);
                    Context.SaveChanges();
                }
            }
        }

        public List<Borrowing> FilterBorrower(int? idBorrower, int? idBook)
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {

                IQueryable<Borrowing> query = Context.Borrowings;
                query = query.Include(b => b.Borrower).Include(b => b.Book);

                if (idBorrower > 0 && idBorrower != null)
                {
                    query = query.Where(e => e.Borrower_ID == idBorrower);
                }

                if (idBook > 0 && idBook != null)
                {
                    query = query.Where(e => e.Book_ID ==idBook);
                }


                List<Borrowing> filteredResults = query.ToList();

                return filteredResults;
            }
        }

        public bool ReturnBook(int idBorrowing)
        {
            using (var context = new UniversityLibraryManagementEntities())
            {
                var borrowing = context.Borrowings.Find(idBorrowing);
                var book = context.Books.Find(borrowing.Book_ID);
                if (borrowing.Date_Returned == null)
                {
                    borrowing.Date_Returned = DateTime.Now;
                    book.Copies++;
                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
