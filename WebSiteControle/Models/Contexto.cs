using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WebSiteControle.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pesssoas { get; set; }

        public Contexto(DbContextOptions<Contexto> opecoes ): base(opecoes)
        {

        }

    }
}
