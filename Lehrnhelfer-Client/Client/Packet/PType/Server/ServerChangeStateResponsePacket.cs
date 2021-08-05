using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet.PType.Server
{
    public class ServerChangeStateResponsePacket : IPacket
    {

        public ServerState NewServerState { get; set; }
        /**
         * 0 = OK
         * 1 = Already in use
         * 2 = Not Allowed
         */
        public int ErrorCode { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            this.NewServerState = (ServerState)Enum.Parse(typeof(ServerState), binaryReader.ReadString());
            this.ErrorCode = binaryReader.ReadInt32();
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.NewServerState.ToString());
            binaryWriter.Write(this.ErrorCode);

        }
    }
}
