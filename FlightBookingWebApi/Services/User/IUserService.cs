
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBookingWebApi.Services.User
{
    public interface IUserService
    {
        public string IsValidUser(string userName, string password);
    }
}
