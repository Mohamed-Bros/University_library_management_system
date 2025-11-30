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
    public partial class Author_Form : Form
    {
        DataGridViewRow clickedRow = null;
       
        public Author_Form()
        {
            InitializeComponent();
            UpdateTable();

            authorBindingSource.DataSource = typeof(Author);
            authorBindingSource.AddNew();

        }

        private void UpdateTable()
        {
            var authorManger = new AuthorManger();

            dataGridViewDisplay.DataSource = authorManger.ReadeAuthor();
           
            clickedRow = null;

        }

        private void UpdateTable(List<Author> authorListFillter)
        {

            dataGridViewDisplay.DataSource = authorListFillter;

            clickedRow = null;


        }
        bool CheckValue(ValidationResult result)
        {

            errorProvider1.Clear();

            if (!result.IsValid)
            {


                foreach (var failure in result.Errors)
                {

                    if (failure.PropertyName == nameof(Author.Author_Name))
                    {
                        errorProvider1.SetError(txbAuthor, failure.ErrorMessage);
                    }


                }
                return false;
            }
            return true;
        }
        #region Event_Control

        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clickedRow = dataGridViewDisplay.Rows[e.RowIndex];

                var str = clickedRow.Cells[0].Value.ToString();
                AuthorManger authorManger = new AuthorManger();
                Author author = authorManger.FindAuthor(int.Parse(str));
                authorBindingSource.DataSource = author;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            authorBindingSource.EndEdit();

            Author author = authorBindingSource.Current as Author;

            AuthorManger authorManger = new AuthorManger();
            var result = authorManger.AddAuthor(author);
            CheckValue(result);
            UpdateTable();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {

                Author author = authorBindingSource.Current as Author;

                var authorManger = new AuthorManger();
                var resultVildation = authorManger.UpdateAuthor(author);

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
                int idAuthor = int.Parse(txbAuthor_ID.Text);

                var authorManger = new AuthorManger();
                authorManger.DeletAuthor(idAuthor);

                authorBindingSource.DataSource = new Author();

                UpdateTable();

            }
            else
            {
                MessageBox.Show("حدد صف من اجل حذف");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            authorBindingSource.DataSource = new Author();
            clickedRow = null;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var authorManger = new AuthorManger();

            var bookFillterList = authorManger.FilterAuthor(titleTextBox1.Text);

            UpdateTable(bookFillterList);
        }
        #endregion
    }
}
