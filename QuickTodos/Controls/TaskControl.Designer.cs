namespace QuickTodos
{
    partial class TaskControl
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btRemoveTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Lato", 13.25F);
            this.checkBox.Location = new System.Drawing.Point(18, 13);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 0;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // btRemoveTask
            // 
            this.btRemoveTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRemoveTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRemoveTask.ForeColor = System.Drawing.Color.Red;
            this.btRemoveTask.Location = new System.Drawing.Point(258, 11);
            this.btRemoveTask.Name = "btRemoveTask";
            this.btRemoveTask.Size = new System.Drawing.Size(27, 21);
            this.btRemoveTask.TabIndex = 1;
            this.btRemoveTask.Text = "X";
            this.btRemoveTask.UseVisualStyleBackColor = true;
            this.btRemoveTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btRemoveTask_MouseClick);
            // 
            // TaskControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btRemoveTask);
            this.Controls.Add(this.checkBox);
            this.Name = "TaskControl";
            this.Size = new System.Drawing.Size(288, 43);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btRemoveTask;
        public System.Windows.Forms.CheckBox checkBox;
    }
}
