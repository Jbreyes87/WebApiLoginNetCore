using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiLogin.Modelo;

namespace WebApiLogin.Contexto
{
    public class AplicationDbContext : IdentityDbContext<AplicationUser>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
        :base(options){

            }

            // puedes seguir utilizando tus modelos para generar tus tablas de manera normal
            //ya que el IdentityDbContext es una interface que usa todas sus clses como el dbcontext etc
    }
}
