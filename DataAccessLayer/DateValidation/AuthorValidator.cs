using DataAccessLayer.Data;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DateValidation
{
    public class AuthorValidator : AbstractValidator<Author>
    {

        private readonly UniversityLibraryManagementEntities _context;
        public AuthorValidator(UniversityLibraryManagementEntities context)
        {
            _context = context;

            RuleFor(x => x.Author_Name).NotEmpty().WithMessage("الاسم مطلوب")
                .Length(5, 200).WithMessage("يجب الاسم ان يكون ما بين 5 و 200 حرف")
                .Must((Author, name) => UniqeName(name, Author.Author_ID)).WithMessage("الاسم موجود");


        }

        bool UniqeName(string name, int currentID)
        {
            return !_context.Authors.Any(x => x.Author_Name == name && x.Author_ID != currentID);
        }
    }
}
