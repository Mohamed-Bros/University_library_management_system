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
    public class CategoryManger
    {
        private readonly UniversityLibraryManagementEntities Context;

        public CategoryManger()
        {
            Context = new UniversityLibraryManagementEntities();
        }

        public ValidationResult AddCategory(Category category)
        {
            var categoryValidation = new CategoryValidator(Context);
            var reslut = categoryValidation.Validate(category);

            if (reslut.IsValid)
            {
                Context.Categories.Add(category);
                Context.SaveChanges();
            }

            return reslut;
        }

        public List<Category> ReadeCategory()
        {

            return Context.Categories.ToList();
        }

        public Category FindCategory(int id)
        {
            return Context.Categories.Find(id);
        }

        public ValidationResult UpdateCategory(Category categoryUpdate)
        {
            var categoryValidation = new CategoryValidator(Context);
            var reslut = categoryValidation.Validate(categoryUpdate);

            if (reslut.IsValid)
            {

                Context.Categories.AddOrUpdate(categoryUpdate);

                Context.SaveChanges();


            }

            return reslut;
        }

        public void DeletCategory(int id)
        {

            Category category = FindCategory(id);

            if (category != null)
            {
                Context.Categories.Remove(category);
                Context.SaveChanges();
            }
        }

        public List<Category> FilterCategory(String categoryName)
        {


            IQueryable<Category> query = Context.Categories;

            string searchName = categoryName.Trim();



            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(e => e.Category_Name.Contains(searchName));
            }

            List<Category> filteredResults = query.ToList();

            return filteredResults;
        }
    }
}
