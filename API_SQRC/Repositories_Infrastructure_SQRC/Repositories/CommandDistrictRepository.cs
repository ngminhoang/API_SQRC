using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;

namespace API_6._0_SQRC.Repositories.Repositories
{
    public class CommandDistrictRepository: ICommandDistrictRepository
    {
        private readonly EFcontext db; 
        public CommandDistrictRepository(EFcontext db) 
        {
            this.db = db;
        }
        public bool create(District district)
        {
            try
            {
                try
                {
                    db.Districts.Add(district);
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
        public bool update(District district)
        {
            try
            {
                try
                {
                    db.Districts.Update(district);
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
                    District dis = db.Districts.Where(x => x.DistrictID == id).FirstOrDefault(); ;
                    db.Districts.Remove(dis);
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
