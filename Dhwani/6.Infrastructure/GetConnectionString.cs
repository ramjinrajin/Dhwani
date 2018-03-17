using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhwani._6.Infrastructure
{
  public  static class GetConnectionString
    {
      public static string connect()
      {
          string DbLocation = Environment.CurrentDirectory.ToString();
          //Remote Database
          //workstation id=Voicemanglish.mssql.somee.com;packet size=4096;user id=voicemanglish_SQLLogin_1;pwd=7tgw25rv4q;data source=Voicemanglish.mssql.somee.com;persist security info=False;initial catalog=Voicemanglish
          //Local Database
         // Data Source=(LocalDB)\v11.0;AttachDbFilename={0}\Dhwani_DB.mdf;Integrated Security=True
          string ConnectionString = string.Format(@"workstation id=Voicemanglish.mssql.somee.com;packet size=4096;user id=voicemanglish_SQLLogin_1;pwd=7tgw25rv4q;data source=Voicemanglish.mssql.somee.com;persist security info=False;initial catalog=Voicemanglish", DbLocation);
          return ConnectionString;
      }
    }
}
