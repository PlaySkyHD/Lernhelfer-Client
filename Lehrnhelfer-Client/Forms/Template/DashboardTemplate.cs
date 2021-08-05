using Lehrnhelfer_Client.Forms.Template.Task;
using Lehrnhelfer_Server.Server.Packet.PType.Server;
using Lehrnhelfer_Server.Server.Packet.PType.Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client.Forms.Template
{
    public partial class DashboardTemplate : Form
    {
        public DashboardTemplate()
        {
            InitializeComponent();
        }

        private void DashboardTemplate_Load(object sender, EventArgs e)
        {
            MainForm.INSTANCE.UserEntryHandler.UpdateTable(this.data_tableLayoutPanel);

            if (!MainForm.INSTANCE.UserEntryHandler.TheUser.Lehrer)
            {
                this.start_server_button.Visible = false;
                this.new_task_button.Visible = false;
                this.start_help_system_button.Visible = false;
            }
        }

        private void new_task_button_Click(object sender, EventArgs e)
        {
            new CreateTaskForm(taskName => 
            {
                MainForm.INSTANCE.LernhelferClient.SendPacket(new TaskCreateRequestPacket() { UserID = MainForm.INSTANCE.UserEntryHandler.TheUser.UserID, Name = taskName });
            }).Show();
        }

        private void start_server_button_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.LernhelferClient.SendPacket(new ServerChangeStateRequestPacket() { UserID = MainForm.INSTANCE.UserEntryHandler.TheUser.UserID, ServerState = ServerState.OPEN });
        }

        private void start_help_system_button_Click(object sender, EventArgs e)
        {
            MainForm.INSTANCE.LernhelferClient.SendPacket(new ServerChangeStateRequestPacket() { UserID = MainForm.INSTANCE.UserEntryHandler.TheUser.UserID, ServerState = ServerState.CLOSED });
        }
    }
}
