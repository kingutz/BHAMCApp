﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using BHAMCApp.Models;
using BHAMCApp.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BHAMCApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {

        private readonly ICurrentUserService currentUserService;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, ICurrentUserService currentUserService)
            : base(options)
        {
            this.currentUserService = currentUserService ?? throw new ArgumentNullException(nameof(currentUserService));


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);
            builder.Entity<Bhamc>()
              .HasIndex(u => u.QuestionnaireNo)
             .IsUnique();
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            ProcessSave();
            return base.SaveChangesAsync(cancellationToken);
        }

        private void ProcessSave()
        {
            var currentTime = DateTime.UtcNow;
            foreach (var item in ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added && e.Entity is EntityData))
            {
                var entidad = item.Entity as EntityData;
                entidad.CreatedDate = currentTime;
                entidad.CreatedByUser = currentUserService.GetCurrentUsername();
                entidad.ModifiedDate = currentTime;
                entidad.ModifiedByUser = currentUserService.GetCurrentUsername();
            }

            foreach (var item in ChangeTracker.Entries()
                .Where(predicate: e => e.State == EntityState.Modified && e.Entity is EntityData))
            {
                var entidad = item.Entity as EntityData;
                entidad.ModifiedDate = currentTime;
                entidad.Edited = true;
                entidad.ModifiedByUser = currentUserService.GetCurrentUsername();
                item.Property(nameof(entidad.CreatedDate)).IsModified = false;
                item.Property(nameof(entidad.CreatedByUser)).IsModified = false;
            }
        }

        public DbSet<BHAMCApp.Models.Bhamc> Bhamc { get; set; }

        public DbSet<BHAMCApp.Models.FKMTOTO> FKMTOTO { get; set; }

        public DbSet<BHAMCApp.Models.FKMAMA> FKMAMA { get; set; }

        public DbSet<BHAMCApp.Models.FKBABA> FKBABA { get; set; }

        public DbSet<BHAMCApp.Models.FTMAMA> FTMAMA { get; set; }

        public DbSet<BHAMCApp.Models.FSMAMA> FSMAMA { get; set; }

        public DbSet<BHAMCApp.Models.FTISAMAMA> FTISAMAMA { get; set; }

        public DbSet<BHAMCApp.Models.FKMMAMA> FKMMAMA { get; set; }

        public DbSet<BHAMCApp.Models.F15_24MAMA> F15_24MAMA { get; set; }

        public DbSet<BHAMCApp.Models.F28_44MAMA> F28_44MAMA { get; set; }

        public DbSet<BHAMCApp.Models.F48MAMA> F48MAMA { get; set; }

        public DbSet<BHAMCApp.Models.FTMTOTO> FTMTOTO { get; set; }

        public DbSet<BHAMCApp.Models.FSMTOTO> FSMTOTO { get; set; }

        public DbSet<BHAMCApp.Models.FTISAMTOTO> FTISAMTOTO { get; set; }

        public DbSet<BHAMCApp.Models.FKMMTOTO> FKMMTOTO { get; set; }

        public DbSet<BHAMCApp.Models.F12_24MTOTO> F12_24MTOTO { get; set; }

        public DbSet<BHAMCApp.Models.F28_44MTOTO> F28_44MTOTO { get; set; }

        public DbSet<BHAMCApp.Models.F48MTOTO> F48MTOTO { get; set; }

        public DbSet<BHAMCApp.Models.BHAMCDATA> BHAMCDATA { get; set; }
    }
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
    }
}
