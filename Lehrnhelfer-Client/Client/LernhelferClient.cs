using Lehrnhelfer_Server.Server.Packet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client.Client
{
    public class LernhelferClient
    {

        public readonly string Host;
        public readonly int Port;

        public TcpClient TcpClient { get; private set; }
        public NetworkStream Stream { get; private set; }
        public LernhelferClientHandler LernhelferClientHandler { get; private set; }

        public LernhelferClient(string host, int port) 
        {
            this.Host = host;
            this.Port = port;
            
            this.LernhelferClientHandler = new LernhelferClientHandler(this);
        }

        public bool Connected()
        {
            try
            {
                this.TcpClient = new TcpClient(this.Host, this.Port);
                this.Stream = this.TcpClient.GetStream();
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Server ist offline", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return false;
            }
        }

        public void SendPacket(IPacket packet, bool callback)
        {
            if (!this.Connected()) return;

            BinaryWriter binaryWriter = new BinaryWriter(this.Stream);
            binaryWriter.Write(PacketType.GetPacketId(packet.GetType()));

            packet.WritePacket(binaryWriter);
            binaryWriter.Flush();

            if (!callback) return;

            new Thread(() => {
                try
                {
                    BinaryReader binaryReader = new BinaryReader(this.Stream);

                    int packetID = binaryReader.ReadInt32();

                    Type packetType = PacketType.FromPacketId(packetID);

                    if (packetType == null)
                    {
                        Console.WriteLine("Received unkown Packet (ID: " + packetID + ")");
                        return;
                    }
                    IPacket ipacket = (IPacket)Activator.CreateInstance(packetType);
                    ipacket.ReadPacket(binaryReader);

                    this.LernhelferClientHandler.Handle(ipacket, this.Stream);
                    Thread.Sleep(250);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.StackTrace);
                    Console.WriteLine(e2.Message);
                }
            }).Start();
        }

        public void SendPacket(IPacket packet)
        {
            this.SendPacket(packet, true);
        }


    }
}
