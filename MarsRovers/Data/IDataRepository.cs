using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarsRovers.Data
{
    public interface IDataRepository
    {
        IEnumerable<Rover> GetInstructions();
    }
}
