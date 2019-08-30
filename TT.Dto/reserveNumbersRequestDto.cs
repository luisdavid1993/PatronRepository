using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT.Dto
{
  public class reserveNumbersRequestDto
    {
        public headerRequestNetCrackerDto headerRequest { get; set; }

        public string crm_in_use{ get; set; }

        public string request_id{ get; set; }

        public string transaction_id{ get; set; }

        public string country_code{ get; set; }

        public string area_code{ get; set; }

        public string status{ get; set; }

        public string customer_name{ get; set; }

        public string customer_id{ get; set; }

        public string customer_id_type{ get; set; }

        public string account_id { get; set; }

        public string customer_location{ get; set; }

        public string service_id{ get; set; }

        public string order_number{ get; set; }

        public string service_order_number{ get; set; }

        public string[] supplementary_services{ get; set; }

        public string city_code{ get; set; }
    }
}
