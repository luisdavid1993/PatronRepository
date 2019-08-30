using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Dto
{
   public class getNumberResponseDto
    {
        public string transaction_id{ get; set; }
        public  List<NumberElementDto> list_of_numbers { get; set; }
    }
}
