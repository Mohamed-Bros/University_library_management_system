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
            System.Windows.Forms.Label book_IDLabel;
            System.Windows.Forms.Label borrower_IDLabel;
            System.Windows.Forms.Label borrowing_IDLabel;
            System.Windows.Forms.Label date_BorrowedLabel;
            System.Windows.Forms.Label date_ReturnedLabel;
            System.Windows.Forms.Label due_DateLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.book_IDComboBox = new System.Windows.Forms.ComboBox();
            this.borrower_IDComboBox = new System.Windows.Forms.ComboBox();
            this.borrowing_IDTextBox = new System.Windows.Forms.TextBox();
            this.date_BorrowedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.due_DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cobBorrower_IDFilter = new System.Windows.Forms.ComboBox();
            this.cobBook_IDFilter = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.date_ReturnedTextBox = new System.Windows.Forms.TextBox();
            this.borrowingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btmReturn = new System.Windows.Forms.Button();
            author_IDLabel1 = new System.Windows.Forms.Label();
            category_IDLabel1 = new System.Windows.Forms.Label();
            book_IDLabel = new System.Windows.Forms.Label();
            borrower_IDLabel = new System.Windows.Forms.Label();
            borrowing_IDLabel = new System.Windows.Forms.Label();
            date_BorrowedLabel = new System.Windows.Forms.Label();
            date_ReturnedLabel = new System.Windows.Forms.Label();
            due_DateLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // author_IDLabel1
            // 
            author_IDLabel1.AutoSize = true;
            author_IDLabel1.Location = new System.Drawing.Point(876, 50);
            author_IDLabel1.Name = "author_IDLabel1";
            author_IDLabel1.Size = new System.Drawing.Size(65, 19);
            author_IDLabel1.TabIndex = 22;
            author_IDLabel1.Text = ":المؤالف";
            // 
            // category_IDLabel1
            // 
            category_IDLabel1.AutoSize = true;
            category_IDLabel1.Location = new System.Drawing.Point(553, 50);
            category_IDLabel1.Name = "category_IDLabel1";
            category_IDLabel1.Size = new System.Drawing.Size(56, 19);
            category_IDLabel1.TabIndex = 24;
            category_IDLabel1.Text = ":الفئات";
            // 
            // book_IDLabel
            // 
            book_IDLabel.AutoSize = true;
            book_IDLabel.Location = new System.Drawing.Point(663, 124);
            book_IDLabel.Name = "book_IDLabel";
            book_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            book_IDLabel.Size = new System.Drawing.Size(57, 19);
            book_IDLabel.TabIndex = 0;
            book_IDLabel.Text = "الكتاب:";
            // 
            // borrower_IDLabel
            // 
            borrower_IDLabel.AutoSize = true;
            borrower_IDLabel.Location = new System.Drawing.Point(663, 157);
            borrower_IDLabel.Name = "borrower_IDLabel";
            borrower_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            borrower_IDLabel.Size = new System.Drawing.Size(72, 19);
            borrower_IDLabel.TabIndex = 2;
            borrower_IDLabel.Text = "المستعير";
            // 
            // borrowing_IDLabel
            // 
            borrowing_IDLabel.AutoSize = true;
            borrowing_IDLabel.Location = new System.Drawing.Point(663, 90);
            borrowing_IDLabel.Name = "borrowing_IDLabel";
            borrowing_IDLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            borrowing_IDLabel.Size = new System.Drawing.Size(105, 19);
            borrowing_IDLabel.TabIndex = 4;
            borrowing_IDLabel.Text = "الاستعرات ID:";
            // 
            // date_BorrowedLabel
            // 
            date_BorrowedLabel.AutoSize = true;
            date_BorrowedLabel.Location = new System.Drawing.Point(251, 94);
            date_BorrowedLabel.Name = "date_BorrowedLabel";
            date_BorrowedLabel.Size = new System.Drawing.Size(107, 19);
            date_BorrowedLabel.TabIndex = 6;
            date_BorrowedLabel.Text = "تاريخ الاستعاره";
            // 
            // date_ReturnedLabel
            // 
            date_ReturnedLabel.AutoSize = true;
            date_ReturnedLabel.Location = new System.Drawing.Point(268, 161);
            date_ReturnedLabel.Name = "date_ReturnedLabel";
            date_ReturnedLabel.Size = new System.Drawing.Size(90, 19);
            date_ReturnedLabel.TabIndex = 8;
            date_ReturnedLabel.Text = "تاريخ الارجاع";
            // 
            // due_DateLabel
            // 
            due_DateLabel.AutoSize = true;
            due_DateLabel.Location = new System.Drawing.Point(251, 127);
            due_DateLabel.Name = "due_DateLabel";
            due_DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            due_DateLabel.Size = new System.Drawing.Size(149, 19);
            due_DateLabel.TabIndex = 10;
            due_DateLabel.Text = "تاريخ الارجاع المتوقع:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDisplay, 0, 2);
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
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(10, 462);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersVisible = false;
            this.dataGridViewDisplay.RowHeadersWidth = 62;
            this.dataGridViewDisplay.RowTemplate.Height = 29;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(1160, 296);
            this.dataGridViewDisplay.TabIndex = 17;
            this.dataGridViewDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellClick);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.36797F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.63203F));
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
            this.panel2.Controls.Add(this.btmReturn);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnDelet);
            this.panel2.Controls.Add(this.btnupdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 311);
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
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.btnDelet.Click += new System.EventHandler(this.btnDelet_Click);
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
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
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
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.date_ReturnedTextBox);
            this.panel1.Controls.Add(book_IDLabel);
            this.panel1.Controls.Add(this.book_IDComboBox);
            this.panel1.Controls.Add(borrower_IDLabel);
            this.panel1.Controls.Add(this.borrower_IDComboBox);
            this.panel1.Controls.Add(borrowing_IDLabel);
            this.panel1.Controls.Add(this.borrowing_IDTextBox);
            this.panel1.Controls.Add(date_BorrowedLabel);
            this.panel1.Controls.Add(this.date_BorrowedDateTimePicker);
            this.panel1.Controls.Add(date_ReturnedLabel);
            this.panel1.Controls.Add(due_DateLabel);
            this.panel1.Controls.Add(this.due_DateDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(383, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 311);
            this.panel1.TabIndex = 2;
            // 
            // book_IDComboBox
            // 
            this.book_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.borrowingBindingSource, "Book_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-1"));
            this.book_IDComboBox.FormattingEnabled = true;
            this.book_IDComboBox.Location = new System.Drawing.Point(421, 121);
            this.book_IDComboBox.Name = "book_IDComboBox";
            this.book_IDComboBox.Size = new System.Drawing.Size(200, 27);
            this.book_IDComboBox.TabIndex = 1;
            // 
            // borrower_IDComboBox
            // 
            this.borrower_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.borrowingBindingSource, "Borrower_ID", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "-1"));
            this.borrower_IDComboBox.FormattingEnabled = true;
            this.borrower_IDComboBox.Location = new System.Drawing.Point(421, 154);
            this.borrower_IDComboBox.Name = "borrower_IDComboBox";
            this.borrower_IDComboBox.Size = new System.Drawing.Size(200, 27);
            this.borrower_IDComboBox.TabIndex = 3;
            // 
            // borrowing_IDTextBox
            // 
            this.borrowing_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowingBindingSource, "Borrowing_ID", true));
            this.borrowing_IDTextBox.Location = new System.Drawing.Point(421, 87);
            this.borrowing_IDTextBox.Name = "borrowing_IDTextBox";
            this.borrowing_IDTextBox.Size = new System.Drawing.Size(200, 27);
            this.borrowing_IDTextBox.TabIndex = 5;
            // 
            // date_BorrowedDateTimePicker
            // 
            this.date_BorrowedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.borrowingBindingSource, "Date_Borrowed", true));
            this.date_BorrowedDateTimePicker.Location = new System.Drawing.Point(28, 90);
            this.date_BorrowedDateTimePicker.Name = "date_BorrowedDateTimePicker";
            this.date_BorrowedDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.date_BorrowedDateTimePicker.TabIndex = 7;
            // 
            // due_DateDateTimePicker
            // 
            this.due_DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.borrowingBindingSource, "Due_Date", true));
            this.due_DateDateTimePicker.Location = new System.Drawing.Point(28, 123);
            this.due_DateDateTimePicker.Name = "due_DateDateTimePicker";
            this.due_DateDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.due_DateDateTimePicker.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.cobBorrower_IDFilter);
            this.panel3.Controls.Add(this.cobBook_IDFilter);
            this.panel3.Controls.Add(author_IDLabel1);
            this.panel3.Controls.Add(category_IDLabel1);
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
            // cobBorrower_IDFilter
            // 
            this.cobBorrower_IDFilter.FormattingEnabled = true;
            this.cobBorrower_IDFilter.Location = new System.Drawing.Point(634, 47);
            this.cobBorrower_IDFilter.Name = "cobBorrower_IDFilter";
            this.cobBorrower_IDFilter.Size = new System.Drawing.Size(225, 27);
            this.cobBorrower_IDFilter.TabIndex = 30;
            // 
            // cobBook_IDFilter
            // 
            this.cobBook_IDFilter.FormattingEnabled = true;
            this.cobBook_IDFilter.Location = new System.Drawing.Point(359, 47);
            this.cobBook_IDFilter.Name = "cobBook_IDFilter";
            this.cobBook_IDFilter.Size = new System.Drawing.Size(188, 27);
            this.cobBook_IDFilter.TabIndex = 29;
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
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // date_ReturnedTextBox
            // 
            this.date_ReturnedTextBox.BackColor = System.Drawing.Color.White;
            this.date_ReturnedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowingBindingSource, "Date_Returned", true));
            this.date_ReturnedTextBox.Location = new System.Drawing.Point(28, 161);
            this.date_ReturnedTextBox.Name = "date_ReturnedTextBox";
            this.date_ReturnedTextBox.ReadOnly = true;
            this.date_ReturnedTextBox.Size = new System.Drawing.Size(200, 27);
            this.date_ReturnedTextBox.TabIndex = 12;
            // 
            // borrowingBindingSource
            // 
            this.borrowingBindingSource.DataSource = typeof(DataAccessLayer.Data.Borrowing);
            // 
            // btmReturn
            // 
            this.btmReturn.BackColor = System.Drawing.Color.LimeGreen;
            this.btmReturn.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.btmReturn.ForeColor = System.Drawing.Color.White;
            this.btmReturn.Location = new System.Drawing.Point(105, 208);
            this.btmReturn.Name = "btmReturn";
            this.btmReturn.Size = new System.Drawing.Size(155, 52);
            this.btmReturn.TabIndex = 22;
            this.btmReturn.Text = "إرجاع";
            this.btmReturn.UseVisualStyleBackColor = false;
            this.btmReturn.Click += new System.EventHandler(this.btmReturn_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cobBorrower_IDFilter;
        private System.Windows.Forms.ComboBox cobBook_IDFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox book_IDComboBox;
        private System.Windows.Forms.BindingSource borrowingBindingSource;
        private System.Windows.Forms.ComboBox borrower_IDComboBox;
        private System.Windows.Forms.TextBox borrowing_IDTextBox;
        private System.Windows.Forms.DateTimePicker date_BorrowedDateTimePicker;
        private System.Windows.Forms.DateTimePicker due_DateDateTimePicker;
        private System.Windows.Forms.TextBox date_ReturnedTextBox;
        private System.Windows.Forms.Button btmReturn;
    }
}