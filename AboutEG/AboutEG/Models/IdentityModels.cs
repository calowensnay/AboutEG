﻿using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace AboutEG.Models
{
    // Para agregar datos de perfil del usuario, agregue más propiedades a su clase ApplicationUser. Visite https://go.microsoft.com/fwlink/?LinkID=317594 para obtener más información.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
           string  CadenaConexionBBDD = "Data Source=.;Initial Catalog=AboutEGDB;User Id=AboutEG;Password=Pa$$w0rd2019&";
            this.Database.Connection.ConnectionString = CadenaConexionBBDD;
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<DistribucionTerritorial> DistribucionesTerritorial { get; set; }

        public System.Data.Entity.DbSet<AboutEG.Models.Tag> Tags { get; set; }

        public System.Data.Entity.DbSet<AboutEG.Models.Post> Posts { get; set; }

        public System.Data.Entity.DbSet<AboutEG.Models.Category> Categories { get; set; }
    }
}