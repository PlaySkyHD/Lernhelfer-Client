using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Client.Entity.Task
{
    public class TaskEntry
    {
        public string Title { get; set; }

        public TaskEntry(string title)
        {
            this.Title = title;
        }
    }
}
