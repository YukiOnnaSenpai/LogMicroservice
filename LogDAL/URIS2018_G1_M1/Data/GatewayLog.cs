using System;

namespace LogDAL.URIS2018_G1_M1.Data
{
    public class GatewayLog
    {
        public int GatewayLogId { get; set; }
        public int UserId { get; set; }
        public DateTime StartTimestamp { get; set; }
        public DateTime EndTimestamp { get; set; }
        public string GatewayEndpoint { get; set; }
    }
}
