using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lehrnhelfer_Server.Server.Packet;

namespace Lehrnhelfer_Server.Server.Packet.PType.User
{
    public class UserLoginRequestPacket : IPacket
    {
        public string Username { get; set; }
        public bool Lehrer { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            this.Username = binaryReader.ReadString();
            this.Lehrer = binaryReader.ReadBoolean();
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.Username);
            binaryWriter.Write(this.Lehrer);
        }
    }
}
