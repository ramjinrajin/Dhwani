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
    public partial class Command : Form
    {
        public Command()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CommandServiceConnectDomain objData = new CommandServiceConnectDomain();

            CommandService objModel = new CommandService();
           objModel.Malayalam=txtMalayalam.Text;
            objModel.Manglish=txtManglish.Text;
            bool Result=false;
            Result = objData.InsertCommand(objModel);
            if(Result==true)
            {
                MessageBox.Show("Command inserted inserted");
            }
            else
            {
                MessageBox.Show("Command inserted failed");
            }
        }
    }
}
