using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;

namespace TT.Repository.Logs.Interfaces
{
    public interface IlogRepository {

         void error(errorDto _error);
        void trazaApi (errorDto _error);

    }
}
