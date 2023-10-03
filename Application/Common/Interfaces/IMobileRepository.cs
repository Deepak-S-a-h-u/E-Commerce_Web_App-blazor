using Application.Common.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
    public interface IMobileRepository
    {
        Task<IEnumerable<MobileDto>> GetmobileDetails();
        Task<MobileDto> GetMobileById(int mobileid);
        Task<MobileDto> AddMobile(MobileDto mobile);
        Task<MobileDto> UpdateMobile(MobileDto mobile);
        Task<MobileDto> DeleteMobile(int mobileid);
        Task saveChanges();
    }
}
