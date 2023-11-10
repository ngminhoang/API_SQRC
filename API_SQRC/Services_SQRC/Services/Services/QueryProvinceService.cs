using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Services.IServices;
using AutoMapper;
using Services_4.Models;

namespace API_6._0_SQRC.Services.Services
{
    public class QueryProvinceService : IQueryProvinceService
    {
        private readonly IQueryProvinceRepository rp;
        private readonly IMapper map;
        public QueryProvinceService() { }
        public QueryProvinceService(IMapper map, IQueryProvinceRepository rp)
        {
            this.rp = rp;
            this.map = map;
        }
        public List<ProvinceModel> getAll()
        {
            try
            {
                List<Province> ls = rp.getAll();
                List<ProvinceModel> rs = new List<ProvinceModel>();
                foreach (Province p in ls)
                {
                    rs.Add(map.Map<ProvinceModel>(p));
                }
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProvinceModel get(int id)
        {
            try
            {
                Province x = rp.get(id);
                ProvinceModel rs = map.Map<ProvinceModel>(x);
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
