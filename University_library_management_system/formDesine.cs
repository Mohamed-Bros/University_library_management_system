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

namespace University_library_management_system
{
    public partial class formDesine : Form
    {
        public formDesine()
        {
            InitializeComponent();
            
        }

        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

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
            loadform(new test());
        }
    }
}
