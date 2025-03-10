using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlquilerDeLibro.Models;

public partial class Libro
{
    [Key]
    public int id_libro { get; set; }

    public string Titulo { get; set; } = null!;
        
    public string Autor { get; set; } = null!;

    public string Categoria { get; set; } = null!;

    public bool Disponible { get; set; }

    public decimal precio_alquiler { get; set; }

   
}
