using DataAccessLayer.Data;
using DataAccessLayer.Manger;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University_library_management_system.FormAplliction
{
    public partial class Borrower_Form : Form
    {

        DataGridViewRow clickedRow = null;
        public Borrower_Form()
        {
            InitializeComponent();

            borrowerBindingSource.DataSource = typeof(Borrower);
            borrowerBindingSource.AddNew();

            UpdateTable();
        }

        bool CheckValue(ValidationResult result)
        {

            errorProvider1.Clear();

            if (!result.IsValid)
            {


                foreach (var failure in result.Errors)
                {

                    if (failure.PropertyName == nameof(Borrower.Name))
                    {
                        errorProvider1.SetError(nameTextBox, failure.ErrorMessage);
                    }

                    if (failure.PropertyName == nameof(Borrower.Phone_Number))
                    {
                        errorProvider1.SetError(phone_NumberTextBox, failure.ErrorMessage);
                    }


                    if (failure.PropertyName == nameof(Borrower.Email))
                    {
                        errorProvider1.SetError(emailTextBox, failure.ErrorMessage);
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
        private void UpdateTable()
        {
            var BorrorwerManget = new BorrorwerManger();

            dataGridViewDisplay.DataSource = BorrorwerManget.ReadeBorrower().Select(borrower => new Borrower
                  {
                Borrower_ID = borrower.Borrower_ID,
                Name = borrower.Name,
                Email = borrower.Email,
                Phone_Number = borrower.Phone_Number,
                Address = borrower.Address ?? "غير محدد",
            }).ToList();

            clickedRow = null;

            errorProvider1.Clear();

        }

        private void UpdateTable(List<Borrower> bookListFillter)
        {

            dataGridViewDisplay.DataSource = bookListFillter.Select(borrower => new Borrower
            {
                Borrower_ID = borrower.Borrower_ID,
                Name = borrower.Name,
                Email = borrower.Email,
                Phone_Number = borrower.Phone_Number,
                Address = borrower.Address ?? "غير محدد",
            }).ToList();

            clickedRow = null;

            errorProvider1.Clear();

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            borrowerBindingSource.EndEdit();

            Borrower borrower = borrowerBindingSource.Current as Borrower;

            var borrorwerManger = new BorrorwerManger();
            var result = borrorwerManger.AddBorrower(borrower);

            CheckValue(result);
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {

                Borrower borrower = borrowerBindingSource.Current as Borrower;

                var borrorwerManger= new BorrorwerManger();
                borrorwerManger.UpdateBorrower(borrower);



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
                int idBorrorwe = int.Parse(clickedRow.Cells[0].Value.ToString());


                var borrorwerManger = new BorrorwerManger();
                borrorwerManger.DeletBorrower(idBorrorwe);
                borrowerBindingSource.DataSource = new Borrower();


                UpdateTable();

            }
            else
            {
                MessageBox.Show("حدد صف من اجل التحديث");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            borrowerBindingSource.DataSource = new Borrower();
            clickedRow = null;

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            var borrorwerManger = new BorrorwerManger();

            var borrowerFillterList = borrorwerManger.FilterBorrower(nameTextBox.Text, phone_NumberTextBox.Text);

            UpdateTable(borrowerFillterList);
        }

        private void dataGridViewDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                clickedRow = dataGridViewDisplay.Rows[e.RowIndex];

                var str = clickedRow.Cells[0].Value.ToString();
                var borrorwerManger = new BorrorwerManger();
                Borrower borrower = borrorwerManger.FindBorrower(int.Parse(str));
                borrowerBindingSource.DataSource = borrower;
            }
        }
    }
}
