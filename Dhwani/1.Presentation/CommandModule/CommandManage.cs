using Dhwani._2.Application.VoiceService.CommandService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dhwani._1.Presentation.CommandModule
{
    public partial class CommandManage : Form
    {
        public CommandManage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CommandManage_Load(object sender, EventArgs e)
        {
            CommandServiceConnectDomain CommandsData = new CommandServiceConnectDomain();
            List<CommandService> ListCommands = CommandsData.CommandList();
        }
    }
}
