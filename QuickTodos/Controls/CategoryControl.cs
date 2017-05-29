using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTodos
{
    public partial class CategoryControl : UserControl
    {
        public Category Category
        {
            get;
            private set;
        }

        public CategoryControl(Category category)
        {
            InitializeComponent();
            this.Category = category;
            label1.Text = Category.Subject;
        }

        private void CategoryControl_MouseClick(object sender, MouseEventArgs e)
        {
            Categories.Instance.ChangeCategory(Category);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Categories.Instance.RemoveCategory(Category);
        }
    }
}
