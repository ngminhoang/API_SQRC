using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Services.IServices;
using AutoMapper;
using Services_4.Models;
using System.Runtime.CompilerServices;

namespace API_6._0_SQRC.Services.Services
{
    public class QueryDistrictService : IQueryDistrictService
    {
        private readonly IQueryDistrictRepository rp;
        private readonly IMapper map;
        public QueryDistrictService(IMapper map, IQueryDistrictRepository rp) 
        {
            this.rp = rp;
            this.map = map;
        }
        public List<DistrictModel> getAll()
        {
            try
            {
                List<District> ls= rp.getAll();
                List<DistrictModel> rs = new List<DistrictModel>();
                foreach (District p in ls)
                {
                    rs.Add(map.Map<DistrictModel>(p));
                }
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DistrictModel get(int id) 
        {
            try
            {
                District x = rp.get(id);
                DistrictModel rs = map.Map<DistrictModel>(x);
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
