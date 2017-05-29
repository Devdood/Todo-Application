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
    public partial class LoadingIndicator : Form
    {
        public LoadingIndicator(Control Owner)
        {
            InitializeComponent();
            this.Width = Owner.Width;
            this.Height = Owner.Height;
            this.Location = new Point(this.Location.X + (this.Width - Owner.Width) / 2, this.Location.Y + (this.Height - Owner.Height) / 2);

            BringToFront();
        }
    }
}
