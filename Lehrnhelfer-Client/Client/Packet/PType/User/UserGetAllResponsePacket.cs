using Lehrnhelfer_Client;
using Lehrnhelfer_Client.Entity;
using Lehrnhelfer_Client.Entity.Task;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lehrnhelfer_Server.Server.Packet.PType.User
{
    public class UserGetAllResponsePacket : IPacket
    {

        public List<UserEntry> UserEntries { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            if (this.UserEntries == null)
                this.UserEntries = new List<UserEntry>();
            int count = binaryReader.ReadInt32();
            for (int i = 0; i < count; i++)
            {
                UserEntry userEntry = new UserEntry(binaryReader.ReadInt32(), binaryReader.ReadBoolean()) { Name = binaryReader.ReadString() };

                int countTask = binaryReader.ReadInt32();
                for (int x = 0; x < countTask; x++)
                {
                    string title = binaryReader.ReadString();
                    if (MainForm.INSTANCE.TaskEntryHandler.ContainsKey(title))
                        userEntry.Tasks.Add(MainForm.INSTANCE.TaskEntryHandler[title]);
                }
                this.UserEntries.Add(userEntry);
            } 
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            if (this.UserEntries == null)
                this.UserEntries = new List<UserEntry>();
            binaryWriter.Write(this.UserEntries.Count);

            foreach (UserEntry userEntry in this.UserEntries)
            {
                binaryWriter.Write(userEntry.UserID);
                binaryWriter.Write(userEntry.Lehrer);
                binaryWriter.Write(userEntry.Name);

                binaryWriter.Write(userEntry.Tasks.Count);
                foreach (TaskEntry taskEntry in userEntry.Tasks)
                {
                    binaryWriter.Write(taskEntry.Title);
                }
            }
        }
    }
}
