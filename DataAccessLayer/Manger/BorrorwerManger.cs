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
    internal class BorrorwerManger
    {
        private readonly UniversityLibraryManagementEntities Context;

        public BorrorwerManger()
        {
            Context = new UniversityLibraryManagementEntities();
        }

        public ValidationResult AddBorrower(Borrower borrower)
        {
            var BorrowerValidation = new BorrowesValidator(Context);
            var reslut = BorrowerValidation.Validate(borrower);

            if (reslut.IsValid)
            {
                Context.Borrowers.Add(borrower);
                Context.SaveChanges();
            }

            return reslut;
        }

        public List<Borrower> ReadeBorrower()
        {

            return Context.Borrowers.ToList();
        }

        public Borrower FindBorrower(int id)
        {
            return Context.Borrowers.Find(id);
        }

        public ValidationResult UpdateBorrower(Borrower borrowerUpdate)
        {
            var borrowerValidation = new BorrowesValidator(Context);
            var reslut = borrowerValidation.Validate(borrowerUpdate);

            if (reslut.IsValid)
            {

                Context.Borrowers.AddOrUpdate(borrowerUpdate);

                Context.SaveChanges();


            }

            return reslut;
        }

        public void DeletBorrower(int id)
        {

            Borrower borrower = FindBorrower(id);

            if (borrower != null)
            {
                Context.Borrowers.Remove(borrower);
                Context.SaveChanges();
            }
        }

        public List<Borrower> FilterBorrower(String borrowerName,string phonNuber)
        {


            IQueryable<Borrower> query = Context.Borrowers;

            string searchName = borrowerName.Trim();

            if(!string.IsNullOrEmpty(phonNuber))
            {
                query = query.Where(e => e.Phone_Number.Contains(phonNuber.ToString()));
            }


            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(e => e.Name.Contains(searchName));
            }

            List<Borrower> filteredResults = query.ToList();

            return filteredResults;
        }
    }
}
