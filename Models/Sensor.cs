namespace FacilitiesSensor.Models
{
    public class Sensor
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public double ValorActual { get; set; }

        public string Unidad { get; set; }
    }
}