using System;

namespace LogDAL.URIS2018_G1_M1.Data
{
    public class ErrorLog
    {
        public int ErrorId { get; set; }
        public string ErrrType { get; set; }
        public string ErrorEndpoint { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
