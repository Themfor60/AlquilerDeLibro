using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlquilerDeLibro.Models;

public partial class Usuario
{
    [Key]
    public int id_usuario { get; set; }
    [Required (ErrorMessage ="El Nombre es obligatorio") ] 
    public string Nombre { get; set; } = null!;


    [Required(ErrorMessage = "El Correo es obligatorio")]
    public string Correo { get; set; } = null!;

    [Required(ErrorMessage = "La contraseña es obligatorio")]
    public string Contrasena { get; set; } = null!;

    [Required(ErrorMessage = "La direccion es obligatorio")]
    public string? Direccion { get; set; }



}
