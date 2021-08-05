using Lehrnhelfer_Client.Entity.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Client.Entity
{
    public class UserEntry
    {

        public readonly int UserID;
        public string Name { get; set; }
        public List<TaskEntry> Tasks { get; private set; }

        public bool Lehrer { get; private set; }

        public UserEntry(int id, bool lehrer)
        {
            this.UserID = id;
            this.Lehrer = lehrer;
            this.Tasks = new List<TaskEntry>();
        }

        public bool FinishedTask(TaskEntry taskEntry)
        {
            foreach (var item in this.Tasks)
            {
                if (item.Title.Equals(taskEntry.Title))
                    return true;
            }
            return false;
        }
    }
}
