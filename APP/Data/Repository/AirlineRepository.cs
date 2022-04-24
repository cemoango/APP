
using APP.Business.Intefaces;
using APP.Business.Models;
using APP.Data.Context;

namespace APP.Data.Repository
{
    public class AirlineRepository : Repository<Airline>, IAirlineRepository
    {
        public AirlineRepository(APPDBContext context) : base(context) { }
    }
}