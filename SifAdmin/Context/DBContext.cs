using Microsoft.EntityFrameworkCore;
using SifAdmin.Areas.Departamento.Models;
using SifAdmin.Models;

namespace SifAdmin.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
        
        public virtual DbSet<DepartamentoModel> Departamentos { get; set; }
    }
}