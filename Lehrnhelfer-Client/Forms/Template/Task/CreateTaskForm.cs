using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client.Forms.Template.Task
{
    public partial class CreateTaskForm : Form
    {

        private Action<string> Action;

        public CreateTaskForm(Action<string> Action)
        {
            InitializeComponent();
            Util.Util.SendMessage(this.task_name_textBox.Handle, Util.Util.EM_SETCUEBANNER, 0, "Aufgabenname");
            this.Action = Action;
        }

        private void create_button_Click(object sender, EventArgs e)
        {
            string taskName = this.task_name_textBox.Text;
            if(string.IsNullOrEmpty(taskName) || string.IsNullOrWhiteSpace(taskName))
            {
                MessageBox.Show("Bitte gebe einen Namen an", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.Action.Invoke(taskName);
            this.Close();
        }
    }
}
