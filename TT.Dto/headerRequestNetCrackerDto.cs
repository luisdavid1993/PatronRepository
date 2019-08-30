using System;


namespace TT.Dto
{
  public class headerRequestNetCrackerDto
    {
        public string transactionId{ get; set; }

        public string system{ get; set; }

        public string target{ get; set; }

        public string user{ get; set; }

        public string password{ get; set; }

        public DateTime requestDate{ get; set; }

        public string ipApplication{ get; set; }

        public string traceabilityId{ get; set; }
    }
}
