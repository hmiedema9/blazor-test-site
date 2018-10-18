using HaydenWebsite.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HaydenWebsite.Server.DataAccess
{
    public class LanguageContext : DbContext
    {
        public virtual DbSet<ProgrammingLanguage> tblLanguage { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=tcp:haydenmiedemaserver.database.windows.net,1433;Initial Catalog=haydenmiedemadb;Persist Security Info=False;User ID=[dbuser];Password=[dbpass];MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }
    }
}