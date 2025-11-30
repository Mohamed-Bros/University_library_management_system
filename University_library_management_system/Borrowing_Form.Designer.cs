namespace University_library_management_system
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
            this.combBooks = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.cobReturned = new System.Windows.Forms.ComboBox();
            this.dataGridViewDisplayMetaphors = new System.Windows.Forms.DataGridView();
            this.butReturnBook = new System.Windows.Forms.Button();
            this.butRemoveBook = new System.Windows.Forms.Button();
            this.butAmendment = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayMetaphors)).BeginInit();
            this.SuspendLayout();
            // 
            // combBooks
            // 
            this.combBooks.FormattingEnabled = true;
            this.combBooks.Location = new System.Drawing.Point(145, 73);
            this.combBooks.Name = "combBooks";
            this.combBooks.Size = new System.Drawing.Size(121, 27);
            this.combBooks.TabIndex = 0;
            this.combBooks.Text = "سم المستعير";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(145, 127);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.Text = "اسم الكتاب";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.Location = new System.Drawing.Point(145, 194);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(200, 27);
            this.dtpBorrowDate.TabIndex = 2;
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Location = new System.Drawing.Point(174, 253);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(200, 27);
            this.dtpReturnDate.TabIndex = 3;
            // 
            // cobReturned
            // 
            this.cobReturned.FormattingEnabled = true;
            this.cobReturned.Items.AddRange(new object[] {
            "تم الارجاع",
            "لم يرجع "});
            this.cobReturned.Location = new System.Drawing.Point(157, 347);
            this.cobReturned.Name = "cobReturned";
            this.cobReturned.Size = new System.Drawing.Size(121, 27);
            this.cobReturned.TabIndex = 4;
            // 
            // dataGridViewDisplayMetaphors
            // 
            this.dataGridViewDisplayMetaphors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayMetaphors.Location = new System.Drawing.Point(512, 12);
            this.dataGridViewDisplayMetaphors.Name = "dataGridViewDisplayMetaphors";
            this.dataGridViewDisplayMetaphors.RowHeadersWidth = 62;
            this.dataGridViewDisplayMetaphors.RowTemplate.Height = 29;
            this.dataGridViewDisplayMetaphors.Size = new System.Drawing.Size(536, 452);
            this.dataGridViewDisplayMetaphors.TabIndex = 28;
            // 
            // butReturnBook
            // 
            this.butReturnBook.Location = new System.Drawing.Point(145, 468);
            this.butReturnBook.Name = "butReturnBook";
            this.butReturnBook.Size = new System.Drawing.Size(135, 32);
            this.butReturnBook.TabIndex = 27;
            this.butReturnBook.Text = "ارجاع كتاب";
            this.butReturnBook.UseVisualStyleBackColor = true;
            // 
            // butRemoveBook
            // 
            this.butRemoveBook.Location = new System.Drawing.Point(64, 466);
            this.butRemoveBook.Name = "butRemoveBook";
            this.butRemoveBook.Size = new System.Drawing.Size(75, 37);
            this.butRemoveBook.TabIndex = 26;
            this.butRemoveBook.Text = "حذف";
            this.butRemoveBook.UseVisualStyleBackColor = true;
            // 
            // butAmendment
            // 
            this.butAmendment.Location = new System.Drawing.Point(156, 423);
            this.butAmendment.Name = "butAmendment";
            this.butAmendment.Size = new System.Drawing.Size(75, 41);
            this.butAmendment.TabIndex = 25;
            this.butAmendment.Text = "تعديل";
            this.butAmendment.UseVisualStyleBackColor = true;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(64, 423);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 37);
            this.butAdd.TabIndex = 24;
            this.butAdd.Text = "اضافه";
            this.butAdd.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "أسم المستعير";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "أسم الكتاب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "تاريخ الاستعاره";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "تراريخ الأرجاع المتوقع";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 33;
            this.label5.Text = "حاله الارجاع";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "تاريخ الارجاع";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 301);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // Borrowing_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 624);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDisplayMetaphors);
            this.Controls.Add(this.butReturnBook);
            this.Controls.Add(this.butRemoveBook);
            this.Controls.Add(this.butAmendment);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.cobReturned);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.combBooks);
            this.Name = "Borrowing_Form";
            this.Text = "Borrowing_Form";
            this.Load += new System.EventHandler(this.Borrowing_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayMetaphors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combBooks;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.ComboBox cobReturned;
        private System.Windows.Forms.DataGridView dataGridViewDisplayMetaphors;
        private System.Windows.Forms.Button butReturnBook;
        private System.Windows.Forms.Button butRemoveBook;
        private System.Windows.Forms.Button butAmendment;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}