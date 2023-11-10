using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Services.IServices;
using AutoMapper;
using Services_4.Models;

namespace API_6._0_SQRC.Services.Services
{
    public class CommandWardService : ICommandWardService
    {
        private readonly ICommandWardRepository rp;
        private readonly IMapper map;
        public CommandWardService(IMapper map, ICommandWardRepository rp)
        {
            this.rp = rp;
            this.map = map;
        }
        public bool create(WardModel entity)
        {
            try
            {
                Ward rs = map.Map<Ward>(entity);
                return rp.create(rs);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool update(int id, WardModel entity)
        {
            try
            {
                WardModel entity1 = entity;
                entity1.wardID = id;
                Ward rs = map.Map<Ward>(entity1);
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
