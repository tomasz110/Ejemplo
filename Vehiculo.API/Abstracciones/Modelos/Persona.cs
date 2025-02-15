namespace Abstracciones.Modelos
{
    public class PersonaBase
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
    }

    public class PersonaResponse : PersonaBase
    {
        public Guid Id { get; set; }
    }
}
