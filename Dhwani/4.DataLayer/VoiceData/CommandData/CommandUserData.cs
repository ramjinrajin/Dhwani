using Dhwani._2.Application.VoiceService.CommandService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using Dhwani._6.Infrastructure;

namespace Dhwani._4.DataLayer.VoiceData.CommandData
{
   public class CommandUserData
    {
       public bool InsertData(CommandService cmdService)
       {
           try
           {
               using (SqlConnection con = new SqlConnection(GetConnectionString.connect()))
               {

                   con.Open();
                   SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[DhwCommand] ([Manglish],[Malayalam] )VALUES (@Manglish,@Malayalam)", con);
                   cmd.Parameters.AddWithValue("@Manglish", cmdService.Manglish);
                   cmd.Parameters.AddWithValue("@Malayalam", cmdService.Malayalam);
                  
                   cmd.ExecuteNonQuery();
                   con.Close();

               }

               return true;
           }
           catch  
           {
               //Log(ex)

               return false;
           }
       }



        internal List<CommandService> GetAllCommands()
        {
            //Data base code comes here
            throw new NotImplementedException();
        }
    }
}
