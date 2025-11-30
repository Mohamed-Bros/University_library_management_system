using FluentValidation.Results;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Data;
using DataAccessLayer.DateValidation;

namespace University_library_management_system
{
    public partial class Borrowers_Form : Form
    {
        UniversityLibraryManagementEntities contect = new UniversityLibraryManagementEntities();
        DataGridViewRow clickedRow = null;

        public Borrowers_Form()
        {
            InitializeComponent();
        }

        private void Borrowers_Form_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        //يتحقق ان القيم المضلوبه ليست صحيحه
        bool CheckValue(Borrower borrower)
        {

            var validation = new BorrowesValidator(contect);
            ValidationResult result = validation.Validate(borrower);

            if (!result.IsValid)
            {

                errorProvider1.Clear();

                foreach (var failure in result.Errors)
                {

                    if (failure.PropertyName == nameof(Borrower.Name))
                    {
                        errorProvider1.SetError(txtName, failure.ErrorMessage);
                    }
                    else if (failure.PropertyName == nameof(Borrower.Phone_Number))
                    {
                        errorProvider1.SetError(txtPhon, failure.ErrorMessage);
                    }

                }
                return false;
            }
            return true;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();

            
            borrower.Name = txtName.Text;
            borrower.Phone_Number = txtPhon.Text;
            borrower.Address = txtِAddress.Text;




            if (CheckValue(borrower))
            {
                contect.Borrowers.Add(borrower);
                
                contect.SaveChanges();

                UpdateTable();
                errorProvider1.Clear();
            }
        }

        private void butUpdateBook_Click(object sender, EventArgs e)
        {
            if (clickedRow != null)
            {
                int idBorrowers = int.Parse(clickedRow.Cells[0].Value.ToString());

                Borrower borrower = contect.Borrowers.Find(idBorrowers);

                if (borrower != null)
                {
                    borrower.Name = txtName.Text;
                    borrower.Phone_Number = txtPhon.Text;
                    borrower.Address = txtِAddress.Text;
                    
                }

                if (CheckValue(borrower))
                {
                    contect.SaveChanges();
                    errorProvider1.Clear();

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
            txtName.Text = "";
            txtPhon.Text = "";
            txtِAddress.Text = "";
        }

        private void butRemoveBook_Click(object sender, EventArgs e)
        {
            
            if (clickedRow != null)
            {
                int idBorrowers = int.Parse(clickedRow.Cells[0].Value.ToString());

                Borrower borrower = contect.Borrowers.Find(idBorrowers);

                if (borrower != null)
                {
                    
                    contect.Borrowers.Remove(borrower);
                    contect.SaveChanges();

                    clickedRow = null; 
                    //تحديث الجدوال
                    UpdateTable();
                }



            }
            else
            {
                MessageBox.Show("حدد صف من اجل الحذف");
            }
        }

        private void dataGridVieBorrowerswDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            if (e.RowIndex >= 0)
            {
                clickedRow = dataGridViewBorrowersw.Rows[e.RowIndex];

                var str = clickedRow.Cells[0].Value.ToString();

                Borrower borrorwer = contect.Borrowers.Find(int.Parse(str));

                txtName.Text = borrorwer.Name;
                txtPhon.Text = borrorwer.Phone_Number;
                txtِAddress.Text = borrorwer.Address;
            }
        }

        private void UpdateTable()
        {
            var borrowersList = contect.Borrowers.Select(x =>new
            {
                x.Borrower_ID,
                x.Name,
                x.Phone_Number,
                x.Address,
            }).ToList();
            dataGridViewBorrowersw.DataSource = borrowersList;
            dataGridViewBorrowersw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
    }
}
