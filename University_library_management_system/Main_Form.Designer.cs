namespace University_library_management_system
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMenuBook = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBookSetting = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnCatogre = new System.Windows.Forms.Button();
            this.MenuBookTime = new System.Windows.Forms.Timer(this.components);
            this.MenuBorroingTime = new System.Windows.Forms.Timer(this.components);
            this.SidbarTime = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.FLPMenuBook = new System.Windows.Forms.FlowLayoutPanel();
            this.FLPMenuBorrowes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnborrowsMenu = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnborrowsSetting = new System.Windows.Forms.Button();
            this.btnborrowingSetting = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.FLPMenuBook.SuspendLayout();
            this.FLPMenuBorrowes.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1480, 48);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(39, 33);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnMenuBook);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel4.Size = new System.Drawing.Size(291, 57);
            this.panel4.TabIndex = 6;
            // 
            // btnMenuBook
            // 
            this.btnMenuBook.BackColor = System.Drawing.Color.LimeGreen;
            this.btnMenuBook.FlatAppearance.BorderSize = 0;
            this.btnMenuBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBook.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBook.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBook.Location = new System.Drawing.Point(0, 0);
            this.btnMenuBook.Name = "btnMenuBook";
            this.btnMenuBook.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnMenuBook.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMenuBook.Size = new System.Drawing.Size(294, 57);
            this.btnMenuBook.TabIndex = 3;
            this.btnMenuBook.Text = "الكتب";
            this.btnMenuBook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuBook.UseVisualStyleBackColor = false;
            this.btnMenuBook.Click += new System.EventHandler(this.btnMenuBook_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnBookSetting);
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel2.Size = new System.Drawing.Size(294, 60);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.button3);
            this.panel5.Location = new System.Drawing.Point(3, 82);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 76);
            this.panel5.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LimeGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(-20, -21);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.button3.Size = new System.Drawing.Size(267, 115);
            this.button3.TabIndex = 3;
            this.button3.Text = "الكتب";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBookSetting
            // 
            this.btnBookSetting.BackColor = System.Drawing.Color.LightGreen;
            this.btnBookSetting.FlatAppearance.BorderSize = 0;
            this.btnBookSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSetting.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBookSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookSetting.Location = new System.Drawing.Point(0, 3);
            this.btnBookSetting.Name = "btnBookSetting";
            this.btnBookSetting.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnBookSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBookSetting.Size = new System.Drawing.Size(294, 57);
            this.btnBookSetting.TabIndex = 3;
            this.btnBookSetting.Text = "اعدادات الكتب";
            this.btnBookSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookSetting.UseVisualStyleBackColor = false;
            this.btnBookSetting.Click += new System.EventHandler(this.btnBookSetting_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.BackColor = System.Drawing.Color.LightGreen;
            this.btnAuthor.FlatAppearance.BorderSize = 0;
            this.btnAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAuthor.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuthor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.Location = new System.Drawing.Point(0, 132);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAuthor.Size = new System.Drawing.Size(294, 60);
            this.btnAuthor.TabIndex = 3;
            this.btnAuthor.Text = "اعدادات المؤالفين";
            this.btnAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAuthor.UseVisualStyleBackColor = false;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnCatogre
            // 
            this.btnCatogre.BackColor = System.Drawing.Color.LightGreen;
            this.btnCatogre.FlatAppearance.BorderSize = 0;
            this.btnCatogre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatogre.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatogre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCatogre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatogre.Location = new System.Drawing.Point(0, 198);
            this.btnCatogre.Name = "btnCatogre";
            this.btnCatogre.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCatogre.Size = new System.Drawing.Size(294, 60);
            this.btnCatogre.TabIndex = 3;
            this.btnCatogre.Text = "اعدادات الفئات";
            this.btnCatogre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatogre.UseVisualStyleBackColor = false;
            this.btnCatogre.Click += new System.EventHandler(this.btnCatogre_Click);
            // 
            // MenuBookTime
            // 
            this.MenuBookTime.Interval = 10;
            this.MenuBookTime.Tick += new System.EventHandler(this.MenuBookTime_Tick);
            // 
            // MenuBorroingTime
            // 
            this.MenuBorroingTime.Interval = 10;
            this.MenuBorroingTime.Tick += new System.EventHandler(this.MenuBorroingTime_Tick);
            // 
            // SidbarTime
            // 
            this.SidbarTime.Interval = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.LimeGreen;
            this.flowLayoutPanel1.Controls.Add(this.panel6);
            this.flowLayoutPanel1.Controls.Add(this.FLPMenuBook);
            this.flowLayoutPanel1.Controls.Add(this.FLPMenuBorrowes);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1180, 48);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(300, 772);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(297, 108);
            this.panel6.TabIndex = 11;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(297, 108);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FLPMenuBook
            // 
            this.FLPMenuBook.Controls.Add(this.panel4);
            this.FLPMenuBook.Controls.Add(this.panel2);
            this.FLPMenuBook.Controls.Add(this.btnAuthor);
            this.FLPMenuBook.Controls.Add(this.btnCatogre);
            this.FLPMenuBook.Location = new System.Drawing.Point(0, 117);
            this.FLPMenuBook.MaximumSize = new System.Drawing.Size(297, 264);
            this.FLPMenuBook.MinimumSize = new System.Drawing.Size(297, 65);
            this.FLPMenuBook.Name = "FLPMenuBook";
            this.FLPMenuBook.Size = new System.Drawing.Size(297, 65);
            this.FLPMenuBook.TabIndex = 9;
            // 
            // FLPMenuBorrowes
            // 
            this.FLPMenuBorrowes.Controls.Add(this.panel3);
            this.FLPMenuBorrowes.Controls.Add(this.panel8);
            this.FLPMenuBorrowes.Controls.Add(this.btnborrowingSetting);
            this.FLPMenuBorrowes.Location = new System.Drawing.Point(0, 188);
            this.FLPMenuBorrowes.MaximumSize = new System.Drawing.Size(297, 200);
            this.FLPMenuBorrowes.MinimumSize = new System.Drawing.Size(297, 65);
            this.FLPMenuBorrowes.Name = "FLPMenuBorrowes";
            this.FLPMenuBorrowes.Size = new System.Drawing.Size(297, 65);
            this.FLPMenuBorrowes.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnborrowsMenu);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel3.Size = new System.Drawing.Size(291, 57);
            this.panel3.TabIndex = 6;
            // 
            // btnborrowsMenu
            // 
            this.btnborrowsMenu.BackColor = System.Drawing.Color.LimeGreen;
            this.btnborrowsMenu.FlatAppearance.BorderSize = 0;
            this.btnborrowsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrowsMenu.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrowsMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnborrowsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrowsMenu.Location = new System.Drawing.Point(0, 0);
            this.btnborrowsMenu.Name = "btnborrowsMenu";
            this.btnborrowsMenu.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnborrowsMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnborrowsMenu.Size = new System.Drawing.Size(294, 57);
            this.btnborrowsMenu.TabIndex = 3;
            this.btnborrowsMenu.Text = "قائمه المستعيرين";
            this.btnborrowsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrowsMenu.UseVisualStyleBackColor = false;
            this.btnborrowsMenu.Click += new System.EventHandler(this.btnborrowsMenu_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.btnborrowsSetting);
            this.panel8.Location = new System.Drawing.Point(0, 66);
            this.panel8.Name = "panel8";
            this.panel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel8.Size = new System.Drawing.Size(294, 60);
            this.panel8.TabIndex = 4;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.button2);
            this.panel11.Location = new System.Drawing.Point(3, 82);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(246, 76);
            this.panel11.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-20, -21);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.button2.Size = new System.Drawing.Size(267, 115);
            this.button2.TabIndex = 3;
            this.button2.Text = "الكتب";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnborrowsSetting
            // 
            this.btnborrowsSetting.BackColor = System.Drawing.Color.LightGreen;
            this.btnborrowsSetting.FlatAppearance.BorderSize = 0;
            this.btnborrowsSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrowsSetting.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrowsSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnborrowsSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrowsSetting.Location = new System.Drawing.Point(0, 3);
            this.btnborrowsSetting.Name = "btnborrowsSetting";
            this.btnborrowsSetting.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnborrowsSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnborrowsSetting.Size = new System.Drawing.Size(294, 57);
            this.btnborrowsSetting.TabIndex = 3;
            this.btnborrowsSetting.Text = "اعدادات المستعيرين";
            this.btnborrowsSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrowsSetting.UseVisualStyleBackColor = false;
            this.btnborrowsSetting.Click += new System.EventHandler(this.btnborrowsSetting_Click);
            // 
            // btnborrowingSetting
            // 
            this.btnborrowingSetting.BackColor = System.Drawing.Color.LightGreen;
            this.btnborrowingSetting.FlatAppearance.BorderSize = 0;
            this.btnborrowingSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrowingSetting.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrowingSetting.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnborrowingSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrowingSetting.Location = new System.Drawing.Point(0, 132);
            this.btnborrowingSetting.Name = "btnborrowingSetting";
            this.btnborrowingSetting.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnborrowingSetting.Size = new System.Drawing.Size(294, 60);
            this.btnborrowingSetting.TabIndex = 3;
            this.btnborrowingSetting.Text = "اعدادات الاستعرات";
            this.btnborrowingSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnborrowingSetting.UseVisualStyleBackColor = false;
            this.btnborrowingSetting.Click += new System.EventHandler(this.btnborrowingSetting_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 48);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainpanel.Size = new System.Drawing.Size(1180, 772);
            this.mainpanel.TabIndex = 9;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1480, 820);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main_Form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "formDesine";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.FLPMenuBook.ResumeLayout(false);
            this.FLPMenuBorrowes.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBookSetting;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMenuBook;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Timer MenuBookTime;
        private System.Windows.Forms.Button btnCatogre;
        private System.Windows.Forms.Timer MenuBorroingTime;
        private System.Windows.Forms.Timer SidbarTime;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel FLPMenuBook;
        private System.Windows.Forms.FlowLayoutPanel FLPMenuBorrowes;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnborrowsMenu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnborrowsSetting;
        private System.Windows.Forms.Button btnborrowingSetting;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnExit;
    }
}