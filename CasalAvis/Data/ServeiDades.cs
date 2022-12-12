using Microsoft.EntityFrameworkCore;
using CasalAvis.Estructures;
using Microsoft.Data.SqlClient;

namespace CasalAvis.Data
{
    public class ServeiDades: DbContext
    {
        public string usuariAutenticat = "";
        //public BotigaTaula BotigaSeleccionada; //per quan necessiti pasar la botiga de una pagina auna altra

        public readonly ApplicationDbContext dbContext;

        public ServeiDades(ApplicationDbContext _db)
        {
            dbContext = _db;
        }
        public List<BotigaTaula> ObtenirBotigues()
        {
            return dbContext.botigaTaula.FromSqlRaw("SelectBotiguesTaula").ToList();
        }
    }
}
