﻿using System.ComponentModel.DataAnnotations;

namespace Abstracciones.Modelos
{
    public class VehiculoBase
    {
        [Required(ErrorMessage = "La propiedad placa es requerida")]
        [RegularExpression(@"[A-Za-z]{3}-[0-9]{3}", ErrorMessage = "El formato de la placa debe ser ABC-###")]
        public string Placa { get; set; }
        [Required(ErrorMessage = "La propiedad color es requerida")]
        [StringLength(40,ErrorMessage ="El tamaño de la propiedad color debe ser mayor a 4 caracteres y menor a 40", MinimumLength =4)]
        public string Color { get; set; }
        [Required(ErrorMessage = "La propiedad año es requerida")]
        [RegularExpression(@"(19|20)\d\d", ErrorMessage ="El formato del año no es válido")]
        public int Anio { get; set; }
        [Required(ErrorMessage = "La propiedad precio es requerida")]
        public Decimal Precio { get; set; }
        [Required(ErrorMessage = "La propiedad correo es requerida")]
        [EmailAddress]
        public string CorreoPropietario { get; set; }
        [Required(ErrorMessage = "La propiedad telefono es requerida")]
        [Phone]
        public string TelefonoPropietario { get; set; }

    }
    public class VehiculoRequest : VehiculoBase { 
    public Guid IdModelo { get; set; }
    
    }

    public class VehiculoResponse : VehiculoBase
    {
        public Guid Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
    }

    public class VehiculoDetalle : VehiculoResponse
    {
        public bool RevisionValida { get; set; }
        public bool RegistroValido { get; set; }
    }
}
