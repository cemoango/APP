using APP.Business.Interface;
using APP.Data.Context;
using AutoMapper;
using Microsoft.AspNetCore.SignalR;

namespace APP.Extensions
{
    public class Flight_ScheduleHub : Hub
    {
        private readonly IFlight_ScheduleRepository _flight_ScheduleRepository;

        public Flight_ScheduleHub(IFlight_ScheduleRepository flight_ScheduleRepository)
        {
            _flight_ScheduleRepository = flight_ScheduleRepository;
        }
        public async Task SendFlight_Schedule()
        {
                
            await Clients.All.SendAsync("ReceivedFlight_Schedule", _flight_ScheduleRepository.GetAllFlight_ScheduleJS());

        }

    }
}
