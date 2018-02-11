using Dhwani._2.Application.Models;
using Dhwani._6.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhwani._4.DataLayer.UserDateLayer
{
   public class UserDataManager
    {
       public bool InsertNewUser(User _user)
       {
           try
           {
               using (SqlConnection con = new SqlConnection(GetConnectionString.connect()))
              {
                  
                  con.Open();
                  SqlCommand cmd = new SqlCommand("INSERT INTO [DhwUsers] (FirstName,LastName,Email,[Mobile],[Address],Pincode) Values (@Firstname,@lastname,@email,@mobile,@address,@pincode)", con);
                  cmd.Parameters.AddWithValue("@Firstname",_user.FirstName);
                  cmd.Parameters.AddWithValue("@lastname", _user.LastName);
                  cmd.Parameters.AddWithValue("@email", _user.Email);
                  cmd.Parameters.AddWithValue("@mobile", _user.MobileNO);
                  cmd.Parameters.AddWithValue("@address", _user.Address);
                  cmd.Parameters.AddWithValue("@pincode", _user.Pincode);
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
    }
}
