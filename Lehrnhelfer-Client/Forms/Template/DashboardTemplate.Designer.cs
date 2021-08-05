
namespace Lehrnhelfer_Client.Forms.Template
{
    partial class DashboardTemplate
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
            this.start_server_button = new System.Windows.Forms.Button();
            this.new_task_button = new System.Windows.Forms.Button();
            this.start_help_system_button = new System.Windows.Forms.Button();
            this.data_tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // start_server_button
            // 
            this.start_server_button.Location = new System.Drawing.Point(12, 12);
            this.start_server_button.Name = "start_server_button";
            this.start_server_button.Size = new System.Drawing.Size(171, 23);
            this.start_server_button.TabIndex = 0;
            this.start_server_button.Text = "Start Server";
            this.start_server_button.UseVisualStyleBackColor = true;
            this.start_server_button.Click += new System.EventHandler(this.start_server_button_Click);
            // 
            // new_task_button
            // 
            this.new_task_button.Location = new System.Drawing.Point(189, 12);
            this.new_task_button.Name = "new_task_button";
            this.new_task_button.Size = new System.Drawing.Size(159, 23);
            this.new_task_button.TabIndex = 1;
            this.new_task_button.Text = "Neue Aufgabe";
            this.new_task_button.UseVisualStyleBackColor = true;
            this.new_task_button.Click += new System.EventHandler(this.new_task_button_Click);
            // 
            // start_help_system_button
            // 
            this.start_help_system_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.start_help_system_button.Location = new System.Drawing.Point(617, 178);
            this.start_help_system_button.Name = "start_help_system_button";
            this.start_help_system_button.Size = new System.Drawing.Size(138, 23);
            this.start_help_system_button.TabIndex = 2;
            this.start_help_system_button.Text = "Start Helfersystem";
            this.start_help_system_button.UseVisualStyleBackColor = true;
            this.start_help_system_button.Click += new System.EventHandler(this.start_help_system_button_Click);
            // 
            // data_tableLayoutPanel
            // 
            this.data_tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data_tableLayoutPanel.ColumnCount = 2;
            this.data_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.data_tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 741F));
            this.data_tableLayoutPanel.Location = new System.Drawing.Point(12, 41);
            this.data_tableLayoutPanel.Name = "data_tableLayoutPanel";
            this.data_tableLayoutPanel.RowCount = 1;
            this.data_tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.data_tableLayoutPanel.Size = new System.Drawing.Size(741, 131);
            this.data_tableLayoutPanel.TabIndex = 4;
            // 
            // DashboardTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 285);
            this.Controls.Add(this.data_tableLayoutPanel);
            this.Controls.Add(this.start_help_system_button);
            this.Controls.Add(this.new_task_button);
            this.Controls.Add(this.start_server_button);
            this.Name = "DashboardTemplate";
            this.Text = "DashboardTemplate";
            this.Load += new System.EventHandler(this.DashboardTemplate_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_server_button;
        private System.Windows.Forms.Button new_task_button;
        private System.Windows.Forms.Button start_help_system_button;
        public System.Windows.Forms.TableLayoutPanel data_tableLayoutPanel;
    }
}