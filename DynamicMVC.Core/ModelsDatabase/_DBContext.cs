using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Threading.Tasks;


namespace DynamicMVC.Core.ModelsDatabase
{
    public partial class DBContext : DbContext
    {
        public DBContext()
#if DEBUG
            : base()
#else
            : base("ReleaseConnection", throwIfV1Schema: false)
#endif

        {
                
        }

        public static DBContext Create()
        {
            return new DBContext();
        }
    }
}