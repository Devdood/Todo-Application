using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTodos
{
    [Serializable]
    public class Todo : TodoObject
    {
        [NonSerialized]
        public TodoControl Control;

        public Todo() { }

        public Todo(string subject)
        {
            this.Subject = subject;
            this.Tasks = new List<Task>();
        }

        public List<Task> Tasks
        {
            get
            {
                return m_tasks;
            }
            set
            {
                m_tasks = value;
            }
        }
        private List<Task> m_tasks;

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
    }
}
