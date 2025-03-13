public partial class Usuario
{
    [Key]
    public int id_usuario { get; set; }
    [Required (ErrorMessage ="El Nombre es obligatorio") ]

    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "El nombre solo puede contener letras y espacios.")]
    public string Nombre { get; set; } = null!;

    [EmailAddress(ErrorMessage = "El correo no es válido.")]
    [Required(ErrorMessage = "El Correo es obligatorio")]
    public string Correo { get; set; } = null!;


    [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
    [RegularExpression(@"^[a-zA-Z0-9]*$", ErrorMessage = "La contraseña no debe contener signos especiales.")]
    [Required(ErrorMessage = "La contraseña es obligatorio")]
    public string Contrasena { get; set; } = null!;

    [Required(ErrorMessage = "La direccion es obligatorio")]
    public string? Direccion { get; set; }



}
