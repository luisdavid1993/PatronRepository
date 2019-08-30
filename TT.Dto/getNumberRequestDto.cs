using System;


namespace TT.Dto
{
    public class getNumberRequestDto
    {
        public headerRequestNetCrackerDto _headerRequestGetNumber { get;set;}
        public string crm_in_use { get; set; }

        public string request_id{ get; set; }

        public string area_code{ get; set; }

        public string country_code{ get; set; }

        public string metropolitan_area{ get; set; }

        public string city_code{ get; set; }

        public bool consecutive_number{ get; set; }

        public bool consecutive_numberSpecified{ get; set; }

        public string quantity_numbers{ get; set; }

        public string transaction_id{ get; set; }

        public string number_mask{ get; set; }

        public string initial_number{ get; set; }

        public string final_number{ get; set; }

        public string segment_in_use{ get; set; }

        public string segment_code_in_use{ get; set; }

        public string category{ get; set; }

        public string customer_name{ get; set; }

        public string customer_id{ get; set; }

        public string customer_id_type{ get; set; }

        public string account_id{ get; set; }

        public string customer_location{ get; set; }

        public string service_in_use{ get; set; }

        public string service_id{ get; set; }

        public string order_number{ get; set; }

        public string[] supplementary_services{ get; set; }

        public string consultant{ get; set; }

        public string service_order_number{ get; set; }

        public string service_order_type{ get; set; }

        public string contract{ get; set; }

        public DateTime inservice_date{ get; set; }

        public bool inservice_dateSpecified{ get; set; }

        public DateTime quarantine_date{ get; set; }

        public bool quarantine_dateSpecified{ get; set; }

        public DateTime disconnection_date{ get; set; }

        public bool disconnection_dateSpecified{ get; set; }

        public DateTime reservation_date{ get; set; }

        public bool reservation_dateSpecified{ get; set; }

        public DateTime quarantine_due_date{ get; set; }

        public bool quarantine_due_dateSpecified{ get; set; }

        public DateTime reservation_due_date{ get; set; }

        public bool reservation_due_dateSpecified{ get; set; }

        public string disconnection_reason{ get; set; }

        public string status{ get; set; }
    }
}
