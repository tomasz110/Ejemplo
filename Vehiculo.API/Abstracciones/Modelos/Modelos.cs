namespace Abstracciones.Modelos
{
    public class ModelosBase
    {
        public string Nombre { get; set; }


    }

    public class ModeloResponse : ModelosBase
    {
        public Guid Id { get; set; }
        public string Marca { get; set; }
    }

}
