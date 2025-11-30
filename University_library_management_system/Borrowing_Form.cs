using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer.Data;

namespace University_library_management_system
{
    public partial class Borrowing_Form : Form
    {

        UniversityLibraryManagementEntities contect = new UniversityLibraryManagementEntities();
        DataGridViewRow clickedRow = null;

        public Borrowing_Form()
        {
            InitializeComponent();
        }

        private void Borrowing_Form_Load(object sender, EventArgs e)
        {
            var bookList  = contect.Books.Where(x=>x.Copies>=1).ToList();
            var BorrowerList  = contect.Borrowers.ToList();

            combBooks.DataSource = bookList;
            combBooks.DisplayMember = nameof(Book.Title);
            combBooks.ValueMember = nameof(Book.Book_ID);

            comboBox2.DataSource = BorrowerList;
            comboBox2.DisplayMember = nameof(Borrower.Name);
            comboBox2.ValueMember = nameof(Borrower.Borrower_ID);
        }
    }
}
