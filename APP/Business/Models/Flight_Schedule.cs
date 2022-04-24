using System.ComponentModel;

namespace APP.Business.Models
{
    public class Flight_Schedule : Entity
    {
        [DisplayName("Voos")]
        public Guid? flightID { get; set; }

        [DisplayName("Aeroporto")]
        public Guid? airportID { get; set; }

        [DisplayName("Horario")]
        public DateTime time { get; set; }

        [DisplayName("Compania")]
        public Guid? airlineID { get; set; }
        public bool status { get; set; }
        public string to_fromStatus { get; set; }

        /* EF Relation */
        public Flight flightOBJ { get; set; }
        public Airport airportOBJ { get; set; }
        public Airline airlineOBJ { get; set; }

    }

}
