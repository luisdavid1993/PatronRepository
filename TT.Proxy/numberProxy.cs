using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TT.Dto;
using TT.Proxy.NetCrackerService;
using TT.Uils.MapperBase;

namespace TT.Proxy
{
  public class numberProxy: InumberProxy {
        NM_pttClient _netCracker;
        HeaderRequest _headerRequest;

        public numberProxy() {
            _netCracker = new NM_pttClient();
            _headerRequest = new HeaderRequest();
            _headerRequest.transactionId = string.Empty;
            _headerRequest.system = string.Empty;
        }

        public getNumberResponseDto get(getNumberRequestDto getNumberRequest){

            getNumbers_TYPE _getNumbers_TYPE = MapperConfigurationCentral<getNumberRequestDto, getNumbers_TYPE>.MapEntity(getNumberRequest);

            _getNumbers_TYPE.headerRequest = _headerRequest;
            getNumbersResp_TYPE _getNumbersResp_TYPE = _netCracker.getNumbers(_getNumbers_TYPE);
            getNumberResponseDto _getNumberResponseDto = new getNumberResponseDto();
            _getNumberResponseDto.transaction_id = _getNumbersResp_TYPE.transaction_id;
            List<NumberElementDto> _respuesta = MapperConfigurationCentral<NumberElement, NumberElementDto>.MapListList(_getNumbersResp_TYPE.list_of_numbers.ToList());
            _getNumberResponseDto.list_of_numbers = _respuesta;
            return _getNumberResponseDto;
      
        }

        public reserveNumbersResponseDto reserve(reserveNumbersRequestDto _reserveNumbersRequestDto){
            reserveNumbers_TYPE _reserveNumbers_TYPE= MapperConfigurationCentral<reserveNumbersRequestDto, reserveNumbers_TYPE>.MapEntity(_reserveNumbersRequestDto);
            _reserveNumbers_TYPE.headerRequest = _headerRequest;
            reserveNumbersResponseDto _respuesta = MapperConfigurationCentral<reserveNumbersResp_TYPE, reserveNumbersResponseDto>.MapEntity(_netCracker.reserveNumbers(_reserveNumbers_TYPE));
            throw new NotImplementedException();
        }
    }
}
