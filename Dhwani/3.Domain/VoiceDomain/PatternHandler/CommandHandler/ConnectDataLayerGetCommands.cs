using Dhwani._2.Application.VoiceService.CommandService;
using Dhwani._4.DataLayer.VoiceData.CommandData;
using Dhwani._6.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

            using (SqlConnection con = new SqlConnection(GetConnectionString.connect()))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(string.Format("INSERT INTO [dbo].[MalayalamLanguageBase]([MalayalamWord],[Manglish])VALUES(N'{0}' ,@Manglish)", cmdService.Malayalam), con);
                    cmd.Parameters.AddWithValue("@Manglish", cmdService.Manglish);
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        internal List<CommandService> GetAllCommands()
        {
            List<CommandService> listcmd = new List<CommandService>();

            using (SqlConnection con = new SqlConnection(GetConnectionString.connect()))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from MalayalamLanguageBase", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if(rdr.HasRows)
                    {
                        while(rdr.Read())
                        {
                            CommandService MalCmd = new CommandService
                            {
                                Malayalam = rdr["MalayalamWord"].ToString(),
                                Manglish = rdr["Manglish"].ToString()
                            };
                            listcmd.Add(MalCmd);
                        }
                    }

                    
                  
                }
                catch (Exception)
                {

                    throw;
                }

                finally
                {

                }

            }





            return listcmd;
        }


    }
}
