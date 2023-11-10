using API_6._0_SQRC.Repositories.Entities;
using MediatR;
using Services_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_SQRC.MediatR.Query.IQuery
{
    public record GetProvinceQuery(int id) : IRequest<ProvinceModel>
    {
    }
}
