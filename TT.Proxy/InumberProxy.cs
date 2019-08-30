using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;
using TT.Proxy.NetCrackerService;

namespace TT.Proxy
{
    interface InumberProxy
    {
        getNumberResponseDto get(getNumberRequestDto getNumberRequest);
        reserveNumbersResponseDto reserve(reserveNumbersRequestDto _reserveNumbersRequestDto);
    }
}
