using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;



namespace NetCommon
{
    public class KNetDbContext : DbContext
    {
        public KNetDbContext()
        {

        }

        public KNetDbContext(DbContextOptions<KNetDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(NetCommon.Configuration.GetItem("ConnectionStrings"));
            }
        }


        #region Entity DbSet<>
        //public virtual DbSet<m_AppManager> m_AppManager { get; set; }
        #endregion

    }
}
