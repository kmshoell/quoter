using System;
using Microsoft.EntityFrameworkCore;
using quoter.model;

namespace quoter.data
{
    public class CompanyRepository : RepositoryBase<Company, QuoterContext>, ICompanyRepository
    {
        public CompanyRepository(QuoterContext context)
        {
            this.context = context;
            this.dbSet = context.Companies;
        }

        public override QuoterContext context { get; }

        public override DbSet<Company> dbSet { get; }
    }
}
