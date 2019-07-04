using Microsoft.EntityFrameworkCore;
using SifAdmin.Models;
using SifAdmin.Areas.Departamento.Models;

namespace SifAdmin.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }

        public DbSet<Departamentos> Departamentos { get; set; }
    }
}