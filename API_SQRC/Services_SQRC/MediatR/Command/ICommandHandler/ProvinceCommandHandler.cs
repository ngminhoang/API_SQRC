using API_6._0_SQRC.Repositories.Entities;
using API_6._0_SQRC.Repositories.IRepositories;
using AutoMapper;
using MediatR;
using Services_4.Models;
using Services_SQRC.MediatR.Command.ICommand;
using Services_SQRC.MediatR.Query.IQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_SQRC.MediatR.Command.ICommandHandler
{
    public class ProvinceCommandHandler : IRequestHandler<CreateProvinceCommand, bool>, IRequestHandler<UpdateProvinceCommand, bool>, IRequestHandler<DeleteProvinceCommand, bool>
    {
        private readonly ICommandProvinceRepository _repository;
        private readonly IQueryProvinceRepository _repository1;
        private readonly IMapper _mapper;
        public ProvinceCommandHandler(IQueryProvinceRepository repository1, IMapper mapper, ICommandProvinceRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
            _repository1 = repository1;
        }


        public Task<bool> Handle(CreateProvinceCommand request, CancellationToken cancellationToken)
        {
            Province x = _mapper.Map<Province>(request.province);
            return Task.FromResult(_repository.create(x));
        }
        public Task<bool> Handle(UpdateProvinceCommand request, CancellationToken cancellationToken)
        {
            ProvinceModel entity1 = request.province;
            entity1.provinceID = request.id;
            Province x = _mapper.Map<Province>(entity1);
            return Task.FromResult(_repository.update(x));
        }
        public Task<bool> Handle(DeleteProvinceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_repository.delete(request.id));
        }
    }
}
