using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTodos
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
            StateManager.OnStateChanged += StateManager_OnStateChanged;
        }

        private void StateManager_OnStateChanged(AppState STATE)
        {
            this.Dispose();
        }

        private void btCreateTask_MouseClick(object sender, MouseEventArgs e)
        {
            if(textBoxSubject.Text.Length > 0)
            {
                Categories.Instance.AddCategory(textBoxSubject.Text);
            }

            this.Dispose();
        }

        private void btCancelTask_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
