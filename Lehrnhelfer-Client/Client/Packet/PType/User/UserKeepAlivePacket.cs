using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lehrnhelfer_Server.Server.Packet.PType.User
{
    public class UserKeepAlivePacket : IPacket
    {
        public int Id { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            this.Id = binaryReader.ReadInt32();
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.Id);
        }
    }
}
