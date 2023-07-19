using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class incidenceContext : DbContext {
    public incidenceContext(DbContextOptions<incidenceContext> options) : base(options) { 

    }
}