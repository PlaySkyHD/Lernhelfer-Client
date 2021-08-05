using Lehrnhelfer_Client.Client;
using Lehrnhelfer_Client.Entity;
using Lehrnhelfer_Client.Entity.Task;
using Lehrnhelfer_Client.Forms.Template;
using Lehrnhelfer_Server.Server.Packet;
using Lehrnhelfer_Server.Server.Packet.PType;
using Lehrnhelfer_Server.Server.Packet.PType.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lehrnhelfer_Client
{
    public partial class MainForm : Form
    {

        public static MainForm INSTANCE { get; private set; }

        public LernhelferClient LernhelferClient { get; private set; }
        public UserEntryHandler UserEntryHandler { get; private set; }
        public TaskEntryHandler TaskEntryHandler { get; private set; }
        public Form activeForm { get; private set; }

        public MainForm()
        {
            INSTANCE = this;

            InitializeComponent();

            this.template_panel.Width = this.Width;
            this.template_panel.Height = this.Height;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            this.LernhelferClient = new LernhelferClient("127.0.0.1", 8181);
            this.UserEntryHandler = new UserEntryHandler(this);
            this.TaskEntryHandler = new TaskEntryHandler(this);
            this.openChildForm(new LoginTemplate());
        }


        public void openChildForm(Form childForm)
        {
            this.Invoke(new Action(() => 
            {
                if (this.activeForm != null) this.activeForm.Close();
                this.activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                childForm.Width = this.template_panel.Width;
                childForm.Height = this.template_panel.Height;
                this.template_panel.Controls.Add(childForm);
                this.template_panel.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }));
        }
    }
}
