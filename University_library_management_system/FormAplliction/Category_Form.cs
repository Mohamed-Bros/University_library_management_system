using DataAccessLayer.Data;
using DataAccessLayer.Manger;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_library_management_system.FormAplliction
{
    public partial class Category_Form : Form
    {

        DataGridViewRow clickedRow = null;

        public Category_Form()
        {
            InitializeComponent();
            UpdateTable();

            categoryBindingSource.DataSource = typeof(Category);
            categoryBindingSource.AddNew();
        }

        private void UpdateTable()
        {
            var categoryManger = new CategoryManger();

            dataGridViewDisplay.DataSource = categoryManger.ReadeCategory();

            clickedRow = null;

        }

        private void UpdateTable(List<Category> categoriesListFillter)
        {

            dataGridViewDisplay.DataSource = categoriesListFillter;

            clickedRow = null;


        }
        bool CheckValue(ValidationResult result)
        {

            errorProvider1.Clear();

            if (!result.IsValid)
            {


                foreach (var failure in result.Errors)
                {

                    if (failure.PropertyName == nameof(Category.Category_Name))
                    {
                        errorProvider1.SetError(category_NameTextBox, failure.ErrorMessage);
                    }


                }
                return false;
            }
            return true;
        }

        #region Event_Control

        private void btnAdd_Click(object sender, EventArgs e)
        {
            categoryBindingSource.EndEdit();

            var category= categoryBindingSource.Current as Category;

            var categoryManger = new CategoryManger();
            var result = categoryManger.AddCategory(category);

            CheckValue(result);
            UpdateTable();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {

                var category = categoryBindingSource.Current as Category;

                var categoryManger = new CategoryManger();
                var resultVildation = categoryManger.UpdateCategory(category);

                CheckValue(resultVildation);

                //تحديث الجدوال
                UpdateTable();


            }
            else
            {
                MessageBox.Show("حدد صف من اجل التحديث");
            }
        }

        private void btnDelet_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {

                int idCategory = int.Parse(category_IDTextBox.Text);


                var categoryManger = new CategoryManger();
                categoryManger.DeletCategory(idCategory);

                categoryBindingSource.DataSource = new Category();


                UpdateTable();


            }
            else
            {
                MessageBox.Show("حدد صف من اجل حذف");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = new Category();
            clickedRow = null;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var categoryManger = new CategoryManger();

            var cateogryFillterList = categoryManger.FilterCategory(txbCategoryFilter.Text);

            UpdateTable(cateogryFillterList);
        }

        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clickedRow = dataGridViewDisplay.Rows[e.RowIndex];

                var str = clickedRow.Cells[0].Value.ToString();
                var categoryManger = new CategoryManger();
                Category category  = categoryManger.FindCategory(int.Parse(str));
                categoryBindingSource.DataSource = category;
            }
        }
        #endregion
    }
}
