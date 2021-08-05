using Lehrnhelfer_Client.Entity.Task;
using Lehrnhelfer_Client.Forms.Template;
using Lehrnhelfer_Server.Server.Packet.PType.User;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client.Entity
{
    public class UserEntryHandler : Dictionary<int, UserEntry>
    {
        public UserEntry TheUser { get; set; }
        private MainForm MainForm;

        public UserEntryHandler(MainForm mainForm)
        {
            this.MainForm = mainForm;

            Timer timer = new Timer()
            {
                Enabled = true,
                Interval = 2000
            };
            timer.Tick += KeepAliveTimer_Tick;
        }

        public void HandleNewUser(List<UserEntry> userEntries)
        {
            this.Clear();
            foreach (UserEntry userEntry in userEntries)
            {
                this.Add(userEntry.UserID, userEntry);
            }
            
            if (MainForm.INSTANCE.activeForm is DashboardTemplate)
                this.UpdateTable(((DashboardTemplate)MainForm.INSTANCE.activeForm).data_tableLayoutPanel);
        }

        private void KeepAliveTimer_Tick(object sender, EventArgs e)
        {
            if (this.TheUser == null) return;

            UserKeepAlivePacket userKeepAlivePacket = new UserKeepAlivePacket()
            {
                Id = this.TheUser.UserID
            };
            this.MainForm.LernhelferClient.SendPacket(userKeepAlivePacket, true);
        }

        public void UpdateTable(TableLayoutPanel tableLayoutPanel)
        {
            tableLayoutPanel.Invoke(new Action(() => 
            {

                tableLayoutPanel.BackColor = Color.Transparent;
                tableLayoutPanel.ForeColor = Color.Black;
                tableLayoutPanel.Controls.Clear();

                tableLayoutPanel.RowCount = this.Count + (this.Count == 0 ? 1 : 0);
                tableLayoutPanel.ColumnCount = MainForm.INSTANCE.TaskEntryHandler.Count + 1 ;

                float size = 100 / tableLayoutPanel.ColumnCount;
                for (int i = 0; i < tableLayoutPanel.ColumnCount; i++)
                {
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                }

                size = 100 / tableLayoutPanel.RowCount;
                for (int i = 0; i < tableLayoutPanel.RowCount; i++)
                {
                    tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, size));
                }

                int row = 0;

                tableLayoutPanel.Controls.Add(new Label() { Text = "" }, 0, row);

                int column = 1;

                List<TaskEntry> taskEntries = MainForm.INSTANCE.TaskEntryHandler.GetAllTaskAsList();

                foreach (TaskEntry taskEntry in taskEntries)
                {
                    tableLayoutPanel.Controls.Add(new Label() { Text = taskEntry.Title }, column++, row);
                }

                foreach (UserEntry userEntry in this.Values)
                {
                    this.AddUserToRow(userEntry, ++row, tableLayoutPanel, taskEntries);
                }

            }));
        }

        private void AddUserToRow(UserEntry userEntry, int row,TableLayoutPanel tableLayoutPanel, List<TaskEntry> taskEntries)
        {

            if (userEntry.Lehrer) return;

            bool enabled = userEntry.UserID == this.TheUser.UserID;

            tableLayoutPanel.Controls.Add(new Label() { Text = userEntry.Name}, 0, row);

            int column = 1;
            foreach (TaskEntry taskEntry in taskEntries)
            {
                Button button;

                if (!userEntry.FinishedTask(taskEntry))
                    button = new Button() { Text = "Ich arbeite noch", BackColor = Color.Red, ForeColor = Color.White, Enabled = enabled , Tag = taskEntry };
                else
                    button = new Button() { Text = "Ich bin fertig", BackColor = Color.Green, ForeColor = Color.White, Enabled = enabled, Tag = taskEntry };

                button.Click += Task_Button_Click;

                tableLayoutPanel.Controls.Add(button, column++, row);
            }
        }

        private void Task_Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            TaskEntry taskEntry = (TaskEntry)button.Tag;

            this.MainForm.LernhelferClient.SendPacket(new UserChangeTaskStateRequestPacket() { TaskTitle = taskEntry.Title, UserID = this.TheUser.UserID });
        }
    }
}
