﻿namespace QuickTodos
{
    partial class CategoryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.btCreateTask = new System.Windows.Forms.Button();
            this.btCancelTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato Light", 13.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(54, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Create new category";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato Light", 10.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(30, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Subject:";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxSubject.Location = new System.Drawing.Point(30, 77);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(225, 20);
            this.textBoxSubject.TabIndex = 5;
            // 
            // btCreateTask
            // 
            this.btCreateTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCreateTask.Location = new System.Drawing.Point(158, 115);
            this.btCreateTask.Name = "btCreateTask";
            this.btCreateTask.Size = new System.Drawing.Size(97, 56);
            this.btCreateTask.TabIndex = 3;
            this.btCreateTask.Text = "Create";
            this.btCreateTask.UseVisualStyleBackColor = true;
            this.btCreateTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCreateTask_MouseClick);
            // 
            // btCancelTask
            // 
            this.btCancelTask.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancelTask.Location = new System.Drawing.Point(30, 115);
            this.btCancelTask.Name = "btCancelTask";
            this.btCancelTask.Size = new System.Drawing.Size(97, 56);
            this.btCancelTask.TabIndex = 4;
            this.btCancelTask.Text = "Cancel";
            this.btCancelTask.UseVisualStyleBackColor = true;
            this.btCancelTask.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btCancelTask_MouseClick);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(284, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.btCreateTask);
            this.Controls.Add(this.btCancelTask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.Text = "CategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button btCreateTask;
        private System.Windows.Forms.Button btCancelTask;
    }
}