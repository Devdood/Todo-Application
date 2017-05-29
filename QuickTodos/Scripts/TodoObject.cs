using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTodos
{
    [Serializable]
    public abstract class TodoObject
    {
        public string Subject
        {
            get
            {
                return subject;
            }
            protected set
            {
                subject = value;
            }
        }
        private string subject;
    }
}
