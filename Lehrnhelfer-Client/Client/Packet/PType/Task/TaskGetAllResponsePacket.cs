using Lehrnhelfer_Client.Entity.Task;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet.PType.Task
{
    public class TaskGetAllResponsePacket : IPacket
    {
        public List<TaskEntry> TaskEntries { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            if (this.TaskEntries == null)
                this.TaskEntries = new List<TaskEntry>();

            int count = binaryReader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                this.TaskEntries.Add(new TaskEntry(binaryReader.ReadString()));
            }
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            if (this.TaskEntries == null)
                this.TaskEntries = new List<TaskEntry>();

            binaryWriter.Write(this.TaskEntries.Count);
            foreach (TaskEntry taskEntry in this.TaskEntries)
            {
                binaryWriter.Write(taskEntry.Title);
            }
        }
    }
}
