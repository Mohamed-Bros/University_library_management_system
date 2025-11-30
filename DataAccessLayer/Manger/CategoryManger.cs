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


        public ValidationResult AddCategory(Category category)
        {
            using (var Context = new UniversityLibraryManagementEntities())
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
        }

        public List<Category> ReadeCategory()
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {
                return Context.Categories.ToList();
            }
        }
        public Category FindCategory(int id)
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {
                return Context.Categories.Find(id);
            }
        }

        public ValidationResult UpdateCategory(Category categoryUpdate)
        {
            using (var Context = new UniversityLibraryManagementEntities())
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
        }

        public void DeletCategory(int id)
        {
            using (var Context = new UniversityLibraryManagementEntities())
            {

                Category category = Context.Categories.Find(id);

                if (category != null)
                {
                    Context.Categories.Remove(category);
                    Context.SaveChanges();
                }
            }
        }

        public List<Category> FilterCategory(String categoryName)
        {
            using (var Context = new UniversityLibraryManagementEntities())
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
}
