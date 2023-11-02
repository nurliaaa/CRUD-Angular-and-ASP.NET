using Angular2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular2.Services
{
    public interface IPositionsService
    {
        Task<IEnumerable<Positions>> GetPositionsList();
    }
}
