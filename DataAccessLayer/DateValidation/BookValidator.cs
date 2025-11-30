using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccessLayer.Data;


namespace DataAccessLayer.DateValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        private readonly UniversityLibraryManagementEntities _context;
        public BookValidator(UniversityLibraryManagementEntities context)
        {
            _context = context;

            RuleFor(x => x.Title).NotEmpty().WithMessage("عنون الكتاب مطلوب")
                .Length(5, 200).WithMessage("يجب العنون ان يكون ما بين 5 و 200 حرف")
                .Must((book, title) => UniqeName(title, book.Book_ID)).WithMessage("الاسم موجود");

            
        }

        bool UniqeName(string title, int currentID)
        {
            return !_context.Books.Any(x => x.Title == title && x.Book_ID != currentID);
        }
    }
}
