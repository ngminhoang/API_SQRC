using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using API_6._0_SQRC.Repositories.Repositories;
using AutoMapper;
using MediatR;
using Services_4.Models;
using Services_SQRC.MediatR.Query.IQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_SQRC.MediatR.Query.IQueryHandler
{
    public class ProvinceQueryHandler : IRequestHandler<GetAllProvinceQuery, List<Province>>, IRequestHandler<GetProvinceQuery, ProvinceModel>
    {
        private readonly IQueryProvinceRepository _repository;
        private readonly IMapper _mapper;
        public ProvinceQueryHandler(IMapper mapper,IQueryProvinceRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }
        public Task<ProvinceModel> Handle(GetProvinceQuery request, CancellationToken cancellationToken)
        {
            // Sử dụng repository để lấy danh sách tất cả sinh viên
            Province ls = _repository.get(request.id);
            ProvinceModel rs = _mapper.Map<ProvinceModel>(ls);
            return Task.FromResult(rs);
        }
        public  Task<List<Province>> Handle(GetAllProvinceQuery request, CancellationToken cancellationToken)
        {
            // Sử dụng repository để lấy danh sách tất cả sinh viên
            List<Province> ls = _repository.getAll();
           
            return Task.FromResult(ls);
        }
       

    }
}
