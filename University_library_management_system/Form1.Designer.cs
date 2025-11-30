namespace University_library_management_system
{
    partial class BooksForm
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
            this.dataGridViewDisplayBook = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.butClear = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.butUpdateBook = new System.Windows.Forms.Button();
            this.butRemoveBook = new System.Windows.Forms.Button();
            this.labBookTitle = new System.Windows.Forms.Label();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labPublishYear = new System.Windows.Forms.Label();
            this.labstatus = new System.Windows.Forms.Label();
            this.dTPPublishYear = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDisplayBook
            // 
            this.dataGridViewDisplayBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayBook.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDisplayBook.Location = new System.Drawing.Point(521, 52);
            this.dataGridViewDisplayBook.Name = "dataGridViewDisplayBook";
            this.dataGridViewDisplayBook.RowHeadersVisible = false;
            this.dataGridViewDisplayBook.RowHeadersWidth = 62;
            this.dataGridViewDisplayBook.RowTemplate.Height = 29;
            this.dataGridViewDisplayBook.Size = new System.Drawing.Size(588, 497);
            this.dataGridViewDisplayBook.TabIndex = 11;
            this.dataGridViewDisplayBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplayBook_CellClick);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(254, 140);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 27);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Title";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(254, 202);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 27);
            this.txtAuthor.TabIndex = 2;
            this.txtAuthor.Text = "Author";
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(211, 487);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 32);
            this.butClear.TabIndex = 10;
            this.butClear.Text = "مسح";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(102, 439);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 37);
            this.butAdd.TabIndex = 7;
            this.butAdd.Text = "اضافه";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // butUpdateBook
            // 
            this.butUpdateBook.Location = new System.Drawing.Point(211, 435);
            this.butUpdateBook.Name = "butUpdateBook";
            this.butUpdateBook.Size = new System.Drawing.Size(75, 41);
            this.butUpdateBook.TabIndex = 8;
            this.butUpdateBook.Text = "تحديث";
            this.butUpdateBook.UseVisualStyleBackColor = true;
            this.butUpdateBook.Click += new System.EventHandler(this.butUpdateBook_Click);
            // 
            // butRemoveBook
            // 
            this.butRemoveBook.Location = new System.Drawing.Point(102, 482);
            this.butRemoveBook.Name = "butRemoveBook";
            this.butRemoveBook.Size = new System.Drawing.Size(75, 37);
            this.butRemoveBook.TabIndex = 9;
            this.butRemoveBook.Text = "حذف";
            this.butRemoveBook.UseVisualStyleBackColor = true;
            this.butRemoveBook.Click += new System.EventHandler(this.butRemoveBook_Click);
            // 
            // labBookTitle
            // 
            this.labBookTitle.AutoSize = true;
            this.labBookTitle.Location = new System.Drawing.Point(98, 140);
            this.labBookTitle.Name = "labBookTitle";
            this.labBookTitle.Size = new System.Drawing.Size(80, 19);
            this.labBookTitle.TabIndex = 12;
            this.labBookTitle.Text = "Book Title";
            // 
            // labAuthor
            // 
            this.labAuthor.AutoSize = true;
            this.labAuthor.Location = new System.Drawing.Point(98, 205);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(58, 19);
            this.labAuthor.TabIndex = 13;
            this.labAuthor.Text = "Author";
            // 
            // labPublishYear
            // 
            this.labPublishYear.AutoSize = true;
            this.labPublishYear.Location = new System.Drawing.Point(98, 286);
            this.labPublishYear.Name = "labPublishYear";
            this.labPublishYear.Size = new System.Drawing.Size(92, 19);
            this.labPublishYear.TabIndex = 14;
            this.labPublishYear.Text = "PublishYear";
            // 
            // labstatus
            // 
            this.labstatus.AutoSize = true;
            this.labstatus.Location = new System.Drawing.Point(102, 350);
            this.labstatus.Name = "labstatus";
            this.labstatus.Size = new System.Drawing.Size(52, 19);
            this.labstatus.TabIndex = 15;
            this.labstatus.Text = "النسخ";
            // 
            // dTPPublishYear
            // 
            this.dTPPublishYear.Location = new System.Drawing.Point(233, 286);
            this.dTPPublishYear.Name = "dTPPublishYear";
            this.dTPPublishYear.Size = new System.Drawing.Size(200, 27);
            this.dTPPublishYear.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(233, 350);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 27);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 607);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dTPPublishYear);
            this.Controls.Add(this.labstatus);
            this.Controls.Add(this.labPublishYear);
            this.Controls.Add(this.labAuthor);
            this.Controls.Add(this.labBookTitle);
            this.Controls.Add(this.dataGridViewDisplayBook);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.butRemoveBook);
            this.Controls.Add(this.butUpdateBook);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtTitle);
            this.Name = "BooksForm";
            this.Text = "Books Form";
            this.Load += new System.EventHandler(this.BooksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewDisplayBook;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butUpdateBook;
        private System.Windows.Forms.Button butRemoveBook;
        private System.Windows.Forms.Label labBookTitle;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labPublishYear;
        private System.Windows.Forms.Label labstatus;
        private System.Windows.Forms.DateTimePicker dTPPublishYear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

