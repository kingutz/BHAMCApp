using System;
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
    }
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        public string Name { get; set; }
    }
}
