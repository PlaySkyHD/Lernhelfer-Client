using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet.PType.Task
{
    public class TaskCreateResponsePacket : IPacket
    {
        public string Name { get; set; }
        /**
         * 0 = OK
         * 1 = Task already exists
         * 2 = Not Allowed
         * 3 = HELFERSYSTEM is online
         */
        public int ErrorCode { get; set; }
        public void ReadPacket(BinaryReader binaryReader)
        {
            this.Name = binaryReader.ReadString();
            this.ErrorCode = binaryReader.ReadInt32();
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.Name);
            binaryWriter.Write(this.ErrorCode);
        }
    }
}
