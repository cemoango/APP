

namespace APP.ViewModels
{
    public class Flight_ScheduleViewModels
    {
        public Guid Id { get; set; }
        public string flight { get; set; }
        public string airport { get; set; }
        public string status { get; set; }
        public string airline { get; set; }
        public DateTime time { get; set; }
        public string to_fromStatus { get; set; }

        //public IEnumerable<FlightViewModels> flights { get; set; }
        //public IEnumerable<AirportViewModels> airports { get; set; }
        //public IEnumerable<AirlineViewModels> airlines { get; set; }

    }

}
