using FlightBookingWebApi.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlightBookingWebApi.DataModel;

namespace FlightBookingWebApi.Services.User
{
    public class UserService : IUserService
    {
        private readonly FlightBookingContext _FlightBookingContext;

        public UserService(FlightBookingContext flightBookingContext)
        {
            _FlightBookingContext = flightBookingContext;
        }
        public string IsValidUser(string userName, string password)
        {
            //return _FlightBookingContext.Users.Where(x => string.Equals(x.UserName, userName, StringComparison.OrdinalIgnoreCase) && string.Equals(x.Password, password, StringComparison.Ordinal)).Any();
            return _FlightBookingContext.Users.Where(x => x.UserName == userName && x.Password == password).Select(a=>a.Role).FirstOrDefault();
        }
    }
}
