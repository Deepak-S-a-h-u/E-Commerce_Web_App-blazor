using Application.Common.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IElectronicRepository
    {
        Task<ElectronicsDto> GetAll();
        Task<ElectronicsDto> Add();
    }
}
