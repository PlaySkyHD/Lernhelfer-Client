using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet.PType
{
    public class UserLoginResponsePacket : IPacket
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public bool Lehrer { get; set; }
        /**
         * 0 = OK
         * 1 = Username already exists
         * 2 = HELFERSYSTEM is online
         */
        public int ErrorCode { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            this.Id = binaryReader.ReadInt32();
            this.Username = binaryReader.ReadString();
            this.Lehrer = binaryReader.ReadBoolean();
            this.ErrorCode = binaryReader.ReadInt32();
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.Id);
            binaryWriter.Write(this.Username);
            binaryWriter.Write(this.Lehrer);
            binaryWriter.Write(this.ErrorCode);
        }
    }
}
