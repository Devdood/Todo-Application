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
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
            StateManager.OnStateChanged += StateManager_OnStateChanged;
        }

        private void StateManager_OnStateChanged(AppState STATE)
        {
            this.Dispose();
        }

        private void btCreateTask_Click(object sender, EventArgs e)
        {
            if (textBoxSubject.Text.Length > 0)
            {
                if (StateManager.APP_STATE == AppState.Todos)
                {
                    Categories.Instance.CurCategory.CreateNewTodo(textBoxSubject.Text);
                }
                else if (StateManager.APP_STATE == AppState.Categories)
                {
                    Categories.Instance.AddCategory(textBoxSubject.Text);
                }
            }

            this.Dispose();
        }

        private void btCancelTask_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
