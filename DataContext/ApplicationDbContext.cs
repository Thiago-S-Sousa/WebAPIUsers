using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiUsers.Models;

namespace WebApiUsers.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        //Configuração padrão para banco de dados com EntityFrameworkCore <---
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        //Passando o model que vai virar tabela
        public DbSet<EmployeeModel> Employees { get; set; }
    }
}