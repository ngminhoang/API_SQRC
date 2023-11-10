using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;

namespace API_6._0_SQRC.Repositories.Repositories
{
    public class CommandWardRepository : ICommandWardRepository
    {
        private readonly EFcontext db;
        public CommandWardRepository(EFcontext db)
        {
            this.db = db;
        }
        public bool create(Ward Ward)
        {
            try
            {
                try
                {
                    db.Wards.Add(Ward);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool update(Ward Ward)
        {
            try
            {
                try
                {
                    db.Wards.Update(Ward);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool delete(int id)
        {
            try
            {
                try
                {
                    Ward ward = db.Wards.Where(x => x.WardID == id).FirstOrDefault(); ;
                    db.Wards.Remove(ward);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
