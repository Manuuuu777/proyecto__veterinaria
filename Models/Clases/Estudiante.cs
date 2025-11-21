namespace proyecto_ESD.Models.Clases
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public DateTime FechaNacimiento { get; set; }
        public string Email { get; set; } = string.Empty;
    }

}
