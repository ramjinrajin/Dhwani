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
          return "Data Source=DESKTOP-DPB87O9\\SQLEXPRESS;Initial Catalog=DHWANI;Persist Security Info=True;User ID=sa;Password=dhwani";
      }
    }
}
