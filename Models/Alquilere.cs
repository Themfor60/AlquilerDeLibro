using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquilerDeLibro.Models;

public partial class Alquilere
{
    [Key]
    public int id_alquiler { get; set; }

    public int? id_usuario { get; set; }
    
    public int? id_libro { get; set; }

    public DateOnly fecha_inicio { get; set; }

    public DateOnly fecha_fin { get; set; }

    public string Estado { get; set; } = null!;



}
