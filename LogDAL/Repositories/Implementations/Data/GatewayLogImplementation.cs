using Microsoft.EntityFrameworkCore;
using System.Linq;
using LogDAL.URIS2018_G1_M1.Data;

namespace LogDAL.Repositories.Implementations.Data
{
    public class GatewayLogImplementation : BaseRepositoryImpl<GatewayLog, int>
    {
        public override GatewayLog GetById(int id)
        {
            context.Database.OpenConnection();
            GatewayLog log = context.Set<GatewayLog>().Where(e => e.GatewayLogId == id).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return log;
        }
    }
}
