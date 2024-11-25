using CleanArchitectureCQRs.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitectureCQRs.Infrastructure.Context;

public class IdentityDbContextFactory : IDesignTimeDbContextFactory<IdentityContext>
{
    public IdentityContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<IdentityContext>();
        optionsBuilder.UseSqlServer("Server=DESKTOP-SQF67QH;Database=IdentitytestDB;Trusted_Connection=True;TrustServerCertificate=True;");

        return new IdentityContext(optionsBuilder.Options);
    }

}
