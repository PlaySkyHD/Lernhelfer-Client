using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet.PType.User
{
    public class UserChangeTaskStateRequestPacket : IPacket
    {

        public int UserID { get; set; }
        public string TaskTitle { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            this.UserID = binaryReader.ReadInt32();
            this.TaskTitle = binaryReader.ReadString();
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.UserID);
            binaryWriter.Write(this.TaskTitle);
        }
    }
}
