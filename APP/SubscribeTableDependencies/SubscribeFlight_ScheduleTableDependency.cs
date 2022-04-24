using APP.Business.Models;
using APP.Extensions;
using TableDependency.SqlClient;

namespace APP.SubscribeTableDependencies
{

    public class SubscribeFlight_ScheduleTableDependency : ISubscribeTableDependency
    {
        SqlTableDependency<Flight_Schedule> _tableDependency;
        Flight_ScheduleHub _flight_ScheduleHub;

        public SubscribeFlight_ScheduleTableDependency(Flight_ScheduleHub flight_ScheduleHub)
        {
            _flight_ScheduleHub = flight_ScheduleHub;
        }   

        public void SubscribeTableDependency(string connectionString)
        {
            _tableDependency = new SqlTableDependency<Flight_Schedule>(connectionString);
            _tableDependency.OnChanged += TableDependency_OnChanged;
            _tableDependency.OnError += TableDependency_OnError;
            _tableDependency.Start();
        }

        private void TableDependency_OnChanged(object sender, TableDependency.SqlClient.Base.EventArgs.RecordChangedEventArgs<Flight_Schedule> e)
        {
            if (e.ChangeType != TableDependency.SqlClient.Base.Enums.ChangeType.None)
            {
                _flight_ScheduleHub.SendFlight_Schedule();
            }
        }

        private void TableDependency_OnError(object sender, TableDependency.SqlClient.Base.EventArgs.ErrorEventArgs e)
        {
            Console.WriteLine($"{nameof(Flight_Schedule)} SqlTableDependency error: {e.Error.Message}");
        }
    }
}
