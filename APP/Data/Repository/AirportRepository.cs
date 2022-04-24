

using APP.Business.Intefaces;
using APP.Business.Models;
using APP.Data.Context;

namespace APP.Data.Repository
{
    public class AirportRepository : Repository<Airport>, IAirportRepository
    {
        public AirportRepository(APPDBContext context) : base(context) { }
    }
}