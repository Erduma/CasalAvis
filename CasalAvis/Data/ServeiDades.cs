using Microsoft.EntityFrameworkCore;

namespace CasalAvis.Data
{
    public class ServeiDades: DbContext
    {
        public string usuariAutenticat = "";

        public readonly ApplicationDbContext dbContext;

        public ServeiDades(ApplicationDbContext _db)
        {
            dbContext = _db;
        }
    }
}
