using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuickTodos
{
    [Serializable]
    public class Category : TodoObject
    {
        public Category() { }

        public Category(string subject)
        {
            this.Subject = subject;
            TodosList = new List<Todo>();
            RegisterHandlers();
        }

        public Category(Category category)
        {
            RegisterHandlers();
        }

        [NonSerialized]
        public CategoryControl Control;

        public List<Todo> TodosList
        {
            get
            {
                return m_todosList;
            }
            set
            {
                m_todosList = value;
            }
        }
        private List<Todo> m_todosList;

        public Todo GetTodoByTask(Task task)
        {
            for (int i = 0; i < TodosList.Count; i++)
            {
                if (TodosList[i].Tasks.Contains(task))
                {
                    return TodosList[i];
                }
            }
            return null;
        }

        public delegate void TodoAdded(Todo val);
        public event TodoAdded OnTodoAdded;

        public delegate void TodoRemoved(List<Todo> list, Todo val);
        public event TodoRemoved OnTodoRemoved;

        public delegate void TaskAdded(Task val);
        public event TaskAdded OnTaskAdded;

        public delegate void TaskRemoved(Task val);
        public event TaskRemoved OnTaskRemoved;

        public void Refresh()
        {
            foreach (Todo ta in TodosList)
            {
                CreateNewTodo(ta);

                for (int i = 0; i < ta.Tasks.Count; i++)
                {
                    CreateNewTask(ta, ta.Tasks[i]);
                }
            }
        }

        /// <summary>
        /// Read from database/file
        /// </summary>
        /// <param name="todo"></param>
        public void CreateNewTodo(Todo todo)
        {
            if (OnTodoAdded != null)
                OnTodoAdded(todo);
        }

        /// <summary>
        /// Creating in Application
        /// </summary>
        /// <param name="subject"></param>
        public void CreateNewTodo(string subject)
        {
            Todo todo = new Todo(subject);
            TodosList.Add(todo);

            //MessageBox.Show("New todo: " + todo.Subject + " in " + Subject);

            if (OnTodoAdded != null)
                OnTodoAdded(todo);
        }

        public void RemoveTodo(Todo todo)
        {
            if (OnTodoRemoved != null)
                OnTodoRemoved(TodosList, todo);
        }

        public void CreateNewTask(Todo parent, Task task)
        {
            if (OnTodoAdded != null)
                OnTaskAdded(task);
        }

        public void CreateNewTask(Todo parent, string subject)
        {
            Task task = new Task(parent, subject);
            parent.AddTask(task);

            if (OnTodoAdded != null)
                OnTaskAdded(task);
        }

        public void RemoveTask(Task task)
        {
            if (OnTodoRemoved != null)
                OnTaskRemoved(task);
        }

        public void RegisterHandlers()
        {
            OnTodoAdded += CategoryHandler.TodosHandler_OnTodoAdded;
            OnTodoRemoved += CategoryHandler.TodosHandler_OnTodoRemoved;
            OnTaskAdded += CategoryHandler.TodosHandler_OnTaskAdded;
            OnTaskRemoved += CategoryHandler.TodosHandler_OnTaskRemoved;
        }
    }
}
