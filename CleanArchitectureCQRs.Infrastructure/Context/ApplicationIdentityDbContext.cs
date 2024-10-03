using CleanArchitectureCQRs.Infrastructure.IdentityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace CleanArchitectureCQRs.Infrastructure.Context;

public class ApplicationIdentityDbContext : IdentityDbContext<AppUser>
{
    public ApplicationIdentityDbContext(DbContextOptions<ApplicationIdentityDbContext> options) : base(options) { }

}
