using Microsoft.EntityFrameworkCore;

namespace PearDBApi.Infrastructure.Persistence;

public class PearDBApiDbContext(DbContextOptions<PearDBApiDbContext> options) : DbContext(options)
{

}