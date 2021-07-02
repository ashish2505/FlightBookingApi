using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FlightBookingWebApi.DataModel;

namespace FlightBookingWebApi.Context
{
    public class FlightBookingContext:DbContext
    {
        public FlightBookingContext(DbContextOptions<FlightBookingContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }


    }
}
