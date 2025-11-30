using DataAccessLayer.Data;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DateValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        private readonly UniversityLibraryManagementEntities _context;
        public CategoryValidator(UniversityLibraryManagementEntities context)
        {
            _context = context;

            RuleFor(x => x.Category_Name).NotEmpty().WithMessage("الاسم مطلوب")
                .Length(5, 200).WithMessage("يجب الاسم ان يكون ما بين 5 و 200 حرف")
                .Must((category, name) => UniqeName(name, category.Category_ID)).WithMessage("الاسم موجود");


        }

        bool UniqeName(string name, int currentID)
        {
            return !_context.Categories.Any(x => x.Category_Name == name && x.Category_ID != currentID);
        }
    }
}
