using Microsoft.EntityFrameworkCore;
using System.Linq;
using LogDAL.URIS2018_G1_M1.Data;

namespace LogDAL.Repositories.Implementations.Data
{
    public class ErrorLogImplementation : BaseRepositoryImpl<ErrorLog,int>
    {
        public override ErrorLog GetById(int id)
        {
            context.Database.OpenConnection();
            ErrorLog log = context.Set<ErrorLog>().Where(e => e.ErrorId == id).Select(e => e).AsQueryable().FirstOrDefault();
            context.SaveChanges();
            context.Database.CloseConnection();
            return log;
        }
    }
}
