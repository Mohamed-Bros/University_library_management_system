namespace University_library_management_system
{
    partial class Borrowers_Form
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
            this.dataGridViewBorrowersw = new System.Windows.Forms.DataGridView();
            this.butRemoveBook = new System.Windows.Forms.Button();
            this.butUpdateBook = new System.Windows.Forms.Button();
            this.butAdd = new System.Windows.Forms.Button();
            this.txtِAddress = new System.Windows.Forms.TextBox();
            this.txtPhon = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowersw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBorrowersw
            // 
            this.dataGridViewBorrowersw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBorrowersw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewBorrowersw.Location = new System.Drawing.Point(425, 47);
            this.dataGridViewBorrowersw.Name = "dataGridViewBorrowersw";
            this.dataGridViewBorrowersw.RowHeadersWidth = 62;
            this.dataGridViewBorrowersw.RowTemplate.Height = 29;
            this.dataGridViewBorrowersw.Size = new System.Drawing.Size(718, 455);
            this.dataGridViewBorrowersw.TabIndex = 23;
            this.dataGridViewBorrowersw.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridVieBorrowerswDisplay_CellClick);
            // 
            // butRemoveBook
            // 
            this.butRemoveBook.Location = new System.Drawing.Point(143, 361);
            this.butRemoveBook.Name = "butRemoveBook";
            this.butRemoveBook.Size = new System.Drawing.Size(75, 37);
            this.butRemoveBook.TabIndex = 21;
            this.butRemoveBook.Text = "حذف";
            this.butRemoveBook.UseVisualStyleBackColor = true;
            this.butRemoveBook.Click += new System.EventHandler(this.butRemoveBook_Click);
            // 
            // butUpdateBook
            // 
            this.butUpdateBook.Location = new System.Drawing.Point(235, 298);
            this.butUpdateBook.Name = "butUpdateBook";
            this.butUpdateBook.Size = new System.Drawing.Size(75, 41);
            this.butUpdateBook.TabIndex = 20;
            this.butUpdateBook.Text = "تحديث";
            this.butUpdateBook.UseVisualStyleBackColor = true;
            this.butUpdateBook.Click += new System.EventHandler(this.butUpdateBook_Click);
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(134, 298);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(75, 37);
            this.butAdd.TabIndex = 19;
            this.butAdd.Text = "اضافه";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.butAdd_Click);
            // 
            // txtِAddress
            // 
            this.txtِAddress.Location = new System.Drawing.Point(247, 196);
            this.txtِAddress.Name = "txtِAddress";
            this.txtِAddress.Size = new System.Drawing.Size(100, 27);
            this.txtِAddress.TabIndex = 15;
            this.txtِAddress.Text = "PublishYear";
            // 
            // txtPhon
            // 
            this.txtPhon.Location = new System.Drawing.Point(247, 130);
            this.txtPhon.Name = "txtPhon";
            this.txtPhon.Size = new System.Drawing.Size(100, 27);
            this.txtPhon.TabIndex = 14;
            this.txtPhon.Text = "Author";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(247, 87);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 27);
            this.txtName.TabIndex = 13;
            this.txtName.Text = "الاسم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "الاسم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "العنوان";
            // 
            // butClear
            // 
            this.butClear.Location = new System.Drawing.Point(247, 361);
            this.butClear.Name = "butClear";
            this.butClear.Size = new System.Drawing.Size(75, 32);
            this.butClear.TabIndex = 29;
            this.butClear.Text = "مسح";
            this.butClear.UseVisualStyleBackColor = true;
            this.butClear.Click += new System.EventHandler(this.butClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Borrowers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 632);
            this.Controls.Add(this.butClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBorrowersw);
            this.Controls.Add(this.butRemoveBook);
            this.Controls.Add(this.butUpdateBook);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.txtِAddress);
            this.Controls.Add(this.txtPhon);
            this.Controls.Add(this.txtName);
            this.Name = "Borrowers_Form";
            this.Text = "Borrowers_Form";
            this.Load += new System.EventHandler(this.Borrowers_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBorrowersw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBorrowersw;
        private System.Windows.Forms.Button butRemoveBook;
        private System.Windows.Forms.Button butUpdateBook;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.TextBox txtِAddress;
        private System.Windows.Forms.TextBox txtPhon;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butClear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}