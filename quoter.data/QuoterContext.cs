using System;
using Microsoft.EntityFrameworkCore;
using quoter.model;

namespace quoter.data
{
    //Context that interfaces with Database using Entity Framework Core
    public class QuoterContext : DbContext, IQuoterContext
    {
        public QuoterContext()
        {

        }

        public DbSet<Company> Companies { get; set; }
    }
}
