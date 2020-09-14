using AutoMapper;
using Store.API.Models;
using Store.API.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.API.AutoMappers
{
    public class CurrentUserProfile : Profile
    {
        public CurrentUserProfile()
        {
            CreateMap<AccountModel, CurrentAccountResponseModel>();
        }
    }
}
