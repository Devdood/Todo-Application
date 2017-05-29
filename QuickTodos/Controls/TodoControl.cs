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
    public partial class TodoControl : UserControl
    {
        public Todo Todo
        {
            get;
            private set;
        }

        public TodoControl(Todo todo)
        {
            InitializeComponent();
            this.Todo = todo;
            todo.Control = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BringToFront();
            button2.BringToFront();
        }

        private void btRemoveTodo_Click(object sender, EventArgs e)
        {
            Categories.Instance.CurCategory.RemoveTodo(Todo);
            this.Dispose();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Categories.Instance.CurCategory.CreateNewTask(Todo, textBox1.Text);
                textBox1.Text = "";
            }
            button1.BringToFront();
        }
    }
}
