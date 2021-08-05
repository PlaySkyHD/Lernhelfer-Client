
namespace Lehrnhelfer_Client.Forms.Template
{
    partial class LoginTemplate
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_button = new System.Windows.Forms.Button();
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.lehrer_radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.schueler_radioButton = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 47);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lernhelfer";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.username_textBox);
            this.panel1.Controls.Add(this.lehrer_radioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.schueler_radioButton);
            this.panel1.Location = new System.Drawing.Point(112, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 210);
            this.panel1.TabIndex = 7;
            // 
            // login_button
            // 
            this.login_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_button.Location = new System.Drawing.Point(51, 145);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(117, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_textBox
            // 
            this.username_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_textBox.Location = new System.Drawing.Point(37, 73);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(152, 20);
            this.username_textBox.TabIndex = 0;
            // 
            // lehrer_radioButton
            // 
            this.lehrer_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lehrer_radioButton.AutoSize = true;
            this.lehrer_radioButton.Location = new System.Drawing.Point(46, 122);
            this.lehrer_radioButton.Name = "lehrer_radioButton";
            this.lehrer_radioButton.Size = new System.Drawing.Size(55, 17);
            this.lehrer_radioButton.TabIndex = 3;
            this.lehrer_radioButton.TabStop = true;
            this.lehrer_radioButton.Text = "Lehrer";
            this.lehrer_radioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username";
            // 
            // schueler_radioButton
            // 
            this.schueler_radioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.schueler_radioButton.AutoSize = true;
            this.schueler_radioButton.Checked = true;
            this.schueler_radioButton.Location = new System.Drawing.Point(46, 99);
            this.schueler_radioButton.Name = "schueler_radioButton";
            this.schueler_radioButton.Size = new System.Drawing.Size(61, 17);
            this.schueler_radioButton.TabIndex = 2;
            this.schueler_radioButton.TabStop = true;
            this.schueler_radioButton.Text = "Schüler";
            this.schueler_radioButton.UseVisualStyleBackColor = true;
            // 
            // LoginTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 459);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "LoginTemplate";
            this.Text = "LoginTemplate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.RadioButton lehrer_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton schueler_radioButton;
    }
}