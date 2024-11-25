# CQRS Project

update-DataBase -context "ApplicationDbContext"


Adding a design-time factory for ApplicationDbContext is necessary if Entity Framework Core cannot automatically resolve your DbContext configuration during design-time operations, such as running migration-related commands (Add-Migration, Update-Database, etc.).
IDesignTimeDbContextFactory