using Lehrnhelfer_Client.Entity;
using Lehrnhelfer_Client.Forms.Template;
using Lehrnhelfer_Server.Server.Packet;
using Lehrnhelfer_Server.Server.Packet.PType;
using Lehrnhelfer_Server.Server.Packet.PType.Server;
using Lehrnhelfer_Server.Server.Packet.PType.Task;
using Lehrnhelfer_Server.Server.Packet.PType.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client.Client
{
    public class LernhelferClientHandler
    {

        private readonly LernhelferClient LernhelferClient;

        public LernhelferClientHandler(LernhelferClient lernhelferClient)
        {
            this.LernhelferClient = lernhelferClient;
        }

        public void Handle(IPacket packet, NetworkStream stream)
        {
            if(packet is UserLoginResponsePacket)
            {
                UserLoginResponsePacket userLoginResponsePacket = (UserLoginResponsePacket)packet;

                if(userLoginResponsePacket.ErrorCode == 1)
                {
                    MessageBox.Show("Der Username existiert schon", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (userLoginResponsePacket.ErrorCode == 2)
                {
                    MessageBox.Show("Du kannst dich derzeitig nich anmelden, das Helfersystem wurde gerstartet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MainForm.INSTANCE.UserEntryHandler.TheUser = new UserEntry(userLoginResponsePacket.Id, userLoginResponsePacket.Lehrer) 
                {
                    Name = userLoginResponsePacket.Username
                };
                Console.WriteLine(MainForm.INSTANCE.UserEntryHandler.TheUser.UserID + " | " + MainForm.INSTANCE.UserEntryHandler.TheUser.Name + " | " + userLoginResponsePacket.Lehrer);
                MainForm.INSTANCE.openChildForm(new DashboardTemplate());
            }
            else if (packet is UserGetAllResponsePacket)
            {
                UserGetAllResponsePacket userGetAllResponsePacket = (UserGetAllResponsePacket)packet;
                MainForm.INSTANCE.UserEntryHandler.HandleNewUser(userGetAllResponsePacket.UserEntries);
            }
            else if (packet is TaskCreateResponsePacket)
            {
                TaskCreateResponsePacket taskCreateResponsePacket = (TaskCreateResponsePacket)packet;

                switch (taskCreateResponsePacket.ErrorCode)
                {
                    case 0:
                        MessageBox.Show("Du hast erfolgreich die Aufgabe " + taskCreateResponsePacket.Name + " erstellt!", "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("Es existiert schon eine Aufgabe mit dem Namen " + taskCreateResponsePacket.Name, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        MessageBox.Show("Du hast nicht die nötigen Rechte!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 3:
                        MessageBox.Show("Du kannst gerade keine Aufgabeerstellen, das Helfersystem wurde gerstartet!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            else if (packet is TaskGetAllResponsePacket)
            {
                TaskGetAllResponsePacket taskGetAllResponsePacket = (TaskGetAllResponsePacket)packet;
                MainForm.INSTANCE.TaskEntryHandler.HandleNewTasks(taskGetAllResponsePacket.TaskEntries);
            }
            else if (packet is UserChangeTaskStateResponsePacket)
            {
                UserChangeTaskStateResponsePacket userChangeTaskStateResponsePacket = (UserChangeTaskStateResponsePacket)packet;
                MessageBox.Show((userChangeTaskStateResponsePacket.Finished ? "Du hast die Aufgabe erfolgreich bearbeitet!" : "Du hast die Augabe wieder zurückgezogen!") + "(Fach: " + userChangeTaskStateResponsePacket.Title + ")", "Actio", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (packet is ServerChangeStateResponsePacket)
            {
                ServerChangeStateResponsePacket serverChangeStateResponsePacket = (ServerChangeStateResponsePacket)packet;

                switch (serverChangeStateResponsePacket.ErrorCode)
                {
                    case 0:
                        MessageBox.Show("Du hast den Sever-State geändert zu " + serverChangeStateResponsePacket.NewServerState.ToString(), "Erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show("Der Server-State(" + serverChangeStateResponsePacket.NewServerState.ToString() + ") ist gerade schon in Benutzung!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    case 2:
                        MessageBox.Show("Du hast nicht die nötigen Rechte!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                }

            }
        }
        

    }
}
