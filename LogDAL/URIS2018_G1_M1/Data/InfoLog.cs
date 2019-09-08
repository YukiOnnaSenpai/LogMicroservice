using System;

namespace LogDAL.URIS2018_G1_M1.Data
{
    public class InfoLog
    {
        public int InfoLogId { get; set; }
        public DateTime UserCreatedOn { get; set; }
        public DateTime UserEmailValidatedOn { get; set; }
        public DateTime UserAdressValidatedOn { get; set; }
        public DateTime UserCreditCardValidatedOn { get; set; }
    }
}
