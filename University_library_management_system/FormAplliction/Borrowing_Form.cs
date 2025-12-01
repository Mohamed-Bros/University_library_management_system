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
    public partial class Borrowing_Form : Form
    {

        DataGridViewRow clickedRow = null;

        public Borrowing_Form()
        {
            InitializeComponent();

            initialization();
        }

        private void UpdateTable()
        {
            var borrowingManger = new BorrowingManger();
            
                dataGridViewDisplay.DataSource = borrowingManger.ReadeBorrower().Select(borrorwing => new
                {
                    Borrorwing_ID = borrorwing.Borrowing_ID,
                    Book = borrorwing.Book.Title,
                    BorrowerName = borrorwing.Borrower.Name,
                    Date_Borrowed = borrorwing.Date_Borrowed,
                    Due_Date = borrorwing.Due_Date,
                    DataReturn = borrorwing.Date_Returned == null ? "لم يسلم" : borrorwing.Date_Returned.Value.ToString()
                }).ToList();
            
            clickedRow = null;

            errorProvider1.Clear();

        }


        private void UpdateTable(List<Borrowing> borrowingListFillter)
        {


            dataGridViewDisplay.DataSource = borrowingListFillter.Select(borrorwing => new
            {
                Borrorwing_ID = borrorwing.Borrowing_ID,
                Book = borrorwing.Book.Title,
                BorrowerName = borrorwing.Borrower.Name,
                Date_Borrowed = borrorwing.Date_Borrowed ,
                Due_Date = borrorwing.Due_Date ,
                DataReturn = borrorwing.Date_Returned == null ? "لم يسلم" : borrorwing.Date_Returned.Value.ToString()
            }).ToList();

            clickedRow = null;

            errorProvider1.Clear();

        }

        bool CheckValue(ValidationResult result)
        {

            errorProvider1.Clear();

            if (!result.IsValid)
            {


                foreach (var failure in result.Errors)
                {

                    if (failure.PropertyName == nameof(Borrowing.Book_ID))
                    {
                        errorProvider1.SetError(book_IDComboBox, failure.ErrorMessage);
                    }

                    if (failure.PropertyName == nameof(Borrowing.Borrower_ID))
                    {
                        errorProvider1.SetError(borrower_IDComboBox, failure.ErrorMessage);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            borrowingBindingSource.EndEdit();

            var borrowing = initializationBorrowing();
            //borrowing.Borrowing_ID = 0;

            var borrowingManger = new BorrowingManger();
            var result = borrowingManger.AddBorrower(borrowing);
            CheckValue(result);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {


                var borrowing = initializationBorrowing();


                var borrowingManger = new BorrowingManger();
                var result = borrowingManger.UpdateBorrower(borrowing);

                CheckValue(result);

                //تحديث الجدوال


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
                int idBorrowing = int.Parse(clickedRow.Cells[0].Value.ToString());


                var borrowingManger = new BorrowingManger();

                borrowingManger.DeletBorrowing(idBorrowing);
                borrowingBindingSource.DataSource = new Borrowing();


                UpdateTable();
            }
            else
            {
                MessageBox.Show("حدد صف من اجل التحديث");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            borrowingBindingSource.DataSource = new Borrowing();
            clickedRow = null;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var borrowingManger = new BorrowingManger();

            int idBook = int.Parse(cobBook_IDFilter.SelectedValue.ToString());
            int idBorrower = int.Parse(cobBorrower_IDFilter.SelectedValue.ToString());


            var borrowingFillterList = borrowingManger.FilterBorrower(idBorrower, idBook);

            UpdateTable(borrowingFillterList);
        }

        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clickedRow = dataGridViewDisplay.Rows[e.RowIndex];

                var str = clickedRow.Cells[0].Value.ToString();
                var borrorwerManger = new BorrowingManger();
                Borrowing borrowing = borrorwerManger.FindBorrowing(int.Parse(str));
                borrowingBindingSource.DataSource = borrowing;
            }
        }

        #region Operations_initialization
        void initialization()
        {
            borrowingBindingSource.DataSource = typeof(Borrowing);
            borrowingBindingSource.AddNew();


            initializationAllComboBox();

            UpdateTable();
        }



        private void initializationAllComboBox()
        {
            //initialization Author ComboBox()
            var borrorwerManger = new BorrorwerManger();
            var borrorwerList = borrorwerManger.ReadeBorrower();
            var borrorwerNull = new Borrower() { Borrower_ID = -1, Name= "nono" };
            borrorwerList.Insert(0, borrorwerNull);

            borrower_IDComboBox.DataSource = borrorwerList;
            borrower_IDComboBox.DisplayMember = nameof(Borrower.Name);
            borrower_IDComboBox.ValueMember = nameof(Borrower.Borrower_ID);

            //initialization Categories ComboBox()
            var bookmanger = new BookManger();
            var bookList = bookmanger.ReadeBook();
            var bookNull = new Book() { Book_ID= -1, Title= "nono" };
            bookList.Insert(0, bookNull);

            book_IDComboBox.DataSource = bookList;
            book_IDComboBox.DisplayMember = nameof(Book.Title);
            book_IDComboBox.ValueMember = nameof(Book.Book_ID);


            List<Borrower> borrorwerListFliter = borrorwerList.ToList();

            cobBorrower_IDFilter.DataSource = borrorwerListFliter;
            cobBorrower_IDFilter.DisplayMember = nameof(Borrower.Name);
            cobBorrower_IDFilter.ValueMember = nameof(Borrower.Borrower_ID);

            List<Book> bookListFliter = bookList.ToList();

            cobBook_IDFilter.DataSource = bookListFliter;
            cobBook_IDFilter.DisplayMember = nameof(Book.Title);
            cobBook_IDFilter.ValueMember = nameof(Book.Book_ID);




        }
        private Borrowing initializationBorrowing()
        {

            var borrowing = borrowingBindingSource.Current as Borrowing;
            borrowing.Borrower_ID = borrowing.Borrower_ID == -1 ? 0 : borrowing.Borrower_ID;
            borrowing.Book_ID = borrowing.Book_ID == -1 ? 0 : borrowing.Book_ID;
          
            return borrowing;
        }
        #endregion

        private void btmReturn_Click(object sender, EventArgs e)
        {
            
            if (clickedRow != null)
            {
                int idBorrowing = int.Parse(clickedRow.Cells[0].Value.ToString());

                BorrowingManger borrowingManger = new BorrowingManger();
                
               bool stateReturn =  borrowingManger.ReturnBook(idBorrowing);

                if (stateReturn) {
                    MessageBox.Show("تم ارجاع الكتاب");
                }
                else
                {
                    MessageBox.Show("تم ارجاعه بلفعل");
                }

                UpdateTable();
            }
            else
            {
                MessageBox.Show("حدد صف من اجل التحديث");
            }
        }
    }
}
