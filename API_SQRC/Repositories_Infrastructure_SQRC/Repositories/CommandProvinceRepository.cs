using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;

namespace API_6._0_SQRC.Repositories.Repositories
{
    public class CommandProvinceRepository: ICommandProvinceRepository
    {
        private readonly EFcontext db;
        public CommandProvinceRepository(EFcontext db)
        {
            this.db = db;
        }
        public bool create(Province province)
        {
            try
            {
                try
                {
                    db.Provinces.Add(province);
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
        public bool update(Province province)
        {
            try
            {
                try
                {
                    db.Provinces.Update(province);
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
                    Province pro = db.Provinces.Where(x => x.ProvinceID == id).FirstOrDefault(); ;
                    db.Provinces.Remove(pro);
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
