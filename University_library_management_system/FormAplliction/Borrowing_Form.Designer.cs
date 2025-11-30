namespace University_library_management_system.FormAplliction
{
    partial class Borrowing_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label author_IDLabel1;
            System.Windows.Forms.Label category_IDLabel1;
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label book_IDLabel;
            System.Windows.Forms.Label borrower_IDLabel;
            System.Windows.Forms.Label borrowing_IDLabel;
            System.Windows.Forms.Label date_BorrowedLabel;
            System.Windows.Forms.Label date_ReturnedLabel;
            System.Windows.Forms.Label due_DateLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDisplayBook = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cobAuthor_IDFilter = new System.Windows.Forms.ComboBox();
            this.cobCategory_IDFilter = new System.Windows.Forms.ComboBox();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_IDComboBox = new System.Windows.Forms.ComboBox();
            this.borrower_IDComboBox = new System.Windows.Forms.ComboBox();
            this.borrowing_IDTextBox = new System.Windows.Forms.TextBox();
            this.date_BorrowedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date_ReturnedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.due_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            author_IDLabel1 = new System.Windows.Forms.Label();
            category_IDLabel1 = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            book_IDLabel = new System.Windows.Forms.Label();
            borrower_IDLabel = new System.Windows.Forms.Label();
            borrowing_IDLabel = new System.Windows.Forms.Label();
            date_BorrowedLabel = new System.Windows.Forms.Label();
            date_ReturnedLabel = new System.Windows.Forms.Label();
            due_DateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayBook)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDisplayBook, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.30717F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.69283F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 308F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 768);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // dataGridViewDisplayBook
            // 
            this.dataGridViewDisplayBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisplayBook.Location = new System.Drawing.Point(10, 462);
            this.dataGridViewDisplayBook.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.dataGridViewDisplayBook.Name = "dataGridViewDisplayBook";
            this.dataGridViewDisplayBook.RowHeadersVisible = false;
            this.dataGridViewDisplayBook.RowHeadersWidth = 62;
            this.dataGridViewDisplayBook.RowTemplate.Height = 29;
            this.dataGridViewDisplayBook.Size = new System.Drawing.Size(1160, 296);
            this.dataGridViewDisplayBook.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.10811F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.89189F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1174, 317);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDelet);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 311);
            this.panel2.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClear.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(186, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 52);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "مسح";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelet
            // 
            this.btnDelet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDelet.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelet.ForeColor = System.Drawing.Color.White;
            this.btnDelet.Location = new System.Drawing.Point(16, 120);
            this.btnDelet.Name = "btnDelet";
            this.btnDelet.Size = new System.Drawing.Size(155, 52);
            this.btnDelet.TabIndex = 20;
            this.btnDelet.Text = "حذف";
            this.btnDelet.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LimeGreen;
            this.btnupdate.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.Location = new System.Drawing.Point(186, 37);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(155, 52);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "تحديث";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(16, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 52);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "إضافه";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(book_IDLabel);
            this.panel1.Controls.Add(this.book_IDComboBox);
            this.panel1.Controls.Add(borrower_IDLabel);
            this.panel1.Controls.Add(this.borrower_IDComboBox);
            this.panel1.Controls.Add(borrowing_IDLabel);
            this.panel1.Controls.Add(this.borrowing_IDTextBox);
            this.panel1.Controls.Add(date_BorrowedLabel);
            this.panel1.Controls.Add(this.date_BorrowedDateTimePicker);
            this.panel1.Controls.Add(date_ReturnedLabel);
            this.panel1.Controls.Add(this.date_ReturnedDateTimePicker);
            this.panel1.Controls.Add(due_DateLabel);
            this.panel1.Controls.Add(this.due_DateDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(391, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 311);
            this.panel1.TabIndex = 2;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(DataAccessLayer.Data.Book);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cobAuthor_IDFilter);
            this.panel3.Controls.Add(this.cobCategory_IDFilter);
            this.panel3.Controls.Add(author_IDLabel1);
            this.panel3.Controls.Add(category_IDLabel1);
            this.panel3.Controls.Add(titleLabel1);
            this.panel3.Controls.Add(this.titleTextBox1);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 326);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(1174, 130);
            this.panel3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1021, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "فلتره";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(1087, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 3);
            this.panel5.TabIndex = 32;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(28, 11);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 3);
            this.panel4.TabIndex = 31;
            // 
            // cobAuthor_IDFilter
            // 
            this.cobAuthor_IDFilter.FormattingEnabled = true;
            this.cobAuthor_IDFilter.Location = new System.Drawing.Point(544, 38);
            this.cobAuthor_IDFilter.Name = "cobAuthor_IDFilter";
            this.cobAuthor_IDFilter.Size = new System.Drawing.Size(225, 27);
            this.cobAuthor_IDFilter.TabIndex = 30;
            // 
            // cobCategory_IDFilter
            // 
            this.cobCategory_IDFilter.FormattingEnabled = true;
            this.cobCategory_IDFilter.Location = new System.Drawing.Point(269, 38);
            this.cobCategory_IDFilter.Name = "cobCategory_IDFilter";
            this.cobCategory_IDFilter.Size = new System.Drawing.Size(188, 27);
            this.cobCategory_IDFilter.TabIndex = 29;
            // 
            // author_IDLabel1
            // 
            author_IDLabel1.AutoSize = true;
            author_IDLabel1.Location = new System.Drawing.Point(786, 41);
            author_IDLabel1.Name = "author_IDLabel1";
            author_IDLabel1.Size = new System.Drawing.Size(65, 19);
            author_IDLabel1.TabIndex = 22;
            author_IDLabel1.Text = ":المؤالف";
            // 
            // category_IDLabel1
            // 
            category_IDLabel1.AutoSize = true;
            category_IDLabel1.Location = new System.Drawing.Point(463, 41);
            category_IDLabel1.Name = "category_IDLabel1";
            category_IDLabel1.Size = new System.Drawing.Size(56, 19);
            category_IDLabel1.TabIndex = 24;
            category_IDLabel1.Text = ":الفئات";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(1050, 41);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(60, 19);
            titleLabel1.TabIndex = 26;
            titleLabel1.Text = ":العنوان";
            // 
            // titleTextBox1
            // 
            this.titleTextBox1.Location = new System.Drawing.Point(873, 38);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(171, 27);
            this.titleTextBox1.TabIndex = 27;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFilter.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btnFilter.ForeColor = System.Drawing.Color.White;
            this.btnFilter.Location = new System.Drawing.Point(79, 31);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(155, 52);
            this.btnFilter.TabIndex = 22;
            this.btnFilter.Text = "فلتره";
            this.btnFilter.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataSource = typeof(DataAccessLayer.Data.Borrowing);
            // 
            // book_IDLabel
            // 
            book_IDLabel.AutoSize = true;
            book_IDLabel.Location = new System.Drawing.Point(581, 56);
            book_IDLabel.Name = "book_IDLabel";
            book_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            book_IDLabel.Size = new System.Drawing.Size(57, 19);
            book_IDLabel.TabIndex = 0;
            book_IDLabel.Text = "الكتاب:";
            // 
            // book_IDComboBox
            // 
            this.book_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowingBindingSource, "Book_ID", true));
            this.book_IDComboBox.FormattingEnabled = true;
            this.book_IDComboBox.Location = new System.Drawing.Point(339, 53);
            this.book_IDComboBox.Name = "book_IDComboBox";
            this.book_IDComboBox.Size = new System.Drawing.Size(200, 27);
            this.book_IDComboBox.TabIndex = 1;
            // 
            // borrower_IDLabel
            // 
            borrower_IDLabel.AutoSize = true;
            borrower_IDLabel.Location = new System.Drawing.Point(581, 89);
            borrower_IDLabel.Name = "borrower_IDLabel";
            borrower_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            borrower_IDLabel.Size = new System.Drawing.Size(72, 19);
            borrower_IDLabel.TabIndex = 2;
            borrower_IDLabel.Text = "المستعير";
            // 
            // borrower_IDComboBox
            // 
            this.borrower_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowingBindingSource, "Borrower_ID", true));
            this.borrower_IDComboBox.FormattingEnabled = true;
            this.borrower_IDComboBox.Location = new System.Drawing.Point(339, 86);
            this.borrower_IDComboBox.Name = "borrower_IDComboBox";
            this.borrower_IDComboBox.Size = new System.Drawing.Size(200, 27);
            this.borrower_IDComboBox.TabIndex = 3;
            // 
            // borrowing_IDLabel
            // 
            borrowing_IDLabel.AutoSize = true;
            borrowing_IDLabel.Location = new System.Drawing.Point(581, 122);
            borrowing_IDLabel.Name = "borrowing_IDLabel";
            borrowing_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            borrowing_IDLabel.Size = new System.Drawing.Size(105, 19);
            borrowing_IDLabel.TabIndex = 4;
            borrowing_IDLabel.Text = "الاستعرات ID:";
            // 
            // borrowing_IDTextBox
            // 
            this.borrowing_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowingBindingSource, "Borrowing_ID", true));
            this.borrowing_IDTextBox.Location = new System.Drawing.Point(339, 119);
            this.borrowing_IDTextBox.Name = "borrowing_IDTextBox";
            this.borrowing_IDTextBox.Size = new System.Drawing.Size(200, 27);
            this.borrowing_IDTextBox.TabIndex = 5;
            // 
            // date_BorrowedLabel
            // 
            date_BorrowedLabel.AutoSize = true;
            date_BorrowedLabel.Location = new System.Drawing.Point(581, 156);
            date_BorrowedLabel.Name = "date_BorrowedLabel";
            date_BorrowedLabel.Size = new System.Drawing.Size(107, 19);
            date_BorrowedLabel.TabIndex = 6;
            date_BorrowedLabel.Text = "تاريخ الاستعاره";
            // 
            // date_BorrowedDateTimePicker
            // 
            this.date_BorrowedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.borrowingBindingSource, "Date_Borrowed", true));
            this.date_BorrowedDateTimePicker.Location = new System.Drawing.Point(339, 152);
            this.date_BorrowedDateTimePicker.Name = "date_BorrowedDateTimePicker";
            this.date_BorrowedDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.date_BorrowedDateTimePicker.TabIndex = 7;
            // 
            // date_ReturnedLabel
            // 
            date_ReturnedLabel.AutoSize = true;
            date_ReturnedLabel.Location = new System.Drawing.Point(581, 189);
            date_ReturnedLabel.Name = "date_ReturnedLabel";
            date_ReturnedLabel.Size = new System.Drawing.Size(90, 19);
            date_ReturnedLabel.TabIndex = 8;
            date_ReturnedLabel.Text = "تاريخ الارجاع";
            // 
            // date_ReturnedDateTimePicker
            // 
            this.date_ReturnedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.borrowingBindingSource, "Date_Returned", true));
            this.date_ReturnedDateTimePicker.Location = new System.Drawing.Point(339, 185);
            this.date_ReturnedDateTimePicker.Name = "date_ReturnedDateTimePicker";
            this.date_ReturnedDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.date_ReturnedDateTimePicker.TabIndex = 9;
            // 
            // due_DateLabel
            // 
            due_DateLabel.AutoSize = true;
            due_DateLabel.Location = new System.Drawing.Point(581, 222);
            due_DateLabel.Name = "due_DateLabel";
            due_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            due_DateLabel.Size = new System.Drawing.Size(149, 19);
            due_DateLabel.TabIndex = 10;
            due_DateLabel.Text = "تاريخ الارجاع المتوقع:";
            // 
            // due_DateDateTimePicker
            // 
            this.due_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.borrowingBindingSource, "Due_Date", true));
            this.due_DateDateTimePicker.Location = new System.Drawing.Point(339, 218);
            this.due_DateDateTimePicker.Name = "due_DateDateTimePicker";
            this.due_DateDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.due_DateDateTimePicker.TabIndex = 11;
            // 
            // Borrowing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrowing_Form";
            this.Text = "Borrowing_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayBook)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewDisplayBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cobAuthor_IDFilter;
        private System.Windows.Forms.ComboBox cobCategory_IDFilter;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox book_IDComboBox;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private System.Windows.Forms.ComboBox borrower_IDComboBox;
        private System.Windows.Forms.TextBox borrowing_IDTextBox;
        private System.Windows.Forms.DateTimePicker date_BorrowedDateTimePicker;
        private System.Windows.Forms.DateTimePicker date_ReturnedDateTimePicker;
        private System.Windows.Forms.DateTimePicker due_DateDateTimePicker;
    }
}