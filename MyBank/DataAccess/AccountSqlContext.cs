using Microsoft.EntityFrameworkCore;
using MyBank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBank.DataAccess
{
    public class AccountSqlContext : DbContext
    {
        public AccountSqlContext(DbContextOptions<AccountSqlContext> options) : base(options)
            {

            }

        public DbSet<Account> account { get; set; }
    }
}

