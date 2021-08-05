using Lehrnhelfer_Server.Server.Packet.PType;
using Lehrnhelfer_Server.Server.Packet.PType.Server;
using Lehrnhelfer_Server.Server.Packet.PType.Task;
using Lehrnhelfer_Server.Server.Packet.PType.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lehrnhelfer_Server.Server.Packet
{

    public class PacketType
    {

        /**
         * USER
         */
        public static readonly PacketType USER_LOGIN_REQUEST_PACKET = new PacketType(1, typeof(UserLoginRequestPacket));
        public static readonly PacketType USER_LOGIN_RESPONSE_PACKET = new PacketType(2, typeof(UserLoginResponsePacket));
        public static readonly PacketType USER_KEEP_ALIVE_PACKET = new PacketType(3, typeof(UserKeepAlivePacket));
        public static readonly PacketType USER_LOGOUT_PACKET = new PacketType(4, typeof(UserLogoutPacket));
        public static readonly PacketType USER_GET_ALL_RESPONSE_PACKET = new PacketType(5, typeof(UserGetAllResponsePacket));
        public static readonly PacketType USER_GET_ALL_REQUEST_PACKET = new PacketType(6, typeof(UserGetAllRequestPacket));
        public static readonly PacketType USER_CHANGE_TASK_STATE_REQUEST_PACKET = new PacketType(11, typeof(UserChangeTaskStateRequestPacket));
        public static readonly PacketType USER_CHANGE_TASK_STATE_RESPONSE_PACKET = new PacketType(12, typeof(UserChangeTaskStateResponsePacket));


        /**
         * TASK
         */
        public static readonly PacketType TASK_CREATE_REQUEST_PACKET = new PacketType(7, typeof(TaskCreateRequestPacket));
        public static readonly PacketType TASK_CREATE_RESPONSE_PACKET = new PacketType(8, typeof(TaskCreateResponsePacket));
        public static readonly PacketType TASK_GET_ALL_REQUEST_PACKET = new PacketType(9, typeof(TaskGetAllRequestPacket));
        public static readonly PacketType TASK_GET_ALL_RESPONSE_PACKET = new PacketType(10, typeof(TaskGetAllResponsePacket));


        /**
         * Server
         */
        public static readonly PacketType SERVER_CHANGE_STATE_REQUEST_PACKET = new PacketType(13, typeof(ServerChangeStateRequestPacket));
        public static readonly PacketType SERVER_CHANGE_STATE_RESPONSE_PACKET = new PacketType(14, typeof(ServerChangeStateResponsePacket));



        public static readonly PacketType[] Values = new PacketType[] { USER_LOGIN_REQUEST_PACKET, USER_LOGIN_RESPONSE_PACKET, USER_KEEP_ALIVE_PACKET, USER_LOGOUT_PACKET, USER_GET_ALL_RESPONSE_PACKET, TASK_CREATE_REQUEST_PACKET, TASK_CREATE_RESPONSE_PACKET, TASK_GET_ALL_REQUEST_PACKET, TASK_GET_ALL_RESPONSE_PACKET, USER_CHANGE_TASK_STATE_REQUEST_PACKET, USER_CHANGE_TASK_STATE_RESPONSE_PACKET, SERVER_CHANGE_STATE_REQUEST_PACKET, SERVER_CHANGE_STATE_RESPONSE_PACKET};

        public readonly int Id;
        public readonly Type PacketClazz;

        public PacketType(int id, Type packetClazz)
        {
            this.Id = id;
            this.PacketClazz = packetClazz;
        }

        public static int GetPacketId(Type type)
        {
            foreach (PacketType item in Values)
            {
                if (item.PacketClazz == type)
                    return item.Id;
            }
            return -1;
        }

        public static Type FromPacketId(int packetId)
        {
            foreach (PacketType item in Values)
            {
                if (item.Id == packetId)
                    return item.PacketClazz;
            }
            return null;
        }

    }


}
