using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using DataAccessLayer.Data;


namespace DataAccessLayer.DateValidation
{
    public class BorrowesValidator: AbstractValidator<Borrower>
    {
        private readonly UniversityLibraryManagementEntities _context;
        public BorrowesValidator(UniversityLibraryManagementEntities context) {
            _context = context;

            RuleFor(x => x.Name).NotEmpty().WithMessage("الاسم مطلوب")
                .MaximumLength(150).WithMessage("لا يجب ان يتخطاء الاسم 150 حرف")
                .Must((borrower,fullName)=>UniqeName(fullName,borrower.Borrower_ID)).WithMessage("الاسم موجود");

            RuleFor(x => x.Phone_Number).NotEmpty().WithMessage("الرقم مطلوب")
               .Length(9,20).WithMessage("يجب ان يكون الرقم بين 9 و20 رقم")
               .Matches(@"[0-9]").WithMessage("رقم الهاتف يجب ان يحتوي على رقم هاتف");
        }

        bool UniqeName(string name, int currentID)
        {
            return !_context.Borrowers.Any(x=>x.Name == name && x.Borrower_ID !=currentID);
        }
    }
}
