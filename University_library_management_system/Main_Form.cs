using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University_library_management_system.FormAplliction;

namespace University_library_management_system
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();

            LoadForm(new Logo_Form());
        }

        public void LoadForm(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
            {
                // الحصول على مرجع للنموذج القديم
                Form oldForm = this.mainpanel.Controls[0] as Form;

                //  إزالة النموذج من عناصر التحكم
                this.mainpanel.Controls.RemoveAt(0);

                // التخلص من بينات النافده من الداكره
                if (oldForm != null)
                {
                    oldForm.Close(); 
                    oldForm.Dispose(); 
                }
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btnMenuBook_Click(object sender, EventArgs e)
        {
            MenuBookTime.Start();
        }

        bool bookMenuExpand = true;
        private void MenuBookTime_Tick(object sender, EventArgs e)
        {
            if (bookMenuExpand) {

                FLPMenuBook.Height += 5;
                if (FLPMenuBook.Height == FLPMenuBook.MaximumSize.Height) { 
                    
                    MenuBookTime.Stop();
                    bookMenuExpand = false;
                }
            
            }
            else
            {
                FLPMenuBook.Height -= 5;
                if (FLPMenuBook.Height == FLPMenuBook.MinimumSize.Height)
                {

                    MenuBookTime.Stop();
                    bookMenuExpand = true;
                }
            }
        }

        bool borrowesMenuExpand = true;

        private void MenuBorroingTime_Tick(object sender, EventArgs e)
        {
            if (borrowesMenuExpand)
            {

                FLPMenuBorrowes.Height += 5;
                if (FLPMenuBorrowes.Height == FLPMenuBorrowes.MaximumSize.Height)
                {

                    MenuBorroingTime.Stop();
                    borrowesMenuExpand = false;
                }

            }
            else
            {
                FLPMenuBorrowes.Height -= 5;
                if (FLPMenuBorrowes.Height == FLPMenuBorrowes.MinimumSize.Height)
                {

                    MenuBorroingTime.Stop();
                    borrowesMenuExpand = true;
                }
            }
        }

        private void btnborrowsMenu_Click(object sender, EventArgs e)
        {
            MenuBorroingTime.Start();
        }

        private void btnBookSetting_Click(object sender, EventArgs e)
        {
            LoadForm(new Book_Form());
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            LoadForm(new Author_Form());
        }

        private void btnborrowsSetting_Click(object sender, EventArgs e)
        {
            LoadForm(new Borrower_Form());
        }

        private void btnCatogre_Click(object sender, EventArgs e)
        {
            LoadForm(new Category_Form());
        }

        private void btnborrowingSetting_Click(object sender, EventArgs e)
        {
            LoadForm(new Borrowing_Form());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LoadForm(new Logo_Form());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region الشريط العلوي
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left = this.Left + (e.X - mouseX);
                this.Top = this.Top + (e.Y - mouseY);
            }
        }
        #endregion
    }
}
