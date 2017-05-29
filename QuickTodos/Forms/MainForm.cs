using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTodos
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;

        public Categories category;

        public List<Form> childForms;

        public MainForm()
        {
            Instance = this;
            category = new Categories();

            InitializeComponent();
            InitializeApp();

            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);

            category = CategoryHandler.Load(CategoryHandler.filePath);

            category.InitUI();

            ChangeAddButton(StateManager.APP_STATE);

            childForms = new List<Form>();
        }

        private void InitializeApp()
        {
            StateManager.Init();
            StateManager.OnStateChanged += StateManager_OnStateChanged;
        }

        private void StateManager_OnStateChanged(AppState STATE)
        {
            ChangeAddButton(STATE);
        }

        static void OnProcessExit(object sender, EventArgs e)
        {
            CategoryHandler.Save();
        }

        public void ChangeAddButton(AppState STATE)
        {
            if (btNewTask == null)
                return;

            switch(StateManager.APP_STATE)
            {
                case AppState.Categories:
                    btNewTask.Text = "Add Category";
                    break;

                case AppState.Todos:
                    btNewTask.Text = "Add Task";
                    break;
            }
        }
 
        private void btNewTask_MouseClick(object sender, MouseEventArgs e)
        {
            Form form = null;
            if (StateManager.APP_STATE == AppState.Categories)
            {
                CategoryForm newCategory = new CategoryForm();

                form = newCategory;
            }
            else
            {
                TodoForm newTodo = new TodoForm();

                form = newTodo;
                
            }
            form.Owner = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + (this.Width - form.Width) / 2, this.Location.Y + (this.Height - form.Height) / 2);

            form.Show(this);
            childForms.Add(form);
        }

        private void MainForm_Move(object sender, EventArgs e)
        {
            foreach (Form form in childForms)
            {
                form.Location = new Point(this.Location.X + (this.Width - form.Width) / 2, this.Location.Y + (this.Height - form.Height) / 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelContent.SendToBack();
            panelCategory.BringToFront();
            StateManager.APP_STATE = AppState.Categories;
        }
    }
}
