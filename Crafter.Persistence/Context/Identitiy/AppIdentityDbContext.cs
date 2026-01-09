using System;
using Microsoft.EntityFrameworkCore;

namespace CrafterApi.Crafter.Persistance.Context.Identitiy
{


	public class AppIdentityDbContext :IdentityDbContext<AppIdentityUser, AppIdentityRole,string>
	{
		public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options)
		{
		}
        
        protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.Entity<AppIdentityUser>(b =>
			{
				b.ToTable("Users");
			});

			builder.Entity<AppIdentityRole>(b =>
			{
				b.ToTable("Roles");
            })
        }
    }
}

