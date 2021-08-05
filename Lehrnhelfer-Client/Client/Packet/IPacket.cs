using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet
{
    public interface IPacket
    {
        void WritePacket(BinaryWriter binaryWriter);

        void ReadPacket(BinaryReader binaryReader);
    }
}
