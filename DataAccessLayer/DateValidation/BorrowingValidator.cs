using DataAccessLayer.Data;
using DataAccessLayer.Manger;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DateValidation
{
    public class BorrowingValidator : AbstractValidator<Borrowing>
    {

        private readonly UniversityLibraryManagementEntities _context;
        public BorrowingValidator(UniversityLibraryManagementEntities context)
        {
            _context = context;

            
            RuleFor(x => x.Book_ID).NotEmpty().WithMessage("يجب اختيار الكتاب ")
                .Must(bookId => CheckTheBookCopies(bookId)).WithMessage("لا توجد نسخ من الكتاب");


            RuleFor(x => x.Borrower_ID).NotEmpty().WithMessage("يجب اختيار الكتاب ")
                .Must((borrowing, idBorrower) => CheckHasBorrorwer(idBorrower, borrowing.Book_ID))
                .WithMessage("لا يمكن للمستعير استعاره هو مستعير ولم يرجعه");
        }


        bool CheckHasBorrorwer(int idBorrower, int idBook)
        {
            return !_context.Borrowings.Where(x => idBorrower == x.Borrower_ID)
                .Any(x => x.Book_ID == idBook && x.Date_Returned != null);
        }
        //التحقق من وجود نسخ للكتاب
        bool CheckTheBookCopies(int idBook)
        {
            Book book = _context.Books.Find(idBook);

            if (book.Copies <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool UniqeName(string title, int currentID)
        {
            return !_context.Books.Any(x => x.Title == title && x.Book_ID != currentID);
        }
    }
}
