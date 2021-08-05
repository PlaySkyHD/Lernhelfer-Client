using Lehrnhelfer_Server.Server.Packet.PType.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            AppDomain.CurrentDomain.ProcessExit += (s, e) => 
            {
                if (MainForm.INSTANCE.UserEntryHandler.TheUser == null) return;
                MainForm.INSTANCE.LernhelferClient.SendPacket(new UserLogoutPacket() { Id = MainForm.INSTANCE.UserEntryHandler.TheUser.UserID });
            };
        }
    }
}
