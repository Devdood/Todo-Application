using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace QuickTodos
{
    public static class CategoryHandler
    {
        public static void Category_OnCategoryRemoved(Category val)
        {
            MainForm.Instance.panelCategory.Controls.Remove(val.Control);
        }

        public static void Category_OnCategoryAdded(Category val)
        {
            CategoryControl control = new CategoryControl(val);

            val.Control = control;

            MainForm.Instance.panelCategory.Controls.Add(control);
        }

        public static void Category_OnCategoryChanged(Category val)
        {
            MainForm.Instance.panelContent.Controls.Clear();

            val.Refresh();

            MainForm.Instance.panelCategory.SendToBack();
            MainForm.Instance.panelContent.BringToFront();

            StateManager.APP_STATE = AppState.Todos;
        }

        public static void TodosHandler_OnTaskRemoved(Task val)
        {
            val.ParentTodo.Tasks.Remove(val);
        }

        public static void TodosHandler_OnTaskAdded(Task val)
        {
            TaskControl control = new TaskControl(val);
            control.checkBox.Text = val.Subject;
            control.SetCheckboxState(val.Done);

            val.ParentTodo.Control.panelTasks.Controls.Add(control);
        }

        public static void TodosHandler_OnTodoRemoved(List<Todo> list, Todo val)
        {
            if (!list.Contains(val))
                return;

            list.Remove(val);
        }

        public static void TodosHandler_OnTodoAdded(Todo val)
        {
            TodoControl control = new TodoControl(val);

            control.labelSubject.Text = val.Subject;

            MainForm.Instance.panelContent.Controls.Add(control);
        }

        public static string filePath = Path.GetTempPath() + "data3.dat";

        public static void Save()
        {
            //MessageBox.Show(filePath);
            BinaryFormatter bf = new BinaryFormatter();
            FileStream f = File.Open(filePath, FileMode.OpenOrCreate);

            //MessageBox.Show(Categories.Instance.CategoriesList.Count.ToString());

            bf.Serialize(f, Categories.Instance);
            f.Close();
        }
        
        public static Categories Load(string path)
        {
            if(File.Exists(filePath))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(filePath, FileMode.Open);

                Categories cat = (Categories)bf.Deserialize(file);

                //MessageBox.Show(cat.CategoriesList.Count.ToString());

                file.Close();
                return cat;
            }
            return null;
        }
    }
}
