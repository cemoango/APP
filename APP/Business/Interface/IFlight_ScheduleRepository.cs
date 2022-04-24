using APP.Business.Intefaces;
using APP.Business.Models;
using AIR.ViewModels;
using APP.ViewModels;

namespace APP.Business.Interface
{
    public interface IFlight_ScheduleRepository : IRepository<Flight_Schedule>
    {
        Task<IEnumerable<Flight_Schedule>> GetAllFlight_Schedule();
        List<Flight_ScheduleViewModels> GetAllFlight_ScheduleJS();

    }
}
