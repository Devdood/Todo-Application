namespace QuickTodos
{
    partial class TodoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSubject = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.btRemoveTodo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Lato", 18.25F);
            this.labelSubject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSubject.Location = new System.Drawing.Point(33, 39);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(94, 30);
            this.labelSubject.TabIndex = 1;
            this.labelSubject.Text = "Subject";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(326, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add new task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelTasks
            // 
            this.panelTasks.AutoScroll = true;
            this.panelTasks.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panelTasks.Location = new System.Drawing.Point(29, 72);
            this.panelTasks.Name = "panelTasks";
            this.panelTasks.Size = new System.Drawing.Size(326, 162);
            this.panelTasks.TabIndex = 0;
            // 
            // btRemoveTodo
            // 
            this.btRemoveTodo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRemoveTodo.ForeColor = System.Drawing.Color.Red;
            this.btRemoveTodo.Location = new System.Drawing.Point(311, 42);
            this.btRemoveTodo.Name = "btRemoveTodo";
            this.btRemoveTodo.Size = new System.Drawing.Size(44, 27);
            this.btRemoveTodo.TabIndex = 4;
            this.btRemoveTodo.Text = "X";
            this.btRemoveTodo.UseVisualStyleBackColor = true;
            this.btRemoveTodo.Click += new System.EventHandler(this.btRemoveTodo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F);
            this.textBox1.Location = new System.Drawing.Point(29, 240);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 34);
            this.textBox1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // TodoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btRemoveTodo);
            this.Controls.Add(this.panelTasks);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Name = "TodoControl";
            this.Size = new System.Drawing.Size(372, 288);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btRemoveTodo;
        public System.Windows.Forms.FlowLayoutPanel panelTasks;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}
