

using APP.Business.Intefaces;
using APP.Business.Models;
using APP.Data.Context;

namespace APP.Data.Repository
{
    public class FlightRepository : Repository<Flight>, IFlightRepository
    {
        public FlightRepository(APPDBContext context) : base(context) { }
    }
}