using MTR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTR.Services
{
    public interface IStationService
    {
        Task<Root> GetStationBasedOnCoordinate(string firstCoordinate);
    }
}
