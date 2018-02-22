using Dhwani._2.Application.VoiceService.CommandService;
using Dhwani._4.DataLayer.VoiceData.CommandData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhwani._3.Domain.VoiceDomain.PatternHandler.CommandHandler
{
    public class ConnectDataLayerGetCommands
    {
         public List<CommandService> FetchCommands()
        {
            CommandUserData ObjCommand = new CommandUserData();
            return ObjCommand.GetAllCommands();
        }
         public bool InsertCommand(CommandService cmdService)
         {
             ConnectDataLayerGetCommands commandData = new ConnectDataLayerGetCommands();

             return commandData.InsertCommandData(cmdService); 
         }


         internal bool InsertCommandData(CommandService cmdService)
         {
             return true;
         }




    }
}
