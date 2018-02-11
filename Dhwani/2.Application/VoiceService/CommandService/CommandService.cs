using Dhwani._3.Domain.VoiceDomain.PatternHandler.CommandHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhwani._2.Application.VoiceService.CommandService
{
   public class CommandService
    {
        public string CommandId { get; set; }
        public string Manglish { get; set; }
        public string Malayalam { get; set; }
        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsDeleted { get; set; }
    }


    public class CommandServiceConnectDomain
    {
        public List<CommandService> CommandList()
        {
            ConnectDataLayerGetCommands commandData = new ConnectDataLayerGetCommands();

            return commandData.FetchCommands();
        }

        public bool InsertCommand(CommandService cmdService)
        {
            ConnectDataLayerGetCommands commandData = new ConnectDataLayerGetCommands();

            return commandData.InsertCommandData(cmdService);
        }
    }
}
