using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;

namespace API_6._0_SQRC.Repositories.Repositories
{
    public class QueryProvinceRepository : IQueryProvinceRepository
    {
        private readonly EFcontext db;
        public QueryProvinceRepository(EFcontext db)
        {
            this.db = db;
        }
        public Province get(int id)
        {
            try
            {
                try
                {
                    Province rs = db.Provinces.Where(e => e.ProvinceID == id).FirstOrDefault();
                    return rs;

                }
                catch
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<Province>> getAlll()
        {
            try
            {
                try
                {
                    List<Province> rs = db.Provinces.ToList();
                    return  rs;

                }
                catch
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public List<Province> getAll()
        {
            try
            {
                try
                {
                    List<Province> rs = db.Provinces.ToList();
                    return rs;

                }
                catch
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
