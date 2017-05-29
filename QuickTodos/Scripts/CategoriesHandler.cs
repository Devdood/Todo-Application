using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTodos
{
    public class CategoriesHandler
    {
        public Categories Categories
        {
            get;
            private set;
        }

        public CategoriesHandler(Categories Owner)
        {
            Categories = Owner;
            RegisterEvents();
        }

        public void RegisterEvents()
        {
            Categories.OnCategoryAdded += CategoryHandler.Category_OnCategoryAdded;
            Categories.OnCategoryRemoved += CategoryHandler.Category_OnCategoryRemoved;
            Categories.OnCategoryChanged += CategoryHandler.Category_OnCategoryChanged;
        }
    }
}
