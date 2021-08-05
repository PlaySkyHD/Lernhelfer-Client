using Lehrnhelfer_Server.Server.Packet.PType.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client.Entity.Task
{
    public class TaskEntryHandler : Dictionary<string, TaskEntry>
    {

        private MainForm MainForm;


        public TaskEntryHandler(MainForm mainForm)
        {
            this.MainForm = mainForm;

            Timer timer = new Timer()
            {
                Enabled = true,
                Interval = 1087 //SCHMUTZ KANN NICHT 2 Packete gleichzeitig senden, ungerader Delay
            };
            timer.Tick += UpdateTaskTimer_Tick;
        }

        private void UpdateTaskTimer_Tick(object sender, EventArgs e)
        {
            if (MainForm.INSTANCE.UserEntryHandler.TheUser == null) return;
            MainForm.INSTANCE.LernhelferClient.SendPacket(new TaskGetAllRequestPacket());
        }

        public void HandleNewTasks(List<TaskEntry> taskEntries)
        {
            this.Clear();
            taskEntries.ForEach(TaskEntry => this.Add(TaskEntry.Title, TaskEntry));
        }
        public List<TaskEntry> GetAllTaskAsList()
        {
            List<TaskEntry> taskEntries = new List<TaskEntry>();
            foreach (TaskEntry item in this.Values)
            {
                taskEntries.Add(item);
            }
            return taskEntries;
        }
    }
}
