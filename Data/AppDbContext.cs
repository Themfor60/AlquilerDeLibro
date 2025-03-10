using System;
using System.Collections.Generic;
using AlquilerDeLibro.Models;
using Microsoft.EntityFrameworkCore;

namespace AlquilerDeLibro.Data;
//Peligro!! Este es el constructor no cambiar nada o se jode esto 
public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Alquilere> Alquileres { get; set; }

    public virtual DbSet<Libro> Libros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }



}
///////////////////////////////
///Uriel Uriel URIEL Uriel La parita XD
//////////////////////////////