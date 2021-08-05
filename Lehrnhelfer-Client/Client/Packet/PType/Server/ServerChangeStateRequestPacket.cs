using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet.PType.Server
{
    public class ServerChangeStateRequestPacket : IPacket
    {

        public int UserID { get; set; }
        public ServerState ServerState { get; set; }

        public void ReadPacket(BinaryReader binaryReader)
        {
            this.UserID = binaryReader.ReadInt32();
            this.ServerState = (ServerState)Enum.Parse(ServerState.GetType(), binaryReader.ReadString());
        }

        public void WritePacket(BinaryWriter binaryWriter)
        {
            binaryWriter.Write(this.UserID);
            binaryWriter.Write(this.ServerState.ToString());
        }
    }
}
