using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Services.IServices;
using AutoMapper;
using Services_4.Models;

namespace API_6._0_SQRC.Services.Services
{
    public class QueryWardService : IQueryWardService
    {
        private readonly IQueryWardRepository rp;
        private readonly IMapper map;
        public QueryWardService(IMapper map, IQueryWardRepository rp)
        {
            this.rp = rp;
            this.map = map;
        }
        public List<WardModel> getAll()
        {
            try
            {
                List<Ward> ls = rp.getAll();
                List<WardModel> rs = new List<WardModel>();
                foreach (Ward p in ls)
                {
                    rs.Add(map.Map<WardModel>(p));
                }
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public WardModel get(int id)
        {
            try
            {
                Ward x = rp.get(id);
                WardModel rs = map.Map<WardModel>(x);
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
