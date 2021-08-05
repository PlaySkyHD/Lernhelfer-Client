
namespace Lehrnhelfer_Client.Forms.Template.Task
{
    partial class CreateTaskForm
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
            this.task_name_textBox = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // task_name_textBox
            // 
            this.task_name_textBox.Location = new System.Drawing.Point(26, 41);
            this.task_name_textBox.Name = "task_name_textBox";
            this.task_name_textBox.Size = new System.Drawing.Size(100, 20);
            this.task_name_textBox.TabIndex = 0;
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(39, 67);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(75, 23);
            this.create_button.TabIndex = 1;
            this.create_button.Text = "Erstellen";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Aufgabenname";
            // 
            // CreateTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 118);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.task_name_textBox);
            this.Name = "CreateTaskForm";
            this.Text = "CreateTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox task_name_textBox;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label label1;
    }
}