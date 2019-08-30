using System;


namespace TT.Dto
{
  public  class NumberElementDto
    {

        public string number{ get; set; }

        public string city_code{ get; set; }

        public string metropolitan_area{ get; set; }

        public string service_in_use{ get; set; }

        public string service_id{ get; set; }

        public string[] supplementary_services{ get; set; }

        public string customer_name{ get; set; }

        public string customer_id{ get; set; }

        public string customer_id_type{ get; set; }

        public string account_id{ get; set; }

        public string customer_location{ get; set; }

        public string status{ get; set; }

        public string service_order_number{ get; set; }

        public string order_number{ get; set; }

        public string category{ get; set; }

        public string consultant{ get; set; }

        public DateTime inservice_date{ get; set; }

        public bool inservice_dateFieldSpecified;

        public DateTime quarantine_date{ get; set; }

        public bool quarantine_dateFieldSpecified;

        public DateTime disconnection_date{ get; set; }

        public bool disconnection_dateFieldSpecified;

        public DateTime reservation_date{ get; set; }

        public bool reservation_dateFieldSpecified;

        public DateTime quarantine_due_date{ get; set; }

        public bool quarantine_due_dateFieldSpecified;

        public DateTime reservation_due_date{ get; set; }

        public bool reservation_due_dateFieldSpecified;

        public string disconnection_reason{ get; set; }

        public string[] corresponding_numbers{ get; set; }

        public string core_network_element{ get; set; }
    }
}
