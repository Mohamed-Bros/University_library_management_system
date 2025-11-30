namespace University_library_management_system.FormAplliction
{
    partial class Borrower_Form
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
            System.Windows.Forms.Label titleLabel1;
            System.Windows.Forms.Label phone_NumberLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label borrower_IDLabel;
            System.Windows.Forms.Label addressLabel;
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewDisplay = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelet = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbPhonNumberFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.borrowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phone_NumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.borrower_IDTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            author_IDLabel1 = new System.Windows.Forms.Label();
            titleLabel1 = new System.Windows.Forms.Label();
            phone_NumberLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            borrower_IDLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // author_IDLabel1
            // 
            author_IDLabel1.AutoSize = true;
            author_IDLabel1.Location = new System.Drawing.Point(786, 46);
            author_IDLabel1.Name = "author_IDLabel1";
            author_IDLabel1.Size = new System.Drawing.Size(86, 19);
            author_IDLabel1.TabIndex = 22;
            author_IDLabel1.Text = ":رقم الهاتف";
            // 
            // titleLabel1
            // 
            titleLabel1.AutoSize = true;
            titleLabel1.Location = new System.Drawing.Point(1050, 46);
            titleLabel1.Name = "titleLabel1";
            titleLabel1.Size = new System.Drawing.Size(56, 19);
            titleLabel1.TabIndex = 26;
            titleLabel1.Text = ":الاسم";
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.26727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.73273F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 434F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1180, 768);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // dataGridViewDisplay
            // 
            this.dataGridViewDisplay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDisplay.Location = new System.Drawing.Point(10, 336);
            this.dataGridViewDisplay.Margin = new System.Windows.Forms.Padding(10, 3, 10, 10);
            this.dataGridViewDisplay.Name = "dataGridViewDisplay";
            this.dataGridViewDisplay.RowHeadersVisible = false;
            this.dataGridViewDisplay.RowHeadersWidth = 62;
            this.dataGridViewDisplay.RowTemplate.Height = 29;
            this.dataGridViewDisplay.Size = new System.Drawing.Size(1160, 422);
            this.dataGridViewDisplay.TabIndex = 17;
            this.dataGridViewDisplay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDisplay_CellClick);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1174, 218);
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
            this.panel2.Size = new System.Drawing.Size(382, 212);
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
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(borrower_IDLabel);
            this.panel1.Controls.Add(this.borrower_IDTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(phone_NumberLabel);
            this.panel1.Controls.Add(this.phone_NumberTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(391, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 212);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.txbPhonNumberFilter);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(author_IDLabel1);
            this.panel3.Controls.Add(titleLabel1);
            this.panel3.Controls.Add(this.txbName);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 227);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(1174, 103);
            this.panel3.TabIndex = 19;
            // 
            // txbPhonNumberFilter
            // 
            this.txbPhonNumberFilter.Location = new System.Drawing.Point(586, 43);
            this.txbPhonNumberFilter.Name = "txbPhonNumberFilter";
            this.txbPhonNumberFilter.Size = new System.Drawing.Size(194, 27);
            this.txbPhonNumberFilter.TabIndex = 10;
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
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(873, 43);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(171, 27);
            this.txbName.TabIndex = 27;
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
            // borrowerBindingSource
            // 
            this.borrowerBindingSource.DataSource = typeof(DataAccessLayer.Data.Borrower);
            // 
            // phone_NumberTextBox
            // 
            this.phone_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Phone_Number", true));
            this.phone_NumberTextBox.Location = new System.Drawing.Point(108, 50);
            this.phone_NumberTextBox.Name = "phone_NumberTextBox";
            this.phone_NumberTextBox.Size = new System.Drawing.Size(173, 27);
            this.phone_NumberTextBox.TabIndex = 9;
            // 
            // phone_NumberLabel
            // 
            phone_NumberLabel.AutoSize = true;
            phone_NumberLabel.Location = new System.Drawing.Point(318, 53);
            phone_NumberLabel.Name = "phone_NumberLabel";
            phone_NumberLabel.Size = new System.Drawing.Size(86, 19);
            phone_NumberLabel.TabIndex = 8;
            phone_NumberLabel.Text = ":رقم الهاتف";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(406, 87);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(147, 27);
            this.nameTextBox.TabIndex = 7;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(590, 90);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(56, 19);
            nameLabel.TabIndex = 6;
            nameLabel.Text = ":الاسم";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(62, 87);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(219, 27);
            this.emailTextBox.TabIndex = 5;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(318, 90);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(55, 19);
            emailLabel.TabIndex = 4;
            emailLabel.Text = ":الإميل";
            // 
            // borrower_IDTextBox
            // 
            this.borrower_IDTextBox.BackColor = System.Drawing.Color.White;
            this.borrower_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Borrower_ID", true));
            this.borrower_IDTextBox.Location = new System.Drawing.Point(471, 55);
            this.borrower_IDTextBox.Name = "borrower_IDTextBox";
            this.borrower_IDTextBox.ReadOnly = true;
            this.borrower_IDTextBox.Size = new System.Drawing.Size(82, 27);
            this.borrower_IDTextBox.TabIndex = 3;
            // 
            // borrower_IDLabel
            // 
            borrower_IDLabel.AutoSize = true;
            borrower_IDLabel.Location = new System.Drawing.Point(590, 58);
            borrower_IDLabel.Name = "borrower_IDLabel";
            borrower_IDLabel.Size = new System.Drawing.Size(100, 19);
            borrower_IDLabel.TabIndex = 2;
            borrower_IDLabel.Text = ":ID المستعير";
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.borrowerBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(62, 127);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(491, 27);
            this.addressTextBox.TabIndex = 1;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(590, 130);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(60, 19);
            addressLabel.TabIndex = 0;
            addressLabel.Text = ":العنوان";
            // 
            // Borrower_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Borrower_Form";
            this.Text = "Borrower_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisplay)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource borrowerBindingSource;
        private System.Windows.Forms.TextBox txbPhonNumberFilter;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox borrower_IDTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phone_NumberTextBox;
    }
}