using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Veterinarios.Models;

namespace Veterinarios.Data {



    /// <summary>
    /// Representa a Base de Dados do Nosso Sistema
    /// </summary>
   public class ApplicationDbContext : IdentityDbContext {
      public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options) {
      }
        
    //Definir as Tabelas

    public DbSet<Animais> Animais { get; set; }
    public DbSet<Donos> Donos { get; set; }
    public DbSet<Veterinarios.Models.MedicosVeterinarios> Veterinarios { get; set; }
    public DbSet<Consultas> Consultas { get; set; }




   }

}