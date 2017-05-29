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
    public class Categories
    {
        [NonSerialized]
        public CategoriesHandler EventsHandler;

        public Categories()
        {
            if(Instance == null)
                Instance = this;

            Init();
        }

        private void Init()
        {
            EventsHandler = new CategoriesHandler(this);

            if (CategoriesList == null)
                CategoriesList = new List<Category>();
        }

        public void InitUI()
        {
            foreach (Category c in CategoriesList)
            {
                AddCategory(c);

                foreach (Todo ta in c.TodosList)
                {
                    c.CreateNewTodo(ta);

                    foreach (Task ts in ta.Tasks)
                    {
                        c.CreateNewTask(ta, ts);
                    }
                }
            }
        }

        public static Categories Instance;

        public List<Category> CategoriesList;

        public Category CurCategory;

        public delegate void CategoryChanged(Category val);
        public event CategoryChanged OnCategoryChanged;

        public void ChangeCategory(Category val)
        {
            CurCategory = val;

            if (OnCategoryChanged != null)
            {
                OnCategoryChanged(val);
            }
        }


        public delegate void CategoryRemoved(Category val);
        public event CategoryRemoved OnCategoryRemoved;

        public void RemoveCategory(Category val)
        {
            if (OnCategoryRemoved != null)
            {
                OnCategoryRemoved(val);
            }

            Categories.Instance.CategoriesList.Remove(val);
        }


        public delegate void CategoryAdded(Category val);
        public event CategoryAdded OnCategoryAdded;

        public void AddCategory(Category category)
        {
            Categories.Instance.CategoriesList.Add(category);

            if (OnCategoryAdded != null)
            {
                OnCategoryAdded(category);
            }
        }
        public void AddCategory(string subject)
        {
            Category category = new Category(subject);
            AddCategory(category);
        }
    }
}
