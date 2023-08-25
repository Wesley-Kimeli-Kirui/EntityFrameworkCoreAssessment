using Assessmet4.Connection;

try
{
    AppDbContext db = new AppDbContext();
    db.Database.EnsureCreated();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
