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
          string ConnectionString = string.Format(@"Data Source=(LocalDB)\v11.0;AttachDbFilename={0}\Dhwani_DB.mdf;Integrated Security=True", DbLocation);
          return ConnectionString;
      }
    }
}
