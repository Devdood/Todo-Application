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
    public partial class TaskControl : UserControl
    {
        public Task Task
        {
            get;
            private set;
        }

        private Color startTextColor;

        public TaskControl(Task task)
        {
            InitializeComponent();
            checkBox.Text = task.Subject;
            startTextColor = checkBox.ForeColor;
            task.Control = this;
            this.Task = task;
        }

        public void SetCheckboxState(bool done)
        {
            if (done)
            {
                checkBox.ForeColor = Color.Green;
            }
            else
            {
                checkBox.ForeColor = startTextColor;
            }
            checkBox.Checked = done;
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            SetCheckboxState(checkBox.Checked);

            Task.SetFinishState(checkBox.Checked);
        }

        private void btRemoveTask_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }
    }
}
