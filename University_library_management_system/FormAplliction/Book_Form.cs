using DataAccessLayer.Data;
using DataAccessLayer.DateValidation;
using DataAccessLayer.Manger;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_library_management_system
{
    public partial class Book_Form : Form
    {

        DataGridViewRow clickedRow = null;

        public Book_Form()
        {
            InitializeComponent();
            initialization();
        }

        
        
     
       
        //تحديث الجدول ان حدث اي تغير في قاعده البينات
        private void UpdateTable()
        {
            var bookmanget = new BookManger();
            
            dataGridViewDisplayBook.DataSource = bookmanget.ReadeBook().Select(book => new
            {
                BookId = book.Book_ID,
                Title = book.Title,
                AuthorName = book.Author?.Author_Name ?? "غير محدد",
                Category = book.Category?.Category_Name ?? "غير محدد",
                Copies = book.Copies,
                Publication_Year = book.Publication_Year
            }).ToList();
            
            clickedRow = null;

            errorProvider1.Clear();

        }

        private void UpdateTable(List<Book> bookListFillter)
        {

            dataGridViewDisplayBook.DataSource = bookListFillter.Select(book => new
            {
                BookId = book.Book_ID,
                Title = book.Title,
                AuthorName = book.Author?.Author_Name ?? "غير محدد",
                Category = book.Category?.Category_Name ?? "غير محدد",
                Copies = book.Copies,
                Publication_Year = book.Publication_Year
            }).ToList();

            clickedRow = null;
            errorProvider1.Clear();


        }




        #region Event_Control
        private void dataGridViewDisplayBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clickedRow = dataGridViewDisplayBook.Rows[e.RowIndex];

                var str = clickedRow.Cells[0].Value.ToString();
                BookManger bookManger = new BookManger();
                Book book = bookManger.FindBook(int.Parse(str));
                bookBindingSource.DataSource = book;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bookBindingSource.EndEdit();

            Book book = initializationBook();
            book.Book_ID = 0;

            BookManger bookManger = new BookManger();
            var result = bookManger.AddBook(book);
            CheckValue(result);
        }

        private void update_Click(object sender, EventArgs e)
        {

            if (clickedRow != null)
            {

                Book book = initializationBook();

                var bookManger = new BookManger();
                var result = bookManger.UpdateBook(book);

                CheckValue(result);


                //تحديث الجدوال


            }
            else
            {
                MessageBox.Show("حدد صف من اجل التحديث");
            }

        }

        private void delet_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {
                int idBook = int.Parse(clickedRow.Cells[0].Value.ToString());


                BookManger bookManger = new BookManger();
                bookManger.DeletBook(idBook);
                bookBindingSource.DataSource = new Book();

            }
            else
            {
                MessageBox.Show("حدد صف من اجل التحديث");
            }



            UpdateTable();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            bookBindingSource.DataSource = new Book();
            clickedRow = null;

        }

        private void btnFiltr_Click_1(object sender, EventArgs e)
        {
            var bookManger = new BookManger();

            int? idAuthor = int.Parse(cobAuthor_IDFilter.SelectedValue.ToString());
            int? idCategory = int.Parse(cobCategory_IDFilter.SelectedValue.ToString());


            var bookFillterList = bookManger.FilterBook(titleTextBox1.Text, idAuthor, idCategory);

            UpdateTable(bookFillterList);
        }

        #endregion

        bool CheckValue(ValidationResult result)
        {

            errorProvider1.Clear();

            if (!result.IsValid)
            {


                foreach (var failure in result.Errors)
                {

                    if (failure.PropertyName == nameof(Book.Title))
                    {
                        errorProvider1.SetError(titleTextBox, failure.ErrorMessage);
                    }


                }
                return false;
            }
            else
            {
                UpdateTable();

            }
            return true;
        }


        #region Operations_initialization
        void initialization()
        {
            bookBindingSource.DataSource = typeof(Book);
            bookBindingSource.AddNew();


            initializationAllComboBox();

            UpdateTable();
        }

        private void initializationAllComboBox()
        {
            //initialization Author ComboBox()
            var authorManger = new AuthorManger();
            var authorsList = authorManger.ReadeAuthor();
            var authorNull = new Author() { Author_ID = -1, Author_Name = "nono" };
            authorsList.Insert(0, authorNull);

            author_IDComboBox.DataSource = authorsList;
            author_IDComboBox.DisplayMember = nameof(Author.Author_Name);
            author_IDComboBox.ValueMember = nameof(Author.Author_ID);

            //initialization Categories ComboBox()
            var categoryManger = new CategoryManger();
            var categoriesList = categoryManger.ReadeCategory();
            var categoryNull = new Category() { Category_ID = -1, Category_Name = "nono" };
            categoriesList.Insert(0, categoryNull);

            category_IDComboBox.DataSource = categoriesList;
            category_IDComboBox.DisplayMember = nameof(Category.Category_Name);
            category_IDComboBox.ValueMember = nameof(Category.Category_ID);


            List<Author> authorsListFliter = authorsList.ToList();

            cobAuthor_IDFilter.DataSource = authorsListFliter;
            cobAuthor_IDFilter.DisplayMember = nameof(Author.Author_Name);
            cobAuthor_IDFilter.ValueMember = nameof(Author.Author_ID);

            List<Category> categoriesListFliter = categoriesList.ToList();

            cobCategory_IDFilter.DataSource = categoriesListFliter;
            cobCategory_IDFilter.DisplayMember = nameof(Category.Category_Name);
            cobCategory_IDFilter.ValueMember = nameof(Category.Category_ID);




        }
        private Book initializationBook()
        {

            Book book = bookBindingSource.Current as Book;
            book.Author_ID = book.Author_ID == -1 ? null : book.Author_ID;
            book.Category_ID = book.Category_ID == -1 ? null : book.Category_ID;
            
            return book;
        }
        #endregion

       
    }
}
