using System;
using Microsoft.EntityFrameworkCore;
using quoter.model;

namespace quoter.data
{
    public interface IQuoterContext
    {
        DbSet<Company> Companies { get; set; }
    }
}
