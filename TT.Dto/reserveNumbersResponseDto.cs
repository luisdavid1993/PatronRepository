using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Dto
{
   public class reserveNumbersResponseDto
    {
        public string transaction_id{ get; set; }

        public string code{ get; set; }

        public string description{ get; set; }

        public DateTime operation_date{ get; set; }
    }
}
