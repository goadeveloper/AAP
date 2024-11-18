using Microsoft.EntityFrameworkCore;

namespace Backend.Data
{
    public class AppDataContext(DbContextOptions<AppDataContext> options) : DbContext(options)
    {

    }
}
