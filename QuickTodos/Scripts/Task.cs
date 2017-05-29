using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTodos
{
    [Serializable]
    public class Task : TodoObject
    {
        [NonSerialized]
        public TaskControl Control;
        public Todo ParentTodo;

        public Task(Todo parent, string subject)
        {
            this.Subject = subject;
            ParentTodo = parent;
        }

        public void SetFinishState(bool done)
        {
            this.Done = done;
        }

        public bool Done
        {
            get
            {
                return done;
            }
            private set
            {
                done = value;
            }
        }
        private bool done;
    }
}
