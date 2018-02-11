using Dhwani._2.Application.Models;
using Dhwani._4.DataLayer.UserDateLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhwani._3.Domain.UserDomain
{

    //Busniness logics or Requirement
   public class UserDomainLayer
    {

       public string UserBusinessLayer(User _user)
       {
           bool IsValid = false;
           

           if(_user.MobileNO.ToString().Length>=10)
           {
               IsValid = true;
               //return InsertData(_user);
           }
           else
           {
               return "Mobile number should be greater than 10";
           }

           if (_user.Email.ToString().Length >2)
           {
               IsValid = true;
               //return InsertData(_user);
           }
           else
           {
               return "Email Id should be greater than 10";
           }

           if (_user.FirstName.ToString().Length >2)
           {
               IsValid = true;
               //return InsertData(_user);
           }
           else
           {
               return "First Name should be greater than 10";
           }

           string Response = "";
           if(IsValid==true)
           {
              Response= InsertData(_user);
           }

           return Response;
          
       }

       private string InsertData(User _user)
       {
           UserDataManager ObjManager = new UserDataManager();
           bool Response = ObjManager.InsertNewUser(_user);

           if (Response == true)
           {
               return "Data inserted sucessfully";
           }
           else
           {
               return "Data failed to insert !!! Something Went wrong";
           }
       }
    }
}
