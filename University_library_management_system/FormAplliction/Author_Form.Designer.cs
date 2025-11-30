namespace University_library_management_system.FormAplliction
{
    partial class Author_Form
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
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label author_IDLabel;
            System.Windows.Forms.Label category_IDLabel;
            System.Windows.Forms.Label copiesLabel;
            System.Windows.Forms.Label publication_YearLabel;
            System.Windows.Forms.Label titleLabel;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.titleTextBox1 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.publication_YearDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.copiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.category_IDComboBox = new System.Windows.Forms.ComboBox();
            this.author_IDComboBox = new System.Windows.Forms.ComboBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridViewDisplayBook = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            author_IDLabel = new System.Windows.Forms.Label();
            category_IDLabel = new System.Windows.Forms.Label();
            copiesLabel = new System.Windows.Forms.Label();
            publication_YearLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayBook)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(titleLabel1);
            this.panel3.Controls.Add(this.titleTextBox1);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 218);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(1152, 83);
            this.panel3.TabIndex = 19;
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
            // titleTextBox1
            // 
            this.titleTextBox1.Location = new System.Drawing.Point(423, 38);
            this.titleTextBox1.Name = "titleTextBox1";
            this.titleTextBox1.Size = new System.Drawing.Size(218, 27);
            this.titleTextBox1.TabIndex = 27;
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel1.Location = new System.Drawing.Point(647, 41);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(105, 19);
            titleLabel1.TabIndex = 26;
            titleLabel1.Text = ":اسم المؤلف";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(7, 17);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 3);
            this.panel4.TabIndex = 28;
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1152, 209);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(titleLabel);
            this.panel1.Controls.Add(this.author_IDComboBox);
            this.panel1.Controls.Add(publication_YearLabel);
            this.panel1.Controls.Add(copiesLabel);
            this.panel1.Controls.Add(this.category_IDComboBox);
            this.panel1.Controls.Add(category_IDLabel);
            this.panel1.Controls.Add(this.copiesNumericUpDown);
            this.panel1.Controls.Add(this.publication_YearDateTimePicker);
            this.panel1.Controls.Add(author_IDLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(384, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(765, 203);
            this.panel1.TabIndex = 2;
            // 
            // author_IDLabel
            // 
            author_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            author_IDLabel.AutoSize = true;
            author_IDLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            author_IDLabel.Location = new System.Drawing.Point(258, 53);
            author_IDLabel.Name = "author_IDLabel";
            author_IDLabel.Size = new System.Drawing.Size(70, 19);
            author_IDLabel.TabIndex = 9;
            author_IDLabel.Text = ":المؤالف";
            // 
            // publication_YearDateTimePicker
            // 
            this.publication_YearDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.publication_YearDateTimePicker.Location = new System.Drawing.Point(425, 74);
            this.publication_YearDateTimePicker.Name = "publication_YearDateTimePicker";
            this.publication_YearDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.publication_YearDateTimePicker.TabIndex = 14;
            // 
            // copiesNumericUpDown
            // 
            this.copiesNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copiesNumericUpDown.Location = new System.Drawing.Point(425, 113);
            this.copiesNumericUpDown.Name = "copiesNumericUpDown";
            this.copiesNumericUpDown.Size = new System.Drawing.Size(200, 27);
            this.copiesNumericUpDown.TabIndex = 12;
            // 
            // category_IDLabel
            // 
            category_IDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            category_IDLabel.AutoSize = true;
            category_IDLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_IDLabel.Location = new System.Drawing.Point(258, 98);
            category_IDLabel.Name = "category_IDLabel";
            category_IDLabel.Size = new System.Drawing.Size(53, 19);
            category_IDLabel.TabIndex = 17;
            category_IDLabel.Text = ":الفئاه";
            // 
            // category_IDComboBox
            // 
            this.category_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.category_IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category_IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.category_IDComboBox.FormattingEnabled = true;
            this.category_IDComboBox.Location = new System.Drawing.Point(28, 90);
            this.category_IDComboBox.Name = "category_IDComboBox";
            this.category_IDComboBox.Size = new System.Drawing.Size(200, 27);
            this.category_IDComboBox.TabIndex = 18;
            // 
            // copiesLabel
            // 
            copiesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            copiesLabel.AutoSize = true;
            copiesLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            copiesLabel.Location = new System.Drawing.Point(641, 115);
            copiesLabel.Name = "copiesLabel";
            copiesLabel.Size = new System.Drawing.Size(105, 19);
            copiesLabel.TabIndex = 11;
            copiesLabel.Text = ":عدد النسخه";
            // 
            // publication_YearLabel
            // 
            publication_YearLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            publication_YearLabel.AutoSize = true;
            publication_YearLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            publication_YearLabel.Location = new System.Drawing.Point(649, 80);
            publication_YearLabel.Name = "publication_YearLabel";
            publication_YearLabel.Size = new System.Drawing.Size(96, 19);
            publication_YearLabel.TabIndex = 13;
            publication_YearLabel.Text = ":تاريخ النشر";
            // 
            // author_IDComboBox
            // 
            this.author_IDComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.author_IDComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.author_IDComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.author_IDComboBox.FormattingEnabled = true;
            this.author_IDComboBox.Location = new System.Drawing.Point(28, 47);
            this.author_IDComboBox.Name = "author_IDComboBox";
            this.author_IDComboBox.Size = new System.Drawing.Size(200, 27);
            this.author_IDComboBox.TabIndex = 10;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.Location = new System.Drawing.Point(678, 34);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(64, 19);
            titleLabel.TabIndex = 15;
            titleLabel.Text = ":العنوان";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleTextBox.Location = new System.Drawing.Point(425, 31);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(200, 27);
            this.titleTextBox.TabIndex = 16;
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
            this.panel2.Size = new System.Drawing.Size(375, 203);
            this.panel2.TabIndex = 1;
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
            // dataGridViewDisplayBook
            // 
            this.dataGridViewDisplayBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplayBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplayBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisplayBook.Location = new System.Drawing.Point(10, 307);
            this.dataGridViewDisplayBook.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.dataGridViewDisplayBook.Name = "dataGridViewDisplayBook";
            this.dataGridViewDisplayBook.RowHeadersVisible = false;
            this.dataGridViewDisplayBook.RowHeadersWidth = 62;
            this.dataGridViewDisplayBook.RowTemplate.Height = 29;
            this.dataGridViewDisplayBook.Size = new System.Drawing.Size(1138, 395);
            this.dataGridViewDisplayBook.TabIndex = 17;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.50848F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.49153F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 407F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 712);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(1066, 17);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(60, 3);
            this.panel5.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1000, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "فلتره";
            // 
            // Author_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 712);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Author_Form";
            this.Text = "Author_Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copiesNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplayBook)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewDisplayBook;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelet;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.ComboBox author_IDComboBox;
        private System.Windows.Forms.ComboBox category_IDComboBox;
        private System.Windows.Forms.NumericUpDown copiesNumericUpDown;
        private System.Windows.Forms.DateTimePicker publication_YearDateTimePicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox titleTextBox1;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label label1;
    }
}