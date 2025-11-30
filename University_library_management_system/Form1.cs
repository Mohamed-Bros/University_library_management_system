using System;
using System.Collections.Generic;
using System.ComponentModel;
using FluentValidation.Results;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using DataAccessLayer.Data;
using DataAccessLayer.DateValidation;


namespace University_library_management_system
{
    public partial class BooksForm : Form
    {
        UniversityLibraryManagementEntities contect = new UniversityLibraryManagementEntities();
        DataGridViewRow clickedRow = null;
        public BooksForm()
        {
            InitializeComponent();
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {
            contect.Books.ToList().ForEach(book => { book.Copies = 1; });
            contect.SaveChanges();
            UpdateTable();

        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Title = txtTitle.Text;
            book.Publication_Year = dTPPublishYear.Value;
            
            
            if (CheckValue(book))
            {
                contect.Books.Add(book);
                contect.SaveChanges();

            }
            

            UpdateTable();

        }

        private void dataGridViewDisplayBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clickedRow = dataGridViewDisplayBook.Rows[e.RowIndex];

                var str = clickedRow.Cells[0].Value.ToString();

                Book book = contect.Books.Find(int.Parse(str));
                
                txtTitle.Text = book.Title;
                dTPPublishYear.Value = book.Publication_Year.Value;
                numericUpDown1.Value = book.Copies;
            }
        }

        private void butUpdateBook_Click(object sender, EventArgs e)
        {

            if (clickedRow != null)
            {
                int idBook = int.Parse(clickedRow.Cells[0].Value.ToString());

                Book book = contect.Books.Find(idBook);
                
                if (book != null)
                {
                    book.Title = txtTitle.Text;
                    book.Publication_Year = dTPPublishYear.Value;

                }

                if (CheckValue(book))
                {
                    contect.SaveChanges();

                }

                //تحديث الجدوال
                UpdateTable();


            }
            else
            {
                MessageBox.Show("حدد صف من اجل التحديث");
            }

        }

   

        private void butClear_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "";
            txtAuthor.Text = "";
            dTPPublishYear.Value = DateTime.Now;
        }

        private void butRemoveBook_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {
                int idBook = int.Parse(clickedRow.Cells[0].Value.ToString());

                Book book = contect.Books.Find(idBook);

                if (book != null)
                {
                    contect.Books.Remove(book);
                    contect.SaveChanges();
                    clickedRow = null;
                }


                UpdateTable();

            }
            else
            {
                MessageBox.Show("حدد صف من اجل الحذف");
            }
        }


        bool CheckValue(Book book)
        {

            var validation = new BookValidator(contect);
            ValidationResult result = validation.Validate(book);

            if (!result.IsValid)
            {

                errorProvider1.Clear();

                foreach (var failure in result.Errors)
                {

                    if (failure.PropertyName == nameof(Book.Title))
                    {
                        errorProvider1.SetError(txtTitle, failure.ErrorMessage);
                    }
                    

                }
                return false;
            }
            return true;
        }

        private void UpdateTable()
        {
            var bookList = contect.Books.Select(x => new
            {
                BoolId = x.Book_ID,
                Title = x.Title,
                PublishDate = x.Publication_Year,
                Copies = x.Copies
            }
            ).ToList();
            dataGridViewDisplayBook.DataSource = bookList;
            clickedRow = null;
            dataGridViewDisplayBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
