using Lehrnhelfer_Server.Server.Packet.PType.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client.Forms.Template
{
    public partial class LoginTemplate : Form
    {
        public LoginTemplate()
        {
            InitializeComponent();

            Util.Util.SendMessage(this.username_textBox.Handle, Util.Util.EM_SETCUEBANNER, 0, "Username");
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string username = this.username_textBox.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Bitte gebe ein Username an", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UserLoginRequestPacket userLoginRequestPacket = new UserLoginRequestPacket()
            {
                Username = username,
                Lehrer = this.lehrer_radioButton.Checked
            }; 

            MainForm.INSTANCE.LernhelferClient.SendPacket(userLoginRequestPacket);
        }
    }
}
