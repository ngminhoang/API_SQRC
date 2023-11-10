using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Services.IServices;
using AutoMapper;
using Services_4.Models;

namespace API_6._0_SQRC.Services.Services
{
    public class CommandProvinceService : ICommandProvinceService
    {
        private readonly ICommandProvinceRepository rp;
        private readonly IMapper map;
        public CommandProvinceService(IMapper map, ICommandProvinceRepository rp)
        {
            this.rp = rp;
            this.map = map;
        }
        public bool create(ProvinceModel entity)
        {
            try
            {
                Province rs = map.Map<Province>(entity);
                return rp.create(rs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool update(int id, ProvinceModel entity)
        {
            try
            {
                ProvinceModel entity1 = entity;
                entity1.provinceID = id;
                Province rs = map.Map<Province>(entity1);
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
