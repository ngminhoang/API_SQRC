using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;

namespace API_6._0_SQRC.Repositories.Repositories
{
    public class QueryWardRepository : IQueryWardRepository
    {
        private readonly EFcontext db;
        public QueryWardRepository(EFcontext db)
        {
            this.db = db;
        }
        public Ward get(int id)
        {
            try
            {
                try
                {
                    Ward rs = db.Wards.Where(e => e.WardID == id).FirstOrDefault();
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

        public List<Ward> getAll()
        {
            try
            {
                try
                {
                    List<Ward> rs = db.Wards.ToList();
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
