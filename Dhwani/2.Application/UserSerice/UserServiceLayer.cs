using Dhwani._2.Application.Models;
using Dhwani._3.Domain.UserDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dhwani._2.Application.UserSerice
{
  public  class UserServiceLayer
    {

      public string UserService_GetResponse(User _user)
      {
          //This Layer has all the Business concepts call this to validate
          UserDomainLayer domainLayerObj = new UserDomainLayer();
        return  domainLayerObj.UserBusinessLayer(_user);
      }
    }
}
