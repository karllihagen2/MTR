using MTR.Models;
using MTR.Station;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTR.Services
{
    public class StationService : IStationService
    {
        private readonly IGetStation _getStation;

        public StationService(IGetStation getStation)
        {
            _getStation = getStation;
        }
        public async Task<Root> GetStationBasedOnCoordinate(string firstCoordinate)
        {
            return await _getStation.ReturnStationBasedOnCoordinate(firstCoordinate);
        }
    }
}
