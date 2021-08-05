using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet.PType.User
{
    public class UserChangeTaskStateResponsePacket : IPacket
    {
        public string Title { get; set; }
        public bool Finished { get; set; }
        
        public void ReadPacket(BinaryReader binaryReader)
        {
            this.Title = binaryReader.ReadString();
            this.Finished = binaryReader.ReadBoolean();
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.Title);
            binaryWriter.Write(this.Finished);
        }
    }
}
