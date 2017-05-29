using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTodos
{
    public static class StateManager
    {
        public static void Init()
        {
            APP_STATE = AppState.Categories;
        }

        public static AppState APP_STATE
        {
            get
            {
                return M_APP_STATE;
            }
            set
            {
                if(M_APP_STATE == value)
                {
                    return;
                }

                M_APP_STATE = value;

                if(OnStateChanged != null)
                {
                    OnStateChanged(value);
                }
            }
        }

        private static AppState M_APP_STATE;

        public delegate void StateChanged(AppState STATE);
        public static event StateChanged OnStateChanged;
    }
}
