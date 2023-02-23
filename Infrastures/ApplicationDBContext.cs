using Application.Common;
using DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace Infrastures
{
    public class ApplicationDBContext : DbContext, IApplicationDbContext
    {
        //entities
        public DbSet<Investment> Investments { get; set; }

        
    }
}
