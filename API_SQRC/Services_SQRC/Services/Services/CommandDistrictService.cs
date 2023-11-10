using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Services.IServices;
using AutoMapper;
using Services_4.Models;

namespace API_6._0_SQRC.Services.Services
{
    public class CommandDistrictService : ICommandDistrictService
    {
        private readonly ICommandDistrictRepository rp;
        private readonly IMapper map;
        public CommandDistrictService(IMapper map, ICommandDistrictRepository rp)
        {
            this.rp = rp;
            this.map = map;
        }
        public bool create(DistrictModel entity)
        {
            try
            {
                District rs = map.Map<District>(entity);
                return rp.create(rs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool update(int id, DistrictModel entity)
        {
            try
            {
                DistrictModel entity1 = entity;
                entity1.districtID = id;
                District rs = map.Map<District>(entity1);
                return rp.update(rs);
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
                return rp.delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
