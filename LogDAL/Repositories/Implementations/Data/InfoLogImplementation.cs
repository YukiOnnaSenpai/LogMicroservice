using Microsoft.EntityFrameworkCore;
using System.Linq;
using LogDAL.URIS2018_G1_M1.Data;

namespace LogDAL.Repositories.Implementations.Data
{
    public class InfoLogImplementation : BaseRepositoryImpl<InfoLog, int>
    {
        public override InfoLog GetById(int id)
        {
            context.Database.OpenConnection();
            InfoLog log = context.Set<InfoLog>().Where(e => e.InfoLogId == id).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return log;
        }
    }
}
