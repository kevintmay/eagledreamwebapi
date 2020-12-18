using Microsoft.EntityFrameworkCore;
using eagleDreamWebAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eagleDreamWebAPI.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {

        }

        public virtual DbSet<User> User { get; set; }

        public virtual DbSet<GroupMembership> GroupMembership { get; set; }

        public virtual DbSet<GroupType> GroupType { get; set; }

        public virtual DbSet<TransactionType> TransactionType { get; set; }

        public virtual DbSet<UserTransaction> UserTransaction { get; set; }

        public virtual DbSet<VwUserTransactionsTotalByMonthAll> VwUserTransactionsTotalByMonthAll { get; set; }

        public virtual DbSet<VwGroupBalanceByMonth> VwGroupBalanceByMonth { get; set; }

        public virtual DbSet<VwTransactionCountByMonth> VwTransactionCountByMonth { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .HasKey(u => new { u.u_id });

            modelBuilder.Entity<GroupType>()
                .HasKey(b => b.gt_id);

            modelBuilder.Entity<TransactionType>()
                .HasKey(b => b.tt_id);

            modelBuilder.Entity<UserTransaction>()
                .HasKey(b => b.ut_id);

            modelBuilder.Entity<GroupMembership>()
                .HasNoKey();

            modelBuilder.Entity<VwGroupBalanceByMonth>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("Vw_GroupBalanceByMonth");
            });

            modelBuilder.Entity<VwTransactionCountByMonth>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("Vw_TransactionCountByMonth");
            });

            modelBuilder.Entity<VwUserTransactionsTotalByMonthAll>(eb =>
            {
                eb.HasNoKey();
                eb.ToView("Vw_UserTransactionsTotalByMonthAll");
            });

        }

    }
}
