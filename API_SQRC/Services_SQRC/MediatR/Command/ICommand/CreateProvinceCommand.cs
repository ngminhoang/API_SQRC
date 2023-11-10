using MediatR;
using Services_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_SQRC.MediatR.Command.ICommand
{
    public record CreateProvinceCommand(ProvinceModel province) : IRequest<bool>
    {
    }
}
