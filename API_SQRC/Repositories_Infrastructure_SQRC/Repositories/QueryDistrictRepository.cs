using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;

namespace API_6._0_SQRC.Repositories.Repositories
{
    public class QueryDistrictRepository: IQueryDistrictRepository
    {
        private readonly EFcontext db;
        public QueryDistrictRepository(EFcontext db) 
        {
            this.db = db;
        }
        public District get(int id)
        {
            try
            {
                try
                {
                   District rs = db.Districts.Where(e => e.DistrictID == id).FirstOrDefault();
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

        public List<District> getAll()
        {
            try
            {
                try
                {
                    List<District> rs = db.Districts.ToList();
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
